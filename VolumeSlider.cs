using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ToneGenerator
{
    /// <summary>
    /// Tweaked volume slider that is double buffered and fixes divide by 0 bug on Windows XP.
    /// </summary>
    public class VolumeSlider : UserControl
    {
        /// <summary>
        /// Creates a new VolumeSlider control.
        /// </summary>
        public VolumeSlider()
        {
            Name = "VolumeSlider";
            Size = new Size(96, 16);
        }

        /// <summary>
        /// The volume for this control.
        /// </summary>
        private float volume = 1f;
        [DefaultValue(1f)]
        public float Volume
        {
            get { return volume; }
            set
            {
                if (value < 0f)
                    value = 0f;
                if (value > Utilities.DbToMag(maximumDB))
                    value = Utilities.DbToMag(maximumDB);
                if (volume != value)
                {
                    volume = value;
                    if (VolumeChanged != null)
                        VolumeChanged(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        private float minimumDB = -60;
        /// <summary>
        /// Gets or sets the minimum decibel volume for the control.
        /// </summary>
        public float MinimumDB
        {
            get { return minimumDB; }
            set
            {
                minimumDB = value;
                Invalidate();
            }
        }

        private float maximumDB = 0;
        /// <summary>
        /// Gets or sets the minimum decibel volume for the control.
        /// </summary>
        public float MaximumDB
        {
            get { return maximumDB; }
            set
            {
                maximumDB = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Volume changed event
        /// </summary>
        public event EventHandler? VolumeChanged;

        /// <summary>
        /// Raises the <see cref="HandleCreated"/> event.
        /// </summary>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            DoubleBuffered = true;
        }

        /// <summary>
        /// <see cref="M:System.Windows.Forms.Control.OnMouseDown(System.Windows.Forms.MouseEventArgs)" />
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            SetVolumeFromMouse(e.X);
            base.OnMouseDown(e);
        }

        /// <summary>
        /// <see cref="M:System.Windows.Forms.Control.OnMouseMove(System.Windows.Forms.MouseEventArgs)" />
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                SetVolumeFromMouse(e.X);
            base.OnMouseMove(e);
        }

        /// <summary>
        /// Raises the <see cref="Resize"/> event.
        /// </summary>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="Paint"/> event.
        /// </summary>
        /// <param name="pe">A <see cref="PaintEventArgs"/> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
            float db = Utilities.MagToDb(volume);
            float fraction = 1f - (db - maximumDB) / (minimumDB - maximumDB);
            int width = (int)((Width - 2) * fraction);
            pe.Graphics.FillRectangle(Brushes.LightGreen, 1, 1, Math.Max(0, width), Height - 2);
            using (var stringFormat = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                pe.Graphics.DrawString(string.Format(CultureInfo.CurrentCulture, "{0:F2} dB", db), Font, Brushes.Black, ClientRectangle, stringFormat);
            }
        }

        private void SetVolumeFromMouse(int x)
        {
            Volume = x <= 0 ? 0f : Utilities.DbToMag(maximumDB + (1f - (float)x / (Width - 2)) * (minimumDB - maximumDB));
        }
    }
}

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ToneGenerator
{
    /// <summary>
    /// Tweaked volume slider that is double buffered and fixes divide by 0 bug on Windows XP.
    /// </summary>
    [CLSCompliant(false)]
    public class VolumeSlider : NAudio.Gui.VolumeSlider
    {
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
        /// Raises the <see cref="Paint"/> event.
        /// </summary>
        /// <param name="pe">A <see cref="PaintEventArgs"/> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
            float db = 20f * (float)Math.Log10(Volume);
            float fraction = 1f - db / -48.0f;
            int width = (int)((float)(Width - 2) * fraction);
            pe.Graphics.FillRectangle(Brushes.LightGreen, 1, 1, Math.Max(0, width), Height - 2);
            using (var stringFormat = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                pe.Graphics.DrawString(string.Format(CultureInfo.CurrentCulture, "{0:F2} dB", db), Font, Brushes.Black, ClientRectangle, stringFormat);
            }
        }
    }
}

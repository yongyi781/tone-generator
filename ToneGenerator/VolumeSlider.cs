using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ToneGenerator
{
    [CLSCompliant(false)]
    public class VolumeSlider : NAudio.Gui.VolumeSlider
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
            float db = 20f * (float)Math.Log10(Volume);
            float f = 1f - db / -48.0f;
            int width = (int)((float)(Width - 2) * f);
            pe.Graphics.FillRectangle(Brushes.LightGreen, 1, 1, Math.Max(0, width), Height - 2);
            using (var stringFormat = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                pe.Graphics.DrawString(string.Format(CultureInfo.CurrentCulture, "{0:F2} dB", db), Font, Brushes.Black, ClientRectangle, stringFormat);
            }
        }
    }
}

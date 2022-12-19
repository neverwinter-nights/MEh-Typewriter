using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MEh_Typewriter
{
    public static partial class Helper
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CHARRANGE
        {
            public int cpMin;               // First character of range (0 for start of doc)
            public int cpMax;               // Last character of range (-1 for end of doc)
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct FORMATRANGE
        {
            public IntPtr hdc;           // Actual DC to draw on
            public IntPtr hdcTarget;     // Target DC for determining text formatting
            public RECT rc;            // Region of the DC to draw to (in twips)
            public RECT rcPage;        // Region of the whole DC (page size) (in twips)
            public CHARRANGE chrg;          // Range of text to draw (see earlier declaration)
        }

        public static int GetRtbContentWidth(RichTextBox rtb)
        {
            if (IsVerticalScrollBarVisible(rtb))
            {
                return rtb.Width - SystemInformation.VerticalScrollBarWidth;
            }
            else
            {
                return rtb.Width;
            }
        }

        public static SizeF GetRtbAllContentSize(RichTextBox rtb, Settings settings, int maxWidth)
        {
            SizeF size;
            using (Graphics g = rtb.CreateGraphics())
            {
                Rectangle r = new Rectangle();
                PaintEventArgs ea = new PaintEventArgs(g, r);
                System.Drawing.Font font = new System.Drawing.Font(settings.Font.Name, settings.Font.Size);
                size = ea.Graphics.MeasureString(rtb.Text, font, maxWidth);
            }

            return size;
        }

        public static void RenderRtbToBitmap(RichTextBox rtb, Bitmap bmp, Settings settings)
        {
            Graphics g = Graphics.FromImage(bmp);
            RectangleF rectf = new RectangleF(0, 0, bmp.Width, bmp.Height);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(rtb.Text, new System.Drawing.Font(settings.Font.Name, settings.Font.Size), Brushes.Black, rectf);
            g.Flush();
        }

        public static Bitmap CropBitmap(Bitmap b, Rectangle r)
        {
            Bitmap nb = new Bitmap(r.Width, r.Height);

            using (Graphics g = Graphics.FromImage(nb))
            {
                g.DrawImage(b, -r.X, -r.Y);
                return nb;
            }
        }
    }
}

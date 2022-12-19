using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MEh_Typewriter
{
    public static partial class Helper
    {
        private enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }

        private const uint WM_VSCROLL = 0x0115;
        private const uint SB_THUMBPOSITION = 4;
        private const int WM_USER = 0x0400;
        private const int EM_FORMATRANGE = WM_USER + 57;

        // Convert the unit used by the .NET framework (1/100 inch) 
        // and the unit used by Win32 API calls (twips 1/1440 inch)
        private const double anInch = 14.4;


        // Makes a Screenshot of the RichTextBox as a Bitmap.
        // It captures only visible Content.
        public static Bitmap CatchRtbToBitmap(RichTextBox rtb)
        {
            rtb.Update();

            int vsbWidth = SystemInformation.VerticalScrollBarWidth;

            Bitmap bmp;
            if (IsVerticalScrollBarVisible(rtb))
            {
                bmp = new Bitmap(rtb.Width - vsbWidth, rtb.Height);
            }
            else
            {
                bmp = new Bitmap(rtb.Width, rtb.Height);
            }

            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(rtb.PointToScreen(Point.Empty), Point.Empty, new Size(bmp.Width, bmp.Height));
            }

            return bmp;
        }


        // Checks whether the Vertical Scrollbar of the Control is visible or not.
        public static bool IsVerticalScrollBarVisible(Control ctl)
        {
            int style = GetWindowLong(ctl.Handle, -16);
            return (style & 0x200000) != 0;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private extern static int GetWindowLong(IntPtr hWnd, int index);


        // Gets the amount of Vertical Scroll of the Control.
        public static int GetVScrollPos(Control control)
        {
            return GetScrollPos(control.Handle, (int)ScrollBarType.SbVert);
        }

        [DllImport("User32.dll")]
        private extern static int GetScrollPos(IntPtr hWnd, int nBar);


        // Sets the amount of Vertical Scroll to the Control.
        public static void SetVScrollPos(Control control, int newPos)
        {
            uint wParam = SB_THUMBPOSITION | (uint)newPos;
            SendMessage(control.Handle, (int)WM_VSCROLL, new IntPtr(wParam), new IntPtr(0));
        }
        [DllImport("User32.dll")]
        private extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
    }
}

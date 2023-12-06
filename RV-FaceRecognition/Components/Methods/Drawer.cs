using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace RV_FaceRecognition.Components
{
    public static class Drawer
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize, bool RoundTop = false)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            
            // Need round only top?
            if (RoundTop)
            {
                gp.AddLine(rect.X + rect.Width, rect.Y + RoundSize, rect.X + rect.Width, rect.Y + rect.Height);
                gp.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y + RoundSize);
            }
            else
            {
                gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
                gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);
            }

            gp.CloseFigure();

            return gp;
        }
    }
}

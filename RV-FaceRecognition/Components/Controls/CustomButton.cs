using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RV_FaceRecognition.Components.Controls
{
    public class CustomButton : Control
    {
        #region -- Свойства --

        public bool roundingEnable = false;
        [Description("ON/OFF Rounding for object")]
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding [%]")]
        [DefaultValue(100)]
        [Description("Specifies the radius of rounding of the object as a percentage")]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;
                    Refresh();
                }
            }
        }

        #endregion

        #region -- Values --

        private readonly StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressedd = false;

        #endregion
        public CustomButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(225, 40);

            Font = new Font("Open Sans", 16F, FontStyle.Regular);

            BackColor = Color.FromArgb(69, 162, 189);
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            g.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Rounding
            float roundValue = 0.1F;
            if(RoundingEnable && roundingPercent > 0)
            {
                roundValue = Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundValue);

            // Draw rectangle
            g.DrawPath(new Pen(BackColor), rectPath);
            g.FillPath(new SolidBrush(BackColor), rectPath);

            g.SetClip(rectPath);

            if (MouseEntered)
            {
                g.DrawRectangle(new Pen(Color.FromArgb(30, Color.White)), rect);
                g.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), rect);
            }
            if (MousePressedd)
            {
                g.DrawRectangle(new Pen(Color.FromArgb(15, Color.White)), rect);
                g.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), rect);
            }

            g.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressedd = true;
         
            Invalidate();

            Focus();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressedd = false;

            Invalidate();
        }
    }
}

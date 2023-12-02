using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RV_FaceRecognition.Components.Controls
{
    class RoundedTableLayoutPanel : TableLayoutPanel
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

        private Color backColor = Color.FromArgb(3, 3, 3);
        private Color borderColor = Color.FromArgb(69, 162, 189);

        public RoundedTableLayoutPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Rounding
            float roundValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
            {
                roundValue = this.Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundValue);

            // Draw rectangle
            g.DrawPath(new Pen(backColor), rectPath);
            g.FillPath(new SolidBrush(backColor), rectPath);

            // Draw border
            g.DrawPath(new Pen(borderColor), rectPath);

            g.DrawLine(new Pen(borderColor), this.Width / 2, 0, this.Width / 2, this.Height);

            g.SetClip(rectPath);
        }

        protected override void OnResize(EventArgs e) {  
            base.OnResize(e); 
        }
    }
}

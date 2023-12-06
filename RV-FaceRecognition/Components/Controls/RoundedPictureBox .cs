using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RV_FaceRecognition.Components.Controls
{
    class RoundedPictureBox : PictureBox
    {
        public bool roundingEnable = false;
        [Description("ON/OFF Rounding for object")]
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Update();
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
                    Update();
                }
            }
        }

        public RoundedPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Rounding
            float roundValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
            {
                roundValue = Height / 100F * roundingPercent;
            }

            GraphicsPath rectPath = Drawer.RoundedRectangle(new Rectangle(0, 0, this.Width - 1, this.Height - 1), roundValue);
            this.Region = new Region(rectPath);
        }
    }
}

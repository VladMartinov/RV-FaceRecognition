using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        // private bool MousePressedd = false;

        Point ClickLocation = new Point();

        #endregion
        public CustomButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(225, 40);

            Font = new Font("Montserrat", 16F, FontStyle.Regular);

            BackColor = Color.FromArgb(69, 162, 189);
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }
    }
}

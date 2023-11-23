using System;
using System.Windows.Forms;
using System.Drawing;

namespace RV_FaceRecognition.Components.Controls
{
    public class CustomCheckBox : Control
    {
        #region Private Members
        /// <summary>
        /// Label for checkbox text
        /// </summary>
        private readonly Label CheckBoxLabel;
        #endregion

        #region Public Members (in Attributes)
        /// <summary>
        /// CheckBox chekcer.
        /// </summary>
        private bool IsCheckedValue = false;
        public bool IsChecked
        {
            get { return IsCheckedValue; }
            set
            {
                if (IsChecked != value)
                {
                    IsCheckedValue = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Check if mouse is over the control
        /// </summary>
        private bool MouseOver = false;

        /// <summary>
        /// Font for checkbox text.
        /// </summary>
        private Font CheckBoxFontValue;
        public Font CheckBoxFont
        {
            get
            {
                return CheckBoxFontValue;
            }
            set
            {
                if (CheckBoxFont != value)
                {
                    CheckBoxFontValue = value;
                    RefreshLabel();
                }
            }
        }

        /// <summary>
        /// Text for checkbox description
        /// </summary>
        private string CheckBoxTextValue = "My CheckBox";
        public string CheckBoxText
        {
            get 
            { 
                return CheckBoxTextValue; 
            }
            set 
            { 
                if (CheckBoxText != value)
                {
                    CheckBoxTextValue = value; 
                    RefreshLabel();
                }
            }
        }

        /// <summary>
        /// Size of the checkbox.
        /// </summary>
        private int ChecBoxSizeValue = 15;
        public int CheckBoxSize
        {
            get
            {
                return ChecBoxSizeValue;
            }
            set
            {
                if (ChecBoxSizeValue != value)
                {
                    ChecBoxSizeValue = value;
                    RefreshLabel();
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// FrameStrength for the checkbox.
        /// </summary>
        private int ChecBoxFrameStrengthValue = 1;
        public int CheckBoxFrameStrength
        {
            get
            {
                return ChecBoxFrameStrengthValue;
            }
            set
            {
                if (ChecBoxFrameStrengthValue != value)
                {
                    ChecBoxFrameStrengthValue = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// FrameColor for the checkbox.
        /// </summary>
        private Color ChecBoxFrameColorValue = Color.FromArgb(0, 0, 0);
        public Color CheckBoxFrameColor
        {
            get
            {
                return ChecBoxFrameColorValue;
            }
            set
            {
                if (ChecBoxFrameColorValue != value)
                {
                    ChecBoxFrameColorValue = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// BackColor for the checkbox.
        /// </summary>
        private Color ChecBoxBackColorValue = Color.FromArgb(0, 0, 0);
        public Color CheckBoxBackColor
        {
            get
            {
                return ChecBoxBackColorValue;
            }
            set
            {
                if (ChecBoxBackColorValue != value)
                {
                    ChecBoxBackColorValue = value;
                    Invalidate();
                }
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for custom CheckBox
        /// </summary>
        public CustomCheckBox() 
        {
            // Double buffered
            DoubleBuffered = true;

            // Default size
            Size = new Size(112, 35);

            // Set font
            CheckBoxFont = this.Font;

            // Create the lable
            var midHeight = 9 - Font.Height / 2;
            CheckBoxLabel = new Label()
            {
                Font = CheckBoxFont,
                Size = new Size(this.Width - 16, this.Height),
                Location = new Point(20, midHeight),
                Text = CheckBoxText
            };

            // Add lable to control
            Controls.Add(CheckBoxLabel);

            // Create event
            CreateMouseEvent();
        }
        #endregion

        #region Create Mouse Events
        /// <summary>
        /// Create mouse events for mouse hover, up and down
        /// </summary>
        private void CreateMouseEvent()
        {
            // Mouse Enter .
            MouseEnter += (sender, e) =>
            {
                OnCustomMouseEnter();
            };
            MouseLeave += (sender, e) =>
            {
                OnCustomMouseLeave();
            };


            // Mouse Enter label.
            CheckBoxLabel.MouseEnter += (sender, e) =>
            {
                OnCustomMouseEnter();
            };
            CheckBoxLabel.MouseLeave += (sender, e) =>
            {
                OnCustomMouseLeave();
            };
            CheckBoxLabel.MouseDown += (sender, e) =>
            {
                OnMouseDown(e);
            };
        }

        /// <summary>
        /// Mouse over event.
        /// </summary>
        private void OnCustomMouseEnter()
        {
            if (!MouseOver)
            {
                // Switch
                MouseOver = true;

                // Force repaint
                Invalidate();
            }
        }

        /// <summary>
        /// Mouse leave event.
        /// </summary>
        private void OnCustomMouseLeave()
        {
            if (MouseOver)
            {
                // Switch
                MouseOver = false;

                // Force repaint
                Invalidate();
            }
        }

        /// <summary>
        /// Mouse down event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (IsChecked) return;
            IsChecked = !IsChecked;

            Invalidate();
        }
        #endregion

        #region Paint Custom CheckBox [OnPaint]
        /// <summary>
        /// Default paint.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Paint checkbox rectangle
            PaintRectangle(e);
        }
        #endregion

        #region Paint CheckBox Rectangle
        /// <summary>
        /// Paint the checkbox rectangle
        /// </summary>
        /// <param name="e"></param>
        private void PaintRectangle(PaintEventArgs e)
        {
            // Create checkbox rectangle
            var midHeight = Height / 2 - CheckBoxSize / 2;

            var rectFrame = Drawer.RoundedRectangle(new Rectangle(0, midHeight, CheckBoxSize, CheckBoxSize), (CheckBoxSize / 100f) * 35f);
            var rectInner = Drawer.RoundedRectangle(new Rectangle(3, midHeight + 3, CheckBoxSize - 5, CheckBoxSize - 5), ((CheckBoxSize - 5) / 100f) * 15f);

            // Draw rectangle frame
            using (var pen = new Pen(MouseOver ? Color.FromArgb(200, CheckBoxFrameColor) : CheckBoxFrameColor, CheckBoxFrameStrength))
            {
                var brush = new SolidBrush(MouseOver ? Color.FromArgb(200, CheckBoxFrameColor) : CheckBoxBackColor);
                e.Graphics.DrawPath(pen, rectFrame);
                if (IsChecked) e.Graphics.FillPath(brush, rectInner);
            }

        }
        #endregion

        #region [OnResize]
        /// <summary>
        /// Default resize.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Call refresh label
            RefreshLabel();
        }
        #endregion

        #region Refresh Label
        /// <summary>
        /// Refresh the label while design time.
        /// </summary>
        private void RefreshLabel()
        {
            // Catch and break
            if (CheckBoxLabel == null) return;

            // Set label font
            CheckBoxLabel.Font = CheckBoxFont;

            // Set label text
            CheckBoxLabel.Text = CheckBoxText;

            // Get and set new size
            var offsetWidth = Width - CheckBoxSize;
            CheckBoxLabel.Size = new Size(offsetWidth, Height);

            // Get and set new position
            var offsetX = CheckBoxSize + 6;
            var midHeight = Height / 2 - CheckBoxFont.Height / 2;
            CheckBoxLabel.Location = new Point(offsetX, midHeight);
        }
        #endregion
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RV_FaceRecognition.Components.Controls
{
    public class CustomTextBox : Control
    {
        #region -- Varibales --

        readonly StringFormat SF = new StringFormat();

        TextBox tbInput = new TextBox();

        #endregion

        #region -- Parametrs --

        public Font FontTextPreview { get; set; } = new Font("Open Sans", 10, FontStyle.Regular);

        public Color borderColor = Color.FromArgb(69, 162, 189);
        public Color borderColorFocus = Color.White;

        public string TextInput
        {
            get => tbInput.Text;
            set => tbInput.Text = value;
        }

        public bool UseSystemPasswordChar
        {
            get => tbInput.UseSystemPasswordChar;
            set => tbInput.UseSystemPasswordChar = value;
        }

        public new string Text
        {
            get => tbInput.Text;
            set => tbInput.Text = value;
        }

        public int MaxLength
        {
            get => (int)tbInput.MaxLength;
            set => tbInput.MaxLength = value;
        }

        #endregion

        public CustomTextBox() 
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(255, 20);

            Font = new Font("Open Sans", 10F, FontStyle.Bold);

            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

            AdjustTextBoxInput();
            this.Controls.Add(tbInput);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox
            {
                Name = "InputBox",
                BorderStyle = BorderStyle.None,
                BackColor = BackColor,
                ForeColor = ForeColor,
                Font = Font,
                Location = new Point(5, 1 / 5)
            };
            tbInput.Size = new Size(Width - 10, tbInput.Height);
        }

        #region -- Update parametrs --

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            tbInput.BackColor = BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            tbInput.ForeColor = ForeColor;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbInput.Font = Font;
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            g.Clear(Parent.BackColor);

            // Bottom border
            g.DrawLine(new Pen(tbInput.Focused ? borderColorFocus : borderColor) { Width = 2f }, 0, Height - 1, Width - 1, Height - 1);
        }
    }
}

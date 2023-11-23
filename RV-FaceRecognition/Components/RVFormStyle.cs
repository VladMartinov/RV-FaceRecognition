using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RV_FaceRecognition.Components;

namespace RV_FaceRecognition.Components
{
    public partial class RVFormStyle : Component
    {
        #region -- Proprties --

        public Form Form {  get; set; }

        private fStyle formStyle = fStyle.None;
        public fStyle FormStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }
        }
        public enum fStyle
        {
            None,
            UserStyle,
            SimpleDark,
            TelegramStyle
        }

        #endregion

        #region -- Values --

        private Color HeaderColor = Color.FromArgb(203, 219, 226);
        private int HeaderHeight = 20;

        private Size IconSize = new Size(12, 14);

        private StringFormat SF = new StringFormat();
        private Font Font = new Font("Open Sans", 10f, FontStyle.Bold);

        // Form move event
        bool MousePressed = false;
        Point clickPosition;
        Point moveStartPosition;

        Rectangle rectBtnClose = new Rectangle();
        private Color CloseBtnBgColor = Color.FromArgb(69, 162, 189);
        private Pen CloseBtnCrosshairColor = new Pen(Color.FromArgb(37, 87, 115)) { Width = 2f };

        bool BtnCloseHovered = false;

        #endregion

        public RVFormStyle()
        {
            InitializeComponent();
        }

        public RVFormStyle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Sign()
        {
            if (Form != null)
            {
                Form.Load += Form_Load;
            }
        }

        private void Apply()
        {
            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;

            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Region = Region.FromHrgn(Drawer.CreateRoundRectRgn(0, 0, Form.Width, Form.Height, 20, 20));

            SetDoubleBuffered(Form);

            OffsetControls();

            Form.Paint += Form_Paint;
            Form.MouseMove += Form_MouseMove;
            Form.MouseUp += Form_MouseUp;
            Form.MouseDown += Form_MouseDown;
            Form.MouseLeave += Form_MouseLeave;
        }

        private void OffsetControls()
        {
            Form.Height = Form.Height + HeaderHeight;

            foreach (Control ctrl in Form.Controls)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + HeaderHeight);
                ctrl.Refresh();
            }
        }

        #region -- Form Events --

        private void Form_Load(object sender, EventArgs e)
        {
            Apply();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                Size formOffset = new Size( Point.Subtract( Cursor.Position, new Size(clickPosition) ) );
                Form.Location = Point.Add(moveStartPosition, formOffset);
            }
            else
            {
                if (rectBtnClose.Contains(e.Location))
                {
                    if (!BtnCloseHovered)
                    {
                        BtnCloseHovered = !BtnCloseHovered;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (BtnCloseHovered)
                    {
                        BtnCloseHovered = !BtnCloseHovered;
                        Form.Invalidate();
                    }
                }
            }
        }

        private void Form_MouseLeave(object sender, EventArgs e)
        {
            BtnCloseHovered = false;
            Form.Invalidate();
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;

            if (e.Button == MouseButtons.Left && rectBtnClose.Contains(e.Location)) Form.Close();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeight)
            {
                MousePressed = true;

                clickPosition = Cursor.Position;
                moveStartPosition = Form.Location;
            }
        }

        #endregion

        private void DrawStyle(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectHeader = new Rectangle(0, 0, Form.Width - 1, HeaderHeight);

            Rectangle rectTitleText = new Rectangle(rectHeader.X + 25, rectHeader.Y, rectHeader.Width, rectHeader.Height);
            Rectangle rectIcon = new Rectangle(
                rectHeader.X + 8,
                rectHeader.Height / 2 - IconSize.Height / 2,
                IconSize.Width, IconSize.Height
                );

            rectBtnClose = new Rectangle(rectHeader.Width - 35, rectHeader.Y, 35, rectHeader.Height);
            Rectangle rectCrosshair = new Rectangle(
                rectBtnClose.X + rectBtnClose.Width / 2 - 4,
                rectBtnClose.Height / 2 - 4,
                8, 8
                );

            // Header
            g.DrawRectangle(new Pen(HeaderColor), rectHeader);
            g.FillRectangle(new SolidBrush(HeaderColor), rectHeader);

            // Header Icon
            g.DrawImage(Form.Icon.ToBitmap(), rectIcon);

            // Header text
            g.DrawString(Form.Text, Font, new SolidBrush(Color.Black), rectTitleText, SF);

            // Header close button
            g.DrawRectangle(new Pen(BtnCloseHovered ? HeaderColor : CloseBtnBgColor), rectBtnClose);
            g.FillRectangle(new SolidBrush(BtnCloseHovered ? HeaderColor : CloseBtnBgColor), rectBtnClose);

            DrawCrossHair(g, rectCrosshair, CloseBtnCrosshairColor);
        }

        private void DrawCrossHair(Graphics g, Rectangle rect, Pen pen)
        {
            g.DrawLine(pen, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            g.DrawLine(pen, rect.X + rect.Width, rect.Y, rect.X, rect.Y + rect.Height);
        }

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                typeof(Control).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);
            pDoubleBuffered.SetValue(c, true, null);
        }
    }
}

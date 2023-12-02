using RV_FaceRecognition.Components.Controls;
using System.ComponentModel;
using System.Windows.Forms;

namespace RV_FaceRecognition.Components
{
    public partial class RoundingButtonsComponent : Component
    {
        #region -- Свойства --

        public Form TargetForm { get; set; }

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

        [DefaultValue(true)]
        [Description("Apply rounding to nested containers")]
        public bool NestedContainers { get; set; } = true;

        #endregion
        public RoundingButtonsComponent()
        {
            InitializeComponent();
        }

        public RoundingButtonsComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Update()
        {
            if (TargetForm != null && TargetForm.Controls.Count > 0)
            {
                DefineRounding(TargetForm.Controls);
            }
        }

        public void DefineRounding(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is CustomButton)
                {
                    CustomButton button = (CustomButton)control;

                    button.RoundingEnable = RoundingEnable;
                    button.Rounding = Rounding;

                    button.Refresh();
                }

                if (NestedContainers)
                {
                    if (control.Controls.Count > 0)
                    {
                        DefineRounding(control.Controls);
                    }
                }
            }
        }
    }
}

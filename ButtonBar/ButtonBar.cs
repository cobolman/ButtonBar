using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonBar
{
    public partial class ButtonBar: UserControl
    {
        int btnWidth = 74;
        int btnHeight = 38;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Button> Buttons
        { get; set; }

        public int Count
        { 
            get { return Buttons.Count; }
        }

        public Button GetButton(int index)
        {
            if (index >= 0 && index < Buttons.Count)
                return Buttons[index];
            else
                return null;
        }

        public event EventHandler ButtonPush;

        public ButtonBar()
        {
            InitializeComponent();
            Buttons = new List<Button>();
            InitializeButtons();
        }

        private void ShowHidePriorNextButtons()
        {
            if (Buttons.Count * btnWidth < this.Width)
            {
                btnPrior.Visible = false;
                btnNext.Visible = false;
            }
            else
            {
                btnPrior.Visible = true;
                btnNext.Visible = true;
            }
        }

        public void Add(String btnLabel)
        {
            Button btn = new Button();

            btn.Location = new Point(Buttons.Count * btnWidth, 0);
            btn.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btn.Text = btnLabel.ToUpper();

            btn.TabIndex = Buttons.Count * 10;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.Click += HandleButtonPush;

            Buttons.Add(btn);
            this.Controls.Add(btn);
            ShowHidePriorNextButtons();
        }

        public void Remove(Button item)
        {
            Buttons.Remove(item);

            for (int n = 0; n < Buttons.Count; n++ )
            {
                Buttons[n].Location = new Point(n * btnWidth, 0);
            }

            ShowHidePriorNextButtons();
        }

        private void InitializeButtons()
        {
            ShowHidePriorNextButtons();
        }

        private void HandleButtonPush(object sender, EventArgs e)
        {
            OnButtonPush(sender, e);
        }

        protected virtual void OnButtonPush(object sender, EventArgs e)
        {
            EventHandler handler = ButtonPush;
            if (handler != null)
            {
                handler(sender, e);
            }
        }


        private void btnPrior_Click(object sender, EventArgs e)
        {
            if (Buttons[0].Location.X != 0)
            {
                for (int n = 0; n < Buttons.Count; n++)
                {
                    int x = Buttons[n].Location.X;
                    int y = Buttons[n].Location.Y;
                    Buttons[n].Location = new Point(x + 74, y);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Buttons[Buttons.Count-1].Location.X > 444)
            {
                for (int n = 0; n < Buttons.Count; n++)
                {
                    int x = Buttons[n].Location.X;
                    int y = Buttons[n].Location.Y;
                    Buttons[n].Location = new Point(x - 74, y);
                }
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAerodrome : Form
    {

        private readonly Aerodrome<Aircraft> aerodrome;

        public FormAerodrome()
        {
            InitializeComponent();
            aerodrome = new Aerodrome<Aircraft>(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aerodrome.Draw(gr);
            pictureBoxAerodrome.Image = bmp;
        }

        private void buttonLandAircraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var aircraft = new Aircraft(100, 1000, dialog.Color);
                if (aerodrome + aircraft)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Мест нет");
                }
            }
        }

        private void buttonLandAirbus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var aircraft = new Airbus(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (aerodrome + aircraft)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Мест нет");
                    }
                }
            }
        }

        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var aircraft = aerodrome - Convert.ToInt32(maskedTextBox.Text);
                if (aircraft != null)
                {
                    FormAircraft form = new FormAircraft();
                    form.SetAircraft(aircraft);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}

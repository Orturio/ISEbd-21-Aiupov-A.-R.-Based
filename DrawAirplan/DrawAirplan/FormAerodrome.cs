using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAerodrome : Form
    {

        private readonly AerodromeCollection aerodromeCollection;

        public FormAerodrome()
        {
            InitializeComponent();
            aerodromeCollection = new AerodromeCollection(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxAerodromes.SelectedIndex;
            listBoxAerodromes.Items.Clear();
            for (int i = 0; i < aerodromeCollection.Keys.Count; i++)
            {
                listBoxAerodromes.Items.Add(aerodromeCollection.Keys[i]);
            }
            if (listBoxAerodromes.Items.Count > 0 && (index == -1 || index >=
listBoxAerodromes.Items.Count))
            {
                listBoxAerodromes.SelectedIndex = 0;
            }
            else if (listBoxAerodromes.Items.Count > 0 && index > -1 && index <
listBoxAerodromes.Items.Count)
            {
                listBoxAerodromes.SelectedIndex = index;
            }
        }


        private void Draw()
        {           
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()].Draw(gr);
                pictureBoxAerodrome.Image = bmp;
            }
        }

        private void buttonAddAerodrome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название аэродрома", "Ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            aerodromeCollection.AddAerodrome(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }

        private void buttonDeleteAerodrome_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром {listBoxAerodromes.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    aerodromeCollection.DelAerodrome(listBoxAerodromes.Text);
                    textBoxNewLevelName.Text = "";
                    ReloadLevels();
                }
            }
        }

        private void buttonLandAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var aircraft = new Aircraft(100, 1000, dialog.Color);
                    if (aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()] + aircraft)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Аэродром переполнен");
                    }
                }
            }
        }

        private void buttonLandAirbus_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {                   
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var aircraft = new Airbus(100, 1000, dialog.Color,
dialogDop.Color, true, true);
                        if (aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()] + aircraft)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Парковка переполнена");
                        }
                    }
                }
            }
        }

        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var aircraft = aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()] -
Convert.ToInt32(maskedTextBox.Text);
                if (aircraft != null)
                {
                    FormAircraft form = new FormAircraft();
                    form.SetAircraft(aircraft);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void listBoxAerodromes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

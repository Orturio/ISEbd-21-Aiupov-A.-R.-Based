using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAircraftConfig : Form
    {
        Vehicle aircraft = null;
        
        //private event AircraftDelegate eventAddAircraft;

        public event Action<Vehicle> eventAddAircraft;

        public FormAircraftConfig()
        {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawAircraft()
        {
            if (aircraft != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aircraft.SetPosition(10, 50, pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                aircraft.DrawTransport(gr);
                pictureBoxAircraft.Image = bmp;
            }
        }

        //public void AddEvent(Action<Vehicle> ev)
        //{
        //    if (eventAddAircraft == null)
        //    {
        //        eventAddAircraft = new Action<Vehicle>(ev);
        //    }
        //    else
        //    {
        //        eventAddAircraft += ev;
        //    }
        //}

        private void labelAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraft.DoDragDrop(labelAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelAirbus_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirbus.DoDragDrop(labelAirbus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelAircraft_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelAircraft_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолёт":
                    aircraft = new Aircraft((int)numericUpDownMaxSpeed.Value,
(int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Эйрбас":
                    aircraft = new Airbus((int)numericUpDownMaxSpeed.Value,
 (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxDopChassie.Checked, checkBoxLowerWindows.Checked);
                    break;
            }
            DrawAircraft();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {          
            if (aircraft != null)
            {
                aircraft.SetMainColor(Color.FromName(e.Data.GetData(DataFormats.Text).ToString()));
                DrawAircraft();
            }          
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (aircraft != null && aircraft is Airbus)
            {
                (aircraft as Airbus).SetDopColor(Color.FromName(e.Data.GetData(DataFormats.Text).ToString()));
                DrawAircraft();
            }
        }
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddAircraft?.Invoke(aircraft);
            Close();
        }        
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAircraft : Form
    {
        private ITransport aircraft;

        public FormAircraft()
        {
            InitializeComponent();
        }
       
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aircraft.DrawTransport(gr);
            pictureBoxAircraft.Image = bmp;
        }
       
        private void buttonCreateAircraft_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aircraft = new Aircraft(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightBlue);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft.Width,
pictureBoxAircraft.Height);
            Draw();
        }

        private void buttonCreateAirbus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aircraft = new Airbus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightBlue,
Color.Black, true, true);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft.Width,
pictureBoxAircraft.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    aircraft.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    aircraft.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    aircraft.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    aircraft.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}

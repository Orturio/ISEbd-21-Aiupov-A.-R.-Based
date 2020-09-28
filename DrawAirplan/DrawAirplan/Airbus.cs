using System.Drawing;

namespace DrawAirplan
{
    public class Airbus : Aircraft
    {      
        public Color DopColor { private set; get; }
       
        public bool AirplanChassis { private set; get; }
       
        public bool LowerWindows { private set; get; }
       
        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool airplanChassis, bool lowerWindows) :
            base(maxSpeed, weight, mainColor, 220, 100)
        {
            DopColor = dopColor;
            AirplanChassis = airplanChassis;
            LowerWindows = lowerWindows;          
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);

            base.DrawTransport(g);

            if (AirplanChassis)
            {
                g.FillEllipse(dopBrush, _startPosX + 45, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 55, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 155, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 165, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 175, _startPosY + 30, 10, 10);                                              
            }

            if (LowerWindows)
            {
                g.DrawEllipse(pen, _startPosX + 190, _startPosY + 15, 5, 5);
                g.DrawEllipse(pen, _startPosX + 160, _startPosY + 15, 5, 5);
                g.DrawEllipse(pen, _startPosX + 150, _startPosY + 15, 5, 5);
                g.DrawEllipse(pen, _startPosX + 140, _startPosY + 15, 5, 5);
                g.DrawEllipse(pen, _startPosX + 130, _startPosY + 15, 5, 5);
                g.DrawEllipse(pen, _startPosX + 120, _startPosY + 15, 5, 5);
            }

        }
    }
}

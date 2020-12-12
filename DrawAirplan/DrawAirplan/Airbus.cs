using System.Drawing;
using System;

namespace DrawAirplan
{
    public class Airbus : Aircraft, IEquatable<Airbus>
    {      
        public Color DopColor { private set; get; }
       
        public bool AirplanChassis { private set; get; }
       
        public bool LowerWindows { private set; get; }
       
        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool airplanChassis, bool lowerWindows):
            base(maxSpeed, weight, mainColor, 220, 100)
        {
            DopColor = dopColor;
            AirplanChassis = airplanChassis;
            LowerWindows = lowerWindows;          
        }

        public Airbus(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                AirplanChassis = Convert.ToBoolean(strs[4]);
                LowerWindows = Convert.ToBoolean(strs[5]);                
            }
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

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return$"{base.ToString()}{separator}{DopColor.Name}{separator}{AirplanChassis}{separator}{LowerWindows}";
        }

        public bool Equals(Airbus other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (AirplanChassis != other.AirplanChassis)
            {
                return false;
            }
            if (LowerWindows != other.LowerWindows)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Airbus carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
    }
}

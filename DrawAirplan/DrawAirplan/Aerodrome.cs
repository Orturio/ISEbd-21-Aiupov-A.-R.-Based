using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawAirplan
{
    public class Aerodrome<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;    

        private readonly int pictureHeight;
        
        private readonly int _placeSizeWidth = 380;
        
        private readonly int _placeSizeHeight = 90;
        
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Aerodrome(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new List<T>();
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Aerodrome<T> a, T aircraft)
        {
            if (a._places.Count >= a._maxCount)
            {
                throw new AerodromeOverflowException();
            }
            a._places.Add(aircraft);
            return true;
        }


        public static T operator -(Aerodrome<T> a, int index)
        {
            if (index < -1 || index > a._places.Count)
            {
                throw new AerodromeNotFoundException(index);
            }
            T car = a._places[index];
            a._places.RemoveAt(index);
            return car;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(5 + i / 4 * _placeSizeWidth + 5, i % 4 *
_placeSizeHeight + 30, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}

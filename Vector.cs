using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Vector
    {
        private double angle;
        private double length;
        private Vector2 coordinates;
        public Vector(double angle, double length)
        {
            this.angle = angle;
            if (length < 0)
                length = Math.Abs(length);
            this.length = length;
            coordinates = setCoordinates(angle, length);
        }
        public Vector()
        {
            
        }
        public Vector2 setCoordinates(double angle, double length)//обчислення координат вектора на основі його довжини та кута
        {
            double x = Math.Round(length * Math.Cos(angle), 2);
            double y = Math.Round(length * Math.Sin(angle), 2);
            Vector2 result = new Vector2((float)x, (float)y);
            return result;
        }
        public Vector2 getCoordinates
        {
            get { return coordinates; }
        }
        public void vectorData ()
        {
            Console.WriteLine($"\nКоординати вектора: {coordinates}\nКут вектора: {angle}");
        }
        public void changeCoordinates(Vector2 newCoordinates)
        {
            coordinates.X = newCoordinates.X;
            coordinates.Y = newCoordinates.Y;
        }
        ~Vector()
        {
            Console.WriteLine("The end");
        }
    }
}
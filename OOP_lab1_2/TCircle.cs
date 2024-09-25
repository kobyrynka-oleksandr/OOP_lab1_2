using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1_2
{
    public class TCircle
    {
        protected double radius;

        public TCircle()
        {
            radius = 1;
        }
        public TCircle(double radius)
        {
            this.radius = radius;
        }
        public TCircle(TCircle circle)
        {
            radius = circle.radius;
        }
        public double GetRadius
        {
            get
            {
                return radius;
            }
        }
        public override string ToString()
        {
            return "Radius: " + radius;
        }
        public double GetArea
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
        public double GetCircuit
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }
        public static TCircle operator +(TCircle circle1, TCircle circle2)
        {
            TCircle temp = new TCircle(circle1.radius + circle2.radius);
            return temp;
        }
        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            TCircle temp = new TCircle(Math.Max(0, circle1.radius - circle2.radius));
            return temp;
        }
        public static TCircle operator *(TCircle r, double k)
        {
            TCircle temp = new TCircle(r.radius * k);
            return temp;
        }
        public static TCircle operator *(double k, TCircle r)
        {
            TCircle temp = new TCircle(k * r.radius);
            return temp;
        }
        public void Input()
        {
            Console.WriteLine("Radius of circle:");
            radius = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public int CompareTo(TCircle secondRadius)
        {
            return radius.CompareTo(secondRadius.radius);
        }
        public int Compare(TCircle secondCircle)
        {
            if (radius < secondCircle.GetRadius)
            {
                return -1;
            }
            else if (radius == secondCircle.GetRadius)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    public class TCylinder : TCircle
    {
        private double height;

        public TCylinder() : base()
        {
            height = 1;
        }
        public TCylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public TCylinder(TCylinder cylinder) : base(cylinder)
        {
            height = cylinder.height;
        }
        public override string ToString()
        {
            return "Radius: " + radius + ", " + "Height: " + height;
        }
        public double GetVolume
        {
            get
            {
                return GetArea * height;
            }
        }
        public new void Input()
        {
            base.Input();
            Console.WriteLine("Height: ");
            height = double.Parse(Console.ReadLine());
        }
        public new void Output()
        {
            Console.WriteLine(ToString());
        }
    }
}

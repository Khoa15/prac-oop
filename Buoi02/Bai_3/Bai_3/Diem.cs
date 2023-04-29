using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class Diem
    {
        double x;
        double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Diem()
        {

        }
        public void Nhap()
        {
            Console.WriteLine("Nhap x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y");
            y = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("({0}, {0})", x, y);
        }
        /// <summary>
        /// Distance between (x,y) and (0, 0)
        /// </summary>
        public double DOO()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public int? LocationRAD()
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            if (x < 0 && y > 0)
            {
                return 2;
            }
            if (x < 0 && y < 0)
            {
                return 3;
            }
            if (x > 0 && y < 0)
            {
                return 4;
            }

            return null;
        }
        
    }
}

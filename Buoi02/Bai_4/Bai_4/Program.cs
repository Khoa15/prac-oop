using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DSNV ds = new DSNV();
            //ds.Nhap(5);
            ds.NhapXML("DSNV.xml");
            ds.Xuat();

            //ds.GhiXML("DSNV.xml");

            Console.ReadLine();
        }
    }
}

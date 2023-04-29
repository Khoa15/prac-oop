using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DSGV ds = new DSGV();
            ds.ReadXML("DSGV.xml");
            ds.Xuat();
            Console.ReadLine();
        }
    }
}

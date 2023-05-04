using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class So
    {
        int x;
        int ngay;
        int thang;
        int nam;

        public int X { get => x; set => x = value; }
        public int Ngay { get => ngay; set => ngay = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }

        public So() { }
        public int Nhap()
        {
            x = int.Parse(Console.ReadLine());
            return x;
        }
        public void NhapNgayThangNam()
        {
            ngay = int.Parse(Console.ReadLine());
            thang = int.Parse(Console.ReadLine());
            nam = int.Parse(Console.ReadLine());
        }
        public void XuatNamNgayNam()
        {
            int tmp_ngay, tmp_thang, tmp_nam;
            tmp_ngay = ngay - 1;
            if(tmp_ngay == 0)
            {
                tmp_thang = thang - 1;
                tmp_ngay = 30;
            }
            if(tmp_thang == 0)
            {
                tmp_nam = nam - 1;
                tmp_thang = 12;
            }
            if(tmp_thang % 2 == 1 || tmp_thang == 10 || tmp_thang == 11 || tmp_thang == 12)
            {
                tmp_ngay = 31;
            }
            Console.WriteLine("Ngay hom qua: {0}/{0}/{0}", tmp_ngay, tmp_thang, tmp_nam);
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

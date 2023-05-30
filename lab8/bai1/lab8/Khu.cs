using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public abstract class Khu
    {
        int loai;//{1: NhaO, 2: DatTrong, 3: BietThu, 4: KhachSan}
        string maSo;
        double chieuDai;
        double chieuRong;
        public Khu()
        {
            chieuDai = 0;
            chieuRong = 0;
        }
        public Khu(string maSo, double chieuDai, double chieuRong, int loai)
        {
            this.maSo = maSo;
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.loai = loai;
        }

        public string MaSo { get => maSo; set => maSo = value; }
        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public int Loai { get => loai; set => loai = value; }

        public abstract double GiaTri();
        public double DienTich()
        {
            return chieuRong * chieuDai;
        }
        public void Nhap()
        {
            Console.WriteLine("Loai: ");
            loai = int.Parse(Console.ReadLine());
            Console.WriteLine("Ma so: ");
            maSo = Console.ReadLine();
            Console.WriteLine("Chieu dai: ");
            chieuDai = double.Parse(Console.ReadLine());
            Console.WriteLine("Chieu rong: ");
            chieuRong = Convert.ToDouble(Console.ReadLine());
        }
    }
}

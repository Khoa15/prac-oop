using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class NhaO: Khu
    {
        int soLau;

        public NhaO() { }
        public NhaO(int soLau)
        {
            this.soLau = soLau;
        }

        public NhaO(int soLau, string maSo, double chieuDai, double chieuRong, int loai):base(maSo, chieuDai, chieuRong, loai)
        {
            this.soLau=soLau;
        }

        public int SoLau { get => soLau; set => soLau = value; }

        public override double GiaTri()
        {
            return DienTich() * 10000 + soLau;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So lau: ");
            soLau = Convert.ToInt32(Console.ReadLine());
        }
    }
}

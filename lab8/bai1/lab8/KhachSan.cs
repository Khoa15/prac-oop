using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class KhachSan: Khu, IPhi
    {
        int soSao;

        public KhachSan() { }
        public KhachSan(int soSao)
        {
            this.soSao = soSao;
        }

        public KhachSan(string maSo, double chieuDai, double chieuRong, int loai) : base(maSo, chieuDai, chieuRong, loai)
        {

        }

        public int SoSao { get => soSao; set => soSao = value; }
        public double PhiKinhDoanh()
        {
            return ChieuRong * 5000;
        }
        public override double GiaTri()
        {
            return 1000000 + soSao * 50000;
        }
        public new void Nhap()
        {
            base.Nhap();
            soSao = Convert.ToInt32(Console.ReadLine());
        }
    }
}

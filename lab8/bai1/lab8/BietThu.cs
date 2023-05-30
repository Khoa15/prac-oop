using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class BietThu: Khu, IPhi
    {
        public BietThu() { }
        public BietThu(string maSo, double chieuDai, double chieuRong, int loai): base(maSo, chieuDai, chieuRong, loai)
        {

        }
        public double PhiKinhDoanh()
        {
            return DienTich() * 1000;
        }
        public override double GiaTri()
        {
            return DienTich() * 400000;
        }
    }
}

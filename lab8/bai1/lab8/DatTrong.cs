using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class DatTrong: Khu
    {
        public DatTrong() { }
        public DatTrong(string maSo, double chieuDai, double chieuRong, int loai) : base(maSo, chieuDai, chieuRong, loai)
        {

        }
        public override double GiaTri()
        {
            return DienTich() * 10000;
        }

    }
}

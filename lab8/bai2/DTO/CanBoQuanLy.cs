using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CanBoQuanLy: NhanVien
    {
        double heSoChucVu;
        public CanBoQuanLy()
        {

        }
        public override int XepLoai()
        {
            return 1;
        }
        public double PhuCapChucVu()
        {
            return heSoChucVu * 1100;
        }
        public override double Luong()
        {
            return HeSoThuNhap()*( HeSoLuong * NhanVien.LuongCoBan + PhuCapChucVu());
        }

    }
}

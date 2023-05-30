using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NVSanXuat: NhanVien
    {
        static double phuCapNangNhoc = 0.1;
        public NVSanXuat()
        {

        }
        public override int XepLoai()
        {
            if (SoNgayNghi <= 1)
            {
                return 1;
            }
            if (SoNgayNghi <= 3)
            {
                return 2;
            }
            if (SoNgayNghi <= 5)
            {
                return 3;
            }
            return 4;
        }
        public double PhuCapThamNien()
        {
            if (SoNamLam() < 5) return 0;
            return SoNamLam() * LuongCoBan / 100;
        }
        public override double Luong()
        {
            return HeSoThuNhap() *( HeSoLuong * NhanVien.LuongCoBan * (1 + phuCapNangNhoc));
        }
    }
}

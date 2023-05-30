using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NVKinhDoanh: NhanVien
    {
        int doanhSoToiThieu;
        int doanhSoBanHang;
        public NVKinhDoanh()
        {
        }
        public override int XepLoai()
        {
            if(doanhSoBanHang > doanhSoToiThieu * 2)
            {
                return 1;
            }else if(doanhSoBanHang > doanhSoToiThieu)
            {
                return 2;
            }else if(doanhSoBanHang < doanhSoToiThieu / 2)
            {
                return 4;
            }
            return 3;
        }
        public double DoanhThu()
        {
            int vuotMuc = doanhSoBanHang - doanhSoToiThieu;
            if (vuotMuc < 0)
            {
                return 0;
            }
            return (doanhSoBanHang - doanhSoBanHang) * 500;
        }
        public double HoaHong()
        {
            return 0.15 * DoanhThu();
        }
        public override double Luong()
        {
            return HeSoThuNhap() *(HeSoLuong * NhanVien.LuongCoBan + HoaHong());
        }
    }
}

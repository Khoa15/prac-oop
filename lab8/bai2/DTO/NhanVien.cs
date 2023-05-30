using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class NhanVien: Nguoi
    {
        int namSinh;
        bool gioiTinh;//{0: Nam, 1: Nu}
        double heSoLuong;
        int namVaoLam;
        static int luongCoBan = 1210;
        int soNgayNghi;
        public NhanVien()
        {
            gioiTinh = false;
        }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int NamVaoLam { get => namVaoLam; set => namVaoLam = value; }
        public static int LuongCoBan { get => luongCoBan; set => luongCoBan = value; s
        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }

        public abstract int XepLoai();
        public abstract double Luong();
        public int SoNamLam()
        {
            return DateTime.Now.Year - namVaoLam;
        }
        public double HeSoThuNhap()
        {
            if(XepLoai() == 1)
            {
                return 1;
            }else if(XepLoai()== 2)
            {
                return 0.75;
            }else if(XepLoai()== 3)
            {
                return 0.5;
            }
            return 0;
        }
    }
}

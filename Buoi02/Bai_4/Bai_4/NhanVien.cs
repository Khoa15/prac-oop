using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    public class NhanVien
    {
        /// <summary>
        /// ChucVu: "Lanh Dao", "Nhan Vien"
        /// </summary>
        string sMa;
        string sTen;
        string sPhongBan;
        double dHeSoLuong;
        int iThamNienCongTac;
        int iSoNgayLamViec;
        string sChucVu;

        public string Ten
        {
            get { return sTen; }
            set { sTen = value; }
        }
        public string PhongBan
        {
            get { return sPhongBan; }
            set { sPhongBan = value; }
        }
        public double HeSoLuong
        {
            get { return dHeSoLuong; }
            set { dHeSoLuong = value; }
        }
        public int ThamNienCongTac
        {
            get { return iThamNienCongTac; }
            set { iThamNienCongTac = value; }
        }
        public int SoNgayLamViec
        {
            get { return iSoNgayLamViec; }
            set { iSoNgayLamViec = value; }
        }
        public string Ma
        {
            get { return sMa; }
            set { sMa = value; }
        }
        public string ChucVu
        {
          get { return sChucVu; }
          set { sChucVu = value; }
        }

        public NhanVien()
        {

        }
        public NhanVien(string Ma, string Ten, string PhongBan, double HeSoLuong, int ThamNienCongTac, int SoNgayLamViec, string ChucVu)
        {
            sMa = Ma;
            sTen = Ten;
            sPhongBan = PhongBan;
            dHeSoLuong = HeSoLuong;
            iThamNienCongTac = ThamNienCongTac;
            iSoNgayLamViec = SoNgayLamViec;
            sChucVu = ChucVu;
        }
        public double? HSThiDua()
        {
            if (ChucVu == "Lanh Dao")
            {
                return 1;
            }
            else if (ChucVu == "Nhan Vien")
            {
                if (SoNgayLamViec > 22) return 1;
                if (SoNgayLamViec > 20) return 0.8;
                return 0.6;
            }
            return null;
        }
        public double PhuCap()
        {
            if (ChucVu == "Lanh Dao")
            {
                return 2000;
            }
            return 0;
        }
        public double? Luong(double LuongCoBan = 1210)
        {
            if (this.HSThiDua() == null) return null;
            return HeSoLuong * LuongCoBan * this.HSThiDua() + 1100 + this.PhuCap();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma: {0}", sMa);
            Console.WriteLine("Ten: {0}", sTen);
            Console.WriteLine("Phong ban: {0}", sPhongBan);
            Console.WriteLine("He so luong: {0}", dHeSoLuong);
            Console.WriteLine("Tham nien cong tac: {0}", iThamNienCongTac);
            Console.WriteLine("Chuc vu: {0}", sChucVu);
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Ma:");
            sMa = Console.ReadLine();
            Console.WriteLine("Nhap Ten:");
            sTen = Console.ReadLine();
            Console.WriteLine("Nhap Phong ban:");
            sPhongBan = Console.ReadLine();
            Console.WriteLine("Nhap He so luong:");
            dHeSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Tham nien cong tac:");
            iThamNienCongTac = int.Parse(Console.ReadLine());
            Console.WriteLine("Chuc vu:");
            sChucVu = Console.ReadLine();
        }
        //public void NhapRandom(Random rand)
        //{
        //    List<string> fullNames = new List<string> {
        //        "Nguyen Van Minh",
        //        "Tran Thi Thu Ha",
        //        "Le Van Quang",
        //        "Pham Thi Hong Nhung",
        //        "Hoang Van Tuan",
        //        "Bui Thi Thanh Huyen",
        //        "Do Van Trung",
        //        "Ly Thi Thu Trang",
        //        "Duong Van Anh",
        //        "Vu Thi Ngoc Anh"
        //    };
        //    List<string> departments = new List<string> {
        //        "Nhan su",
        //        "Ke toan",
        //        "Kinh doanh",
        //        "Marketing",
        //        "San xuat",
        //        "Ky thuat",
        //        "Hanh chinh",
        //        "Tai vu"
        //    };
        //    sMa = (rand.Next(111, 9999)).ToString();
        //    sTen = fullNames.ElementAt(rand.Next(0, fullNames.Count - 1));
        //    sPhongBan = departments.ElementAt(rand.Next(0, departments.Count - 1));
        //    dHeSoLuong = rand.NextDouble()*5;
        //    iThamNienCongTac = rand.Next();
        //    sChucVu = rand.Next(0, 9999) == 0 ? "Lanh Dao" : "Nhan Vien";
        //}
    }
}

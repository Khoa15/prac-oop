using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhDien
{
    public class ThiSinh
    {
        string sSBD;
        string sTen;
        int sNamSinh;
        double dDToan;
        double dDVan;
        double dDNgoaiNgu;
        double dTongDiem;
        string sKetQua;
        public string SBD
        {
            get { return sSBD; }
            set { sSBD = value; }
        }
        public string Ten
        {
            get { return sTen; }
            set { sTen = value; }
        }
        public int NamSinh
        {
            get { return sNamSinh; }
            set { sNamSinh = value; }
        }
        public double DToan
        {
            get { return dDToan; }
            set { dDToan = value; }
        }
        public double DVan
        {
            get { return dDVan; }
            set { dDVan = value; }
        }
        public double DNgoaiNgu
        {
            get { return dDNgoaiNgu; }
            set { dDNgoaiNgu = value; }
        }

        public double TongDiem
        {
            get { return dTongDiem; }
            set { dTongDiem = value; }
        }

        public string KetQua
        {
            get { return sKetQua; }
            set { sKetQua = value; }
        }
        public ThiSinh()
        {

        }
        public ThiSinh(string SBD, string Ten, int NamSinh, double DToan, double DVan, double DNgoaiNgu)
        {
            sSBD = SBD;
            sTen = Ten;
            sNamSinh = NamSinh;
            dDToan = DToan;
            dDVan = DVan;
            dDNgoaiNgu = DNgoaiNgu;
            dTongDiem = (DToan + DVan + DNgoaiNgu * 2) / 4;
            if (dTongDiem > 25)
            {
                sKetQua = "Dau";
            }
            else
            {
                sKetQua = "Rot";
            }
        }

        public ThiSinh(ThiSinh ts)
        {
            sSBD = ts.sSBD;
            sTen = ts.sTen;
            sNamSinh = ts.sNamSinh;
            dDToan = ts.dDToan;
            dDVan = ts.dDVan;
            dDNgoaiNgu = ts.dDNgoaiNgu;
            dTongDiem = ts.dTongDiem;
            sKetQua = ts.sKetQua;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so bao danh");
            sSBD = Console.ReadLine();
            Console.WriteLine("Nhap ten");
            sTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh");
            sNamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem toan");
            dDToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem van");
            dDVan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ngoai ngu");
            dDNgoaiNgu = double.Parse(Console.ReadLine());

            dTongDiem = (dDToan + dDVan + dDNgoaiNgu * 2) / 4;
            if (dTongDiem > 25)
            {
                sKetQua = "Dau";
            }
            else
            {
                sKetQua = "Rot";
            }
        }

        public void Xuat()
        {
            Console.WriteLine("So bao danh: {0}", sSBD);
            Console.WriteLine("Ten: {0}", sTen);
            Console.WriteLine("Nam sinh: {0}", sNamSinh);
            Console.WriteLine("Diem toan: {0}", dDToan);
            Console.WriteLine("Diem van: {0}", dDVan);
            Console.WriteLine("Diem ngoai ngu: {0}", dDNgoaiNgu);
            Console.WriteLine("Tong diem: {0}", dTongDiem);
            Console.WriteLine("Ket qua: {0}", sKetQua);
        }
    }
}

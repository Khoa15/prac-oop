using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GiaoVien
    {
        string Ten;
        int SoNHD;

        public string TenGV
        {
            get
            {
                return this.Ten;
            }
            set
            {
                this.Ten = value;
            }
        }
        public int SoNhomHD
        {
            get
            {
                return this.SoNHD;
            }
            set
            {
                this.SoNHD = value;
            }
        }
        public GiaoVien() { }
        public GiaoVien(string tenGV, int soNHD)
        {
            this.Ten = tenGV;
            this.SoNHD = soNHD;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten giao vien ei:");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap so nhom huong dan ei:");
            SoNHD = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ten GV: {0}", Ten);
            Console.WriteLine("So NHD: {0}", SoNHD);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bai_4
{
    public class DSNV
    {
        List<NhanVien> _DS = new List<NhanVien>();

        public DSNV()
        {

        }
        public DSNV(List<NhanVien> ds)
        {
            _DS = ds;
        }
        public void NhapXML(string filename)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(List<NhanVien>), new XmlRootAttribute("DSNV"));
            using(var reader = new StreamReader(filename))
            {
                _DS = (List<NhanVien>)serialize.Deserialize(reader);
            }
        }
        public void GhiXML(string filename)
        {
            var serialize = new XmlSerializer(typeof(List<NhanVien>), new XmlRootAttribute("DSNV"));
            
            using(var stream = new StreamWriter("DSNV.xml"))
            {
                serialize.Serialize(stream, _DS);
            }
        }
        public void Nhap(int n)
        {
            //Random rand = new Random();
            for(;n > 0; n--)
            {
                NhanVien nv = new NhanVien();
                nv.Nhap();
                _DS.Add(nv);
            }
        }
        public void Xuat()//b
        {
            _DS.ForEach(ds => ds.Xuat());
        }
        public void XuatTheoHSTD()//c
        {
            _DS.OrderBy(t => t.HSThiDua()).ToList().ForEach(t => t.Xuat());
        }
        public double? TongLuong()
        {
            return _DS.Sum(nv => nv.Luong());
        }
        public int LoaiNhanVien()
        {
            return _DS.RemoveAll(nv => nv.SoNgayLamViec < 10);
        }
        public List<NhanVien> LayDSNVPhongBan(string phongban)
        {
            return _DS.Where(nv => nv.PhongBan == phongban).ToList();
        }
        public List<NhanVien> LayDSNV(string chucvu)
        {
            return _DS.Where(nv => nv.ChucVu == chucvu).ToList();
        }
        public List<NhanVien> LayDSNV(int songaylamviec = 22)
        {
            return LayDSNV("Nhan Vien").Where(nv => nv.SoNgayLamViec > songaylamviec).ToList();
        }
        public List<NhanVien> LayDSNV(double hsluong = 4.34)
        {
            return LayDSNVPhongBan("Tai vu").Where(nv => nv.HeSoLuong >= hsluong).ToList();
        }
    }
}

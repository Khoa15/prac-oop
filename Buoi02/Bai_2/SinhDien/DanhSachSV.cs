using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SinhDien
{
    public class DanhSachSV
    {
        List<ThiSinh> _DS = new List<ThiSinh>();

        public DanhSachSV()
        {

        }
        public DanhSachSV(List<ThiSinh> list)
        {
            _DS = list;
        }
        public void Nhap(int n)
        {
            for (; n > 0; n--)
            {
                ThiSinh ts = new ThiSinh();
                ts.Nhap();
                _DS.Add(ts);
            }
        }

        public void NhapXML(string filename)
        {
            XmlDocument fileXML = new XmlDocument();
            fileXML.Load(filename);
            XmlNodeList nodeList = fileXML.SelectNodes("/DanhSach/ThiSinh");
            foreach (XmlNode node in nodeList)
            {
                ThiSinh ts = new ThiSinh();
                ts.SBD          = node["SBD"].InnerText;   
                ts.Ten          = node["Ten"].InnerText;
                ts.NamSinh      = int.Parse(node["NamSinh"].InnerText);
                ts.DToan        = double.Parse(node["DToan"].InnerText);
                ts.DVan         = double.Parse(node["DVan"].InnerText);
                ts.DNgoaiNgu    = double.Parse(node["DNgoaiNgu"].InnerText);
                ts.TongDiem     = double.Parse(node["TongDiem"].InnerText);
                ts.KetQua       = node["KetQua"].InnerText;
                _DS.Add(ts);
            }
        }
        public void Xuat()
        {
            _DS.ForEach(t => t.Xuat());
        }
        public DanhSachSV SapXepGiamTongDiem()
        {
            return new DanhSachSV(_DS.OrderBy(t => t.TongDiem).Reverse().ToList());
        }
        public DanhSachSV SapXepTangHoTen()
        {
            return new DanhSachSV(_DS.OrderBy(t => t.Ten).ThenBy(t => t.DToan).ToList());
        }
        public DanhSachSV ThiSinhDau()
        {
            return new DanhSachSV(_DS.Where(t => (t.KetQua == "Dau")).ToList());
        }
        public DanhSachSV ThiSinhNamSinhDToan()
        {
            return new DanhSachSV(_DS.Where(t => (t.DToan >= 9 && t.NamSinh > 1995)).ToList());
        }
    }
}

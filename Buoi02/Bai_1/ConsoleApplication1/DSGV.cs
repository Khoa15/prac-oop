using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication1
{
    public class DSGV
    {
        List<GiaoVien> _ds = new List<GiaoVien>();

        public DSGV()
        {
        
        }
        public DSGV(List<GiaoVien> ds)
        {
            _ds = ds._ds;
        }
        public void NhapDS(int n){
            for(;n > 0; n--){
                GiaoVien gv = new GiaoVien();
                gv.Nhap();
                _ds.Add(gv);
            }
        }
        public int TongNhom(){
            return _ds.Sum(t=> t.SoNhomHD);
        }

        public DSGV SapXepTangHoTen(){
            return new DSGV(_ds.OrderBy(t => t.TenGV).ToList<GiaoVien>());
        }

        public DSGV SapXepGiamSoNhom(){
            return new DSGV(_ds.OrderBy(t => t.SoNhomHD).Reverse().ToList<GiaoVien>());
        }

        public void DSNhomHD(){
            _ds.Where(t => (t.SoNhomHD > 1)).ToList().ForEach(t => t.Xuat());
        }

        public void ReadXML(string filename){
            XmlDocument fileXML = new XmlDocument();
            fileXML.Load(filename);
            XmlNodeList nodeList = fileXML.SelectNodes("/DanhSach/GV");
            foreach(XmlNode node in nodeList){
                GiaoVien gv = new GiaoVien();
                gv.TenGV = node["HoTen"].InnerText;
                gv.SoNhomHD = int.Parse(node["SoNhom"].InnerText);
                _ds.Add(gv);
            }
        }

        //public void SaveXML(){
        //    TextWriter text = new StreamWriter("DSGV.xml");
        //    _ds.ForEach(t => {
        //        var bla = new XmlSerializer(typeof(GiaoVien));
        //        GiaoVien gv = new GiaoVien(t);
        //    });
        //}

        public new void Xuat(){
            _ds.ForEach(t => t.Xuat());
        }
    }
}

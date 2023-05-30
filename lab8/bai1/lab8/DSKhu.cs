using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab8
{
    public class DSKhu
    {
        List<Khu> khuList;
        public DSKhu()
        {

        }
        public void Nhap(string file)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(DSKhu));
            using (var reader = new StreamReader(file))
            {
                khuList = (List<Khu>)serialize.Deserialize(reader);
            }
        }
        public void Nhap(int n)
        {
            int loai;
            for(;n > 0; n--)
            {
                Khu k;
                Console.WriteLine("Nhap loai: ");
                loai = Convert.ToInt32(Console.ReadLine());
                if(loai == 1)
                {
                    k = new NhaO();
                    k.Nhap();
                }else if(loai == 2)
                {
                    k = new DatTrong();
                    k.Nhap();
                }else if(loai == 3)
                {
                    k = new BietThu();
                    k.Nhap();
                }else
                {
                    k = new KhachSan();
                    k.Nhap();
                }
                k.Loai = loai;
                khuList.Add(k);
            }
        }
        public void Xuat(string file)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(DSKhu));
            using(var writer = new StreamWriter(file))
            {
                serialize.Serialize(writer, khuList);
            }
        }
        public double TongGiaTri()
        {
            return khuList.Sum(k => k.GiaTri());
        }
        public double TongPhi()
        {
            return khuList.Sum(k => ((k is IPhi) ? ((IPhi)k).PhiKinhDoanh() : 0));
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BCD_BLL
    {
        BCD NhanVien_BCD = new BCD();
        ABC NhanVien_ABC = new ABC();
        public BCD_BLL() { }
        public int TongNVNangLucTot_ABC()
        {

            int result = 0;
            NhanVien_ABC.Load().ForEach(nv =>
            {
                if (nv is NVSanXuat)
                {
                    NVSanXuat sx = (NVSanXuat)nv;
                    if (sx.XepLoai() == 1)
                    {
                        result++;
                    }
                }
                else if (nv is NVKinhDoanh)
                {
                    NVKinhDoanh kd = (NVKinhDoanh)nv;
                    if (kd.XepLoai() == 1)
                    {
                        result++;
                    }
                }
                else if (nv is CanBoQuanLy)
                {
                    result += 1;
                }
            });
            return result;
        }
        public int TongNVNangLucTot_BCD()
        {
            return NhanVien_BCD.Load().Count(nv => nv.Luong() > 20000);
        }
        public int TongNVNangLucTot()
        {
            return TongNVNangLucTot_ABC() + TongNVNangLucTot_BCD();
        }
    }
}

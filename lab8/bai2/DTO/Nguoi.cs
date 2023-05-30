using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nguoi
    {
        string maNV;
        string tenNV;
        public Nguoi()
        {

        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public double Luong()
        {
            return 0.15;
        }
    }
}

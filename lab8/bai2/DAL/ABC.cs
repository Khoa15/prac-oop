using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ABC
    {
        List<NhanVien> dsNhanVien = new List<NhanVien>();
        public ABC() { }
        public List<NhanVien> Load()
        {
            return dsNhanVien;
        }
    }
}

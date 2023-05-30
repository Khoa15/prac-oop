using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BCD
    {
        List<Nguoi> dsNhanVien = new List<Nguoi>();
        public BCD() { }
        public List<Nguoi> Load()
        {
            return dsNhanVien;
        }
    }
}

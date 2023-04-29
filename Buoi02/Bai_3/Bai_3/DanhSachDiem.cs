using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class DanhSachDiem
    {
        List<Diem> _DS = new List<Diem>();

        public DanhSachDiem()
        {

        }
        public DanhSachDiem(List<Diem> ds)
        {
            _DS = ds;
        }
        public void Nhap(int n)
        {
            for (; n > 0; n--)
            {
                Diem d = new Diem();
                d.Nhap();
                _DS.Add(d);
            }
        }
        public void Xuat()
        {
            _DS.ForEach(t =>
            {
                t.Xuat();
            });
        }
        public DanhSachDiem SapXep()
        {
            return new DanhSachDiem(_DS.OrderBy(t => t.DOO()).ThenBy(t => t.X).Reverse().ToList());
        }
        public DanhSachDiem LayDiem()
        {
            return new DanhSachDiem(_DS.Where(t => t.DOO() <= 1).ToList());
        }
        public DanhSachDiem LayDiemGocThuNhat()
        {
            return new DanhSachDiem(_DS.Where(t => t.LocationRAD() == 1).ToList());
        }
        public DanhSachDiem XoaDiem()
        {
            return new DanhSachDiem(_DS.Where(t => t.X > 5 && t.Y < 8).ToList());
        }
        public int DemHoanhDoDuong()
        {
            return _DS.Count(t => t.X > 0);
        }
    }
}

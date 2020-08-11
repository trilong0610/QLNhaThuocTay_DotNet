using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{

    public class NhanVien : Context
    {
        public List<NHANVIEN> LoadNV()
        {
            return ql.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }

        public virtual object MaNV
        {
            get;
            set;
        }
        public virtual object HoTenNV
        {
            get;
            set;
        }
        public virtual DateTime NgaySinh
        {
            get;
            set;
        }
        public virtual object GioiTinh
        {
            get;
            set;
        }
        public virtual int Tuoi
        {
            get;
            set;
        }
        public virtual object DiaChi
        {
            get;
            set;
        }
        public virtual object SDT
        {
            get;
            set;
        }
        public virtual object ChucVu
        {
            get;
            set;
        }
        public virtual Double Luong
        {
            get;
            set;
        }
        public virtual IEnumerable<HoaDonNhap> HoaDonNhap
        {
            get;
            set;
        }
        public virtual IEnumerable<HoaDonBan> HoaDonBan
        {
            get;
            set;
        }
    }
}

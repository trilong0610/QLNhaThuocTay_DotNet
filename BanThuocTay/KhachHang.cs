using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq.Mapping;
using System.Data;
namespace BanThuocTay
{
    public class KhachHang : Context
    {
        //QuanLiDataContext ql = new QuanLiDataContext();
        public List<KHACHHANG> LoadKH()
        {
            return ql.KHACHHANGs.Select(t => t).ToList<KHACHHANG>();
        }

        public virtual object MaKH
        {
            get;
            set;
        }
        public virtual object HoTenKH
        {
            get;
            set;
        }
        public virtual int Tuoi
        {
            get;
            set;
        }
        public virtual object SDT
        {
            get;
            set;
        }
        public virtual object DiaChi
        {
            get;
            set;
        }
        public virtual object TenBenh
        {
            get;
            set;
        }
        public virtual object TienSuBenh
        {
            get;
            set;
        }
        public virtual LoaiBenh LoaiBenh
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

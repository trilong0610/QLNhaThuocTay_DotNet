using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class Thuoc : Context
    {
        public List<THUOC> LoadThuoc()
        {
            return ql.THUOCs.Select(t => t).ToList<THUOC>();
        }
        public virtual object MaThuoc
        {
            get;
            set;
        }
        public virtual object TenThuoc
        {
            get;
            set;
        }
        public virtual object XuatXu
        {
            get;
            set;
        }
        public virtual object TacDung
        {
            get;
            set;
        }
        public virtual object CachDung
        {
            get;
            set;
        }
        public virtual object ThanTrong
        {
            get;
            set;
        }
        public virtual object TacDungPhu
        {
            get;
            set;
        }
        public virtual DateTime NgaySX
        {
            get;
            set;
        }
        public virtual DateTime HSD
        {
            get;
            set;
        }
        public virtual object DonViTinh
        {
            get;
            set;
        }
        public virtual Double Gia
        {
            get;
            set;
        }
        public virtual int SoLuong
        {
            get;
            set;
        }
        public virtual LoaiThuoc LoaiThuoc
        {
            get;
            set;
        }
        public virtual NhaSanXuat NhaSanXuat
        {   
            get;
            set;
        }
        public virtual IEnumerable<CTHoaDonNhap> CTHoaDonNhap
        {
            get;
            set;
        }
        public virtual IEnumerable<CTHoaDonBan> CTHoaDonBan
        {
            get;
            set;
        }
    }
}

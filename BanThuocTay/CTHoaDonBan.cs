using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class CTHoaDonBan : Context
    {
        public List<CHITIETHOADON_BAN> LoadCTHDB()
        {
            return ql.CHITIETHOADON_BANs.Select(t => t).ToList<CHITIETHOADON_BAN>();
        }

        public virtual HoaDonBan HoaDonBan
        {
            get;
            set;
        }
        public virtual Thuoc Thuoc
        {
            get;
            set;
        }
        public virtual object DonViTinh
        {
            get;
            set;
        }
        public virtual int SoLuong
        {
            get;
            set;
        }
        public virtual Double TongTien
        {
            get;
            set;
        }
    }
}

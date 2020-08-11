using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class LoaiBenh : Context
    {
        public List<LOAIBENH> LoadLB()
        {
            return ql.LOAIBENHs.Select(t => t).ToList<LOAIBENH>();
        }

        public virtual object MaLoaiBenh
        {
            get;
            set;
        }
        public virtual object TenLoaiBenh
        {
            get;
            set;
        }
        public virtual IEnumerable<KhachHang> KhachHang
        {
            get;
            set;
        }
    }
}

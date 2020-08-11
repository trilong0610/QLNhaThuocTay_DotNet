using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class LoaiThuoc : Context
    {
        public List<LOAITHUOC> LoadLT()
        {
            return ql.LOAITHUOCs.Select(t => t).ToList<LOAITHUOC>();
        }

        public virtual object MaLoaiThuoc
        {
            get;
            set;
        }
        public virtual object TenLoaiThuoc
        {
            get;
            set;
        }
        public virtual IEnumerable<Thuoc> Thuoc
        {
            get;
            set;
        }
        public virtual IEnumerable<NhaCungCap> NhaCungCap
        {
            get;
            set;
        }
    }
}

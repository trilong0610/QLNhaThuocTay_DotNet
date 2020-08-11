using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class NhaSanXuat
    {
        public virtual object MaNSX
        {
            get;
            set;
        }
        public virtual object TenNSX
        {
            get;
            set;
        }
        public virtual IEnumerable<Thuoc> Thuoc
        {
            get;
            set;
        }
    }
}

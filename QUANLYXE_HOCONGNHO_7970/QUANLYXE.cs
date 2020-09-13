using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYXE_HOCONGNHO_7970
{
    class QUANLYXE
    {
        Dictionary<String, XE> danhSachXe;
        public QUANLYXE()
        {
            danhSachXe = new Dictionary<string, XE>();
        }

        public void Them(XE xe)
        {
            danhSachXe.Add(xe.BienSo,xe);
        }

        public XE Tim(String bienSo)
        {
            if (this.danhSachXe.ContainsKey(bienSo))
                return this.danhSachXe[bienSo];
            else return null;
        }

        public void Xoa(string bienSo)
        {
            this.danhSachXe.Remove(bienSo);
        }

        public void Xuat()
        {
            foreach (XE x in danhSachXe.Values)
                x.Xuat();
        }
    }
}

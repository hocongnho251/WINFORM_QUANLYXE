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

        public XE Tim(string bienSo)
        {
            if (this.danhSachXe.ContainsKey(bienSo))
                return this.danhSachXe[bienSo];
            else return null;
        }

        public bool Xoa(string bienSo)
        {
            if (this.danhSachXe.ContainsKey(bienSo))
            {
                this.danhSachXe.Remove(bienSo);
                return true;
            }
            return false;
        }

        public void Xuat()
        {
            foreach (XE x in danhSachXe.Values)
                x.Xuat();
        }
    }
}

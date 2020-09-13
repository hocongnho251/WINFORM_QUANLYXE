using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYXE_HOCONGNHO_7970
{
    class XEDULICH : XE
    {
        private int soChoNgoi;

        public XEDULICH() : base() { }

        public XEDULICH(String tenXe, String bienSo, int trongTai, int tieuChuanBang, DateTime ngayDangKiem, int soChoNgoi) 
            : base(tenXe,bienSo, trongTai,tieuChuanBang,ngayDangKiem)
        {
            this.soChoNgoi = soChoNgoi;

        }

        public int SoChoNgoi
        {
            get { return soChoNgoi; }
            set { soChoNgoi = value; }
        }

        override public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số chỗ ngồi :");
            this.SoChoNgoi = Convert.ToInt32(Console.ReadLine());
        }

        override public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số chỗ ngồi là :" + this.SoChoNgoi);
        }

    }
}

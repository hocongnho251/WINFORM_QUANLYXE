using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYXE_HOCONGNHO_7970
{
    class XECHOHANG: XE
    {
        private double soTan;

        public XECHOHANG() : base() { }

        public XECHOHANG(String tenXe, String bienSo, int trongTai, int tieuChuanBang, DateTime ngayDangKiem, double soTan) 
            : base(tenXe,bienSo, trongTai,tieuChuanBang,ngayDangKiem)
        {
            this.soTan = soTan;

        }

        public double SoTan
        {
            get { return soTan; }
            set { soTan = value; }
        }

        override public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số tấn :");
            this.SoTan = Convert.ToDouble
                (Console.ReadLine());
        }

        override public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số tấn là :" + this.soTan);
        }
    }
}

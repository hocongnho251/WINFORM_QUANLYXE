using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYXE_HOCONGNHO_7970
{
     abstract public class XE
    {
        protected String bienSo, tenXe;
        protected int trongTai, tieuChuanBang;
        protected DateTime ngayDangKiem;

        public XE() { }

        public XE(String tenXe, String bienSo, int trongTai, int tieuChuanBang, DateTime ngayDangKiem)
        {
            this.tenXe = tenXe;
            this.bienSo = bienSo;
            this.trongTai = trongTai;
            this.tieuChuanBang = tieuChuanBang;
            this.ngayDangKiem = ngayDangKiem;
        }

        public String BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }

        public String TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }

        public int TrongTai
        {
            get { return trongTai; }
            set { trongTai = value; }
        }

        public int TieuChuanBang
        {
            get { return tieuChuanBang; }
            set { tieuChuanBang = value; }
        }

        public DateTime NgayDangKiem
        {
            get { return ngayDangKiem; }
            set { ngayDangKiem = value; }
        }

        virtual public void Nhap()
        {
            Console.WriteLine("Nhap vao ten xe");
            this.TenXe = Console.ReadLine();
            Console.WriteLine("Nhap vao bien so");
            this.BienSo = Console.ReadLine();
            Console.WriteLine("Nhap vao trong tai");
            this.TrongTai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao tieu chuan bang");
            this.TieuChuanBang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao ngay đang kiem");
            this.NgayDangKiem = DateTime.Parse(Console.ReadLine());
        }
        virtual public void Xuat()
        {
            Console.WriteLine("------------------------------------------ ");
            Console.WriteLine("Ten xe la: " + this.TenXe);
            Console.WriteLine("Bien so xe la: " + this.BienSo);
            Console.WriteLine("Trong tai la: " + this.TrongTai);
            Console.WriteLine("Tieu chuan bang la: " + this.TieuChuanBang);
            Console.WriteLine("Ngay đang kiem la: " + this.NgayDangKiem);
        }

    }

    
}

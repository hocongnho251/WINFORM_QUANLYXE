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
            Console.WriteLine("Nhập vào tên xe");
            this.TenXe = Console.ReadLine();
            Console.WriteLine("Nhập vào biển số");
            this.BienSo = Console.ReadLine();
            Console.WriteLine("Nhập vào trọng tải");
            this.TrongTai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tiêu chuẩn bằng");
            this.TieuChuanBang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào ngày đăng kiểm");
            this.NgayDangKiem = DateTime.Parse(Console.ReadLine());
        }
        virtual public void Xuat()
        {
            Console.WriteLine("Tên xe là: " + this.TenXe);
            Console.WriteLine("Biển số xe là: " + this.BienSo);
            Console.WriteLine("Trọng tải là: " + this.TrongTai);
            Console.WriteLine("Tiêu chuẩn băng là: " + this.TieuChuanBang);
            Console.WriteLine("Ngày đăng kiểm là: " + this.NgayDangKiem);

        }

    }

    
}

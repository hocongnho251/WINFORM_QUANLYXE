using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYXE_HOCONGNHO_7970
{
    class Program
    {
        static void Main(string[] args)
        {
            QUANLYXE quanLyXe = new QUANLYXE();
            char C;
            Console.Write("Nhap ky tu 'Y' de tiep tuc va nhan phim bat ky de thoat ");
            C = Char.Parse(Console.ReadLine());
            XE xe = null;
            while (C == 'Y' || C == 'y')
            {                Console.Write(" Nhap ky tu 'H' cho xe cho hang va 'D'cho xe du lich ");                char t;                t = Char.Parse(Console.ReadLine());
                if (t == 'H' || t == 'h')
                {
                    xe = new XECHOHANG();
                    xe.Nhap();
                }
                else if (t == 'D' || t == 'd')
                {
                    xe = new XEDULICH();
                    xe.Nhap();
                }
                quanLyXe.Them(xe);
                Console.Write("Nhap ky tu 'Y' de tiep tuc va nhan phim bat ky de thoat ");
                C = Char.Parse(Console.ReadLine());
                quanLyXe.Xuat();
            }

            Console.WriteLine("Nhap vao bien so xe can tim");
            string bsTim = Convert.ToString(Console.ReadLine());
            if (quanLyXe.Tim(bsTim) != null)
            {
               Console.WriteLine("Tim Thay Xe bien so: " + bsTim);
               quanLyXe.Tim(bsTim).Xuat();
            }
            else
            {
                Console.WriteLine("Khong tim thay xe: " + bsTim);
            }

            Console.WriteLine("Nhap vao  bien so xe can xoa");
            string bsXoa = Convert.ToString(Console.ReadLine());
            if (quanLyXe.Xoa(bsXoa) == true)
            {
                quanLyXe.Xoa(bsXoa);
                Console.WriteLine("Da xoa xe bien so: " + bsXoa);
                quanLyXe.Xuat();
            }
            else
            {
                Console.WriteLine("Khong co bien so xe: " + bsXoa);
            }
            Console.ReadLine();
        }
    }
}

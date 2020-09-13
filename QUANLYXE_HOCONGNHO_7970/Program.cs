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
            char t;
            Console.Write(" Nhap ky tu 'H' cho xe cho hang va 'D'cho xe du lich ");
            t = Char.Parse(Console.ReadLine());
            XE xe = null;
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
            quanLyXe.Nhap();
            quanLyXe.Them(xe);
            quanLyXe.Xuat();
            Console.ReadLine();
        }
    }
}

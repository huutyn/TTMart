using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public class ThucAnNhanh : SanPham
    {
        private double kluong;
        public double KLuong
        {
            get { return this.kluong; }
            set { this.kluong = value; }
        }

        public ThucAnNhanh ()
        {
            NSX = new DateTime();
            HSD = new DateTime();
        }
        public ThucAnNhanh (string tensp, string masp, double giatien, double soluong, string thongtin, string giamgia, string nsx, string hsd, double kluong)
        {
            NSX = new DateTime();
            HSD = new DateTime();
            this.Tensp    = tensp;
            this.Masp     = masp;
            this.Giatien  = giatien;
            this.Thongtin = thongtin;
            this.Giamgia  = giamgia;
            this.NSX      = DateTime.Parse(nsx);
            this.HSD      = DateTime.Parse(hsd);
            this.KLuong   = kluong;
            this.Soluong  = soluong;
        }
        public ThucAnNhanh (dynamic i)
        {
            this.Tensp = i.tensp;
            this.Masp = i.masp;
            this.Giatien = i.giatien;
            this.Thongtin = i.thongtin;
            this.Giamgia = i.giamgia;
            this.NSX = i.nsx;
            this.HSD = i.hsd;
            this.KLuong = i.kluong;
            this.Soluong = i.soluong;
        }

        public override void Nhap()
        {
            Console.Write("MA SAN PHAM : ");
            this.Masp = Console.ReadLine();
            Console.Write("TEN SAN PHAM : ");
            this.Tensp = Console.ReadLine();
            Console.Write("GIA TIEN : ");
            this.Giatien = Convert.ToDouble(Console.ReadLine());
            Console.Write("SO LUONG : ");
            this.Soluong = Convert.ToDouble(Console.ReadLine());
            Console.Write("THONG TIN SP : ");
            this.Thongtin = Console.ReadLine();
            Console.Write("GIAM GIA : ");
            this.Giamgia = Console.ReadLine();
            Console.Write("NSX : " + NSX);
            Console.Write("HSD : " + HSD);
            Console.Write("KHOI LUONG : ");
            this.KLuong = Convert.ToDouble(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine(this.Tensp + "\t\t   " + this.Soluong + "\t   " + this.Giatien);
        }
        public override void Thongtinsp()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t TEN SAN PHAM : " + this.Tensp);
            Console.ResetColor();
            Console.WriteLine("\t | MA SAN PHAM : " + this.Masp);
            Console.WriteLine("\t | SO LUONG    : " + this.Soluong);
            Console.WriteLine("\t | GIA TIEN    : " + this.Giatien);
            Console.WriteLine("\t | GIAM GIA    : " + this.Giamgia);
            Console.WriteLine("\t | THONG TIN   : " + this.Thongtin);
        }
    }
}

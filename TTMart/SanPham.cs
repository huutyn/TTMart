using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public abstract class SanPham
    {
        protected string masp;
        protected string tensp;
        protected string thongtin;
        protected double soluong;
        protected double giatien;
        protected string giamgia;     
        protected DateTime nsx;
        protected DateTime hsd;

        public string Masp
        {
            get { return this.masp; }
            set { this.masp = value; }
        }
        public string Tensp
        {
            get { return this.tensp; }
            set { this.tensp = value; }
        }
        public string Thongtin
        {
            get { return this.thongtin; }
            set { this.thongtin = value; }
        }
        public double Soluong
        {
            get { return this.soluong; }
            set { this.soluong = value; }
        }
        public double Giatien
        {
            get { return this.giatien; }
            set { this.giatien = value; }
        }
        public string Giamgia
        {
            get { return this.giamgia; }
            set { this.giamgia = value; }
        }
        public DateTime NSX
        {
            get { return this.nsx; }
            set { this.nsx = value; }
        }
        public DateTime HSD
        {
            get { return this.hsd; }
            set { this.hsd = value; }
        }
        public SanPham ()
        {

        }
        public SanPham (string tensp, string masp, double giatien, double soluong, string thongtin, string giamgia, string nsx, string hsd, string congty, double kluong)
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
            this.Soluong  = soluong;
        }

        public abstract void Nhap();

        public abstract void Xuat();

        public abstract void Thongtinsp();
    }
}

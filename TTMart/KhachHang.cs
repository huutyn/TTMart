using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public class KhachHang : NhanVien
    {
        private double diem;
        public double Diem
        {
            get { return this.diem; }
            set { this.diem = value; }
        }
        public KhachHang ()
        {

        }
        public KhachHang (string maso, double diem)
        {
            this.Maso = maso;
            this.Diem = diem;
        }
        public new void Nhap()
        {
            base.Nhap();
        }
        public new void Xuat()
        {
            Console.Write("\t| SO DIEN THOAI KHACH HANG : " + this.Maso);
            Console.WriteLine("; DIEM TICH LUY : " + this.diem);
        }
    }
}
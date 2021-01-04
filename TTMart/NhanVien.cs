using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public class NhanVien
    {
        private string hoten;
        private string maso;

        public string HoTen
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }
        public string Maso
        {
            get { return this.maso; }
            set { this.maso = value; }
        }

        public NhanVien ()
        {

        }
        public NhanVien (string hoten, string maso)
        {
            this.HoTen = hoten;
            this.Maso = maso;
        }

        public virtual void Nhap()
        {
            Console.Write("\t | Ma so : ");
            this.maso = Console.ReadLine();
            Console.Write("\t | Ho va ten : ");
            this.hoten = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("\t " + this.maso + " - " + this.hoten);
        }
    }
}

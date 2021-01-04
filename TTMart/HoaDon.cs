using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public class HoaDon
    {
        private DateTime time;
        private KhachHang kh;
        private NhanVien nv;
        private List<SanPham> sp;
        public double hd;

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public KhachHang KH
        {
            get { return this.kh; }
            set { this.kh = value; }
        }
        public NhanVien NV
        {
            get { return this.nv; }
            set { this.nv = value; }
        }
        public List<SanPham> SP
        {
            get { return this.sp; }
            set { this.sp = value; }
        }

        public HoaDon()
        {

        }

        public void Xuat()
        {
            Console.Clear();
            TTMART.XinChao();
            time = DateTime.Now;
            Console.WriteLine("\tTHOI GIAN : " + this.time);
            Console.WriteLine("\tNHAN VIEN - " + this.NV.HoTen);
            Console.WriteLine("\tKHACH HANG - " + this.KH.Maso);
            Console.WriteLine("\t" + "─────────────────────────────────────────────────────");
            Console.WriteLine("\t" + "STT   TEN SAN PHAM\t\t\t  SO LUONG    GIA TIEN (VND)\t ");
            Console.WriteLine("\t" + "─────────────────────────────────────────────────────");
            double S = 0;
            double sa = 0;
            this.hd = 0;
            for (int i = 0; i < this.SP.Count; i++)
            {
                S += this.SP[i].Giatien * this.SP[i].Soluong;
                if (this.SP[i].Giamgia.Contains("DS"))
                {
                    sa -= double.Parse(this.SP[i].Giamgia.Substring(2, (this.SP[i].Giamgia.Length - 2))) * this.SP[i].Soluong;
                }
                Console.Write("\t" + (i + 1) + "     ");
                this.SP[i].Xuat();
            }
            this.hd = S + sa;
            Console.WriteLine("\t" + "─────────────────────────────────────────────────────");
            Console.WriteLine("\tTONG TIEN: " + "\t\t\t\t\t   {0}", S);
            Console.WriteLine("\tGIAM GIA: " + "\t\t\t\t          {0}", sa);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tTHANH TIEN: " + "\t\t\t\t\t   {0}", this.hd);
            Console.ResetColor();
        }
    }
}

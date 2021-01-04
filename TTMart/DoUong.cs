using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public class DoUong : ThucAn
    {
        public DoUong ()
        {

        }
        public DoUong (string tensp, string masp, double giatien, double soluong, string thongtin, string giamgia, string nsx, string hsd, string thucan, double kluong)
        {
            NSX = new DateTime();
            HSD = new DateTime();
            this.Tensp    = tensp;
            this.Masp     = masp;
            this.Giatien  = giatien;
            this.Thongtin = thongtin;
            this.Giamgia  = giamgia;
            this.NSX = DateTime.Parse(nsx);
            this.HSD = DateTime.Parse(hsd);
            this.Thucan   = thucan;
            this.KLuong   = kluong;
            this.Soluong  = soluong;
        }
    }
}

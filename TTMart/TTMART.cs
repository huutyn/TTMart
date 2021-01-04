using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    public static class TTMART
    {
        public static List<SanPham> DSSanPham = new List<SanPham>();
        public static List<SanPham> DSGiamgia = new List<SanPham>();
        public static List<SanPham> DSHetHSD = new List<SanPham>();
        public static List<HoaDon> DSHoaDon = new List<HoaDon>();
        public static List<NhanVien> DSNhanVien = new List<NhanVien>();
        public static List<KhachHang> DSKhachHang = new List<KhachHang>();

        public static void Add()
        {
            #region SanPham
            DSSanPham.Add(new ThucAnNhanh("FF0001", "Sandwich ga xot cay", 27000, 5, "San pham su dung phi- le ma dui ga duoc tam uot gia vi cay", null, "23-12-2019", "26-12-2019", 250));
            DSSanPham.Add(new ThucAnNhanh("FF0002", "Banh su kem", 16000, 2, "Nhan banh duoc can bang ty le kem whipping va custard trung, nen co vi ngot, beo vua phai va vo cung thom ngon", null, "20-12-2019", "30-01-2019", 250));
            DSSanPham.Add(new ThucAnNhanh("FF0003", "Hu tieu thit", 35000, 3, "Nuoc sup duoc ham tu xuong heo, tom kho, cu cai, nen nuoc sup co vi ngot thanh nhe, them trung cut va thit heo xay tro nen vo cung thom ngon", null, "20-12-2019", "25-12-2019", 300));
            DSSanPham.Add(new ThucAnNhanh("FF0004", "Ga nuong muoi ot", 25000, 5, "Su dung phan thit ma dui ga, co do mem ngot, khong bi kho, them gia vi dam da, cay nhe cua ot, tao nen vi vo cung hap dan", null, "25-12-2019", "30-12-2019", 247));
            DSSanPham.Add(new ThucAnNhanh("FF0005", "Banh mi nhan socola", 18000, 5, "Banh mi mem thom sua, hoa quyen cung nhan socola deo mem", "HD3000", "24-12-2019", "27-12-2019", 100));

            DSSanPham.Add(new ThucAn("FD0001", "Keo cuon Play more", 12000, 50, "Vi chua chua ngot ngot deo deo dai dai voi thanh phan chua 20% la nuoc ep trai cay tuoi", null, "20-12-2019", "20-12-2020", "PlayMore", 21));
            DSSanPham.Add(new ThucAn("FD0002", "Banh quy kem Cream-O", 6100, 50, "Banh duoc lam tu nguyen lieu an toan, khong chua hoa chat doc hai, co nhieu huong vi de lua chon", null, "22-09-2019", "22-09-2020", "Jack&Jill", 54));
            DSSanPham.Add(new ThucAn("FD0003", "Banh Choco- Pie", 76100, 20, "Banh mang huong vi thom ngon, hap dan, phu lop socola ngot ngao ben ngoai den lop nhan marshmallow tan chay ben trong", null, "25-01-2019", "25-01-2020", "Orion", 660));
            DSSanPham.Add(new ThucAn("FD0004", "Ca ngu dau Ottogi", 52900, 10, "San xuat tu thanh phan nguyen lieu nhu ca ngu, dau dau nanh, hon hop gia vi, tao bien, nam, bap cai,… tao nen huong vi rieng biet va dat chat luong tot", null, "01-06-2018", "01-06-2022", "Ottogi", 150));
            DSSanPham.Add(new ThucAn("FD0005", "Snack Khoai Tay", 11000, 50, "Duoc che bien ty nhung lat khoai tay tuoi tu nhien tai nong trai, dam bao chat luong san pham, tao nen huong vi tuyet hao voi nhieu huong vi lua chon", null, "01-11-2019", "01-05-2020", "Orion", 48));

            DSSanPham.Add(new DoUong("DK0001", "Coca Cola    ", 8500, 50, "Nuoc giai khat co gas", null, "10-04-2019", "10-04-2020", "Coca Cola", 60));
            DSSanPham.Add(new DoUong("DK0002", "Fanta lon sleek", 8400, 50, "Nuoc giai khat huong trai cay", null, "30-12-2018", "30-12-2019", "Fanta", 330));
            DSSanPham.Add(new DoUong("DK0003", "Pepsi", 18400, 20, "Nuoc giai khat co gas", null, "01-12-2020", "01-12-2020", "PepsiCo", 1500));
            DSSanPham.Add(new DoUong("DK0004", "LaVie", 7800, 20, "Nuoc khoang chai the thao", "SL10", "27-11-2019", "27-11-2022", "LaVie", 750));
            DSSanPham.Add(new DoUong("DK0005", "Fruzie", 10000, 50, "Nuoc hoa qua voi nhieu lua chon huong vi", null, "20-10-2019", "20-10-2022", "Fruzie", 500));
            #endregion
            #region Client
            DSKhachHang.Add(new KhachHang("0945678321", 4));
            DSKhachHang.Add(new KhachHang("0356652304", 50000));
            DSKhachHang.Add(new KhachHang("0945918317", 32000));
            DSKhachHang.Add(new KhachHang("0366996232", 500));
            DSKhachHang.Add(new KhachHang("0935667788", 33000));
            DSKhachHang.Add(new KhachHang("0366323455", 45200));
            DSKhachHang.Add(new KhachHang("0986877198", 564800));
            DSKhachHang.Add(new KhachHang("0577883321", 350));
            DSKhachHang.Add(new KhachHang("0987822345", 89000));
            #endregion
            #region Employee
            DSNhanVien.Add(new NhanVien("EP0001", "DIEP TAN LUAN"));
            DSNhanVien.Add(new NhanVien("EP0002", "VO HOANG KHA DIEU"));
            DSNhanVien.Add(new NhanVien("EP0003", "PHI DINH NGUYEN"));
            DSNhanVien.Add(new NhanVien("EP0004", "LONG SI HOA"));
            #endregion
        }

        public static void AddSP (List<SanPham> DSSanPham, List<SanPham> listSP)
        {
            string masp;
            int soluong;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t MA SAN PHAM : ");
            masp = Console.ReadLine();
            Console.Write("\t SO LUONG : ");
            soluong = int.Parse(Console.ReadLine());
            for (int i = 0; i < DSSanPham.Count; i++)
            {
                if (masp == DSSanPham[i].Masp)
                {
                    Console.WriteLine("\t {0} x {1} - {2}", soluong, DSSanPham[i].Tensp, DSSanPham[i].Giatien);
                    DSSanPham[i].Soluong -= soluong;
                    SanPham a = new ThucAnNhanh(DSSanPham[i]);
                    a.Soluong = soluong;
                    listSP.Add(a);
                }
            }
            Console.WriteLine("\t───────────────────────────────────────────────");
            string exit;
            Console.Write("\t");
            exit = Console.ReadLine();
            if (exit != "end") AddSP(DSSanPham, listSP);
        } 

        public static void Giaodich()
        {
            HoaDon hoadon = new HoaDon();
            string masp;

            Console.Clear();
            TTMART.XinChao();
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tLET'S START A DEAL (press 'end' to end the deal)");
            Console.Write("\n\t│");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" EMPLOYEE : ");
            Console.ResetColor();
            masp = Console.ReadLine();

            #region Tim Nhan Vien Theo Code
            var KQ = from l in DSNhanVien
                     where l.Maso == masp
                     select l;
            int kt = 0;
            foreach (var l in KQ)
            {
                kt = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t│");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" HELLO " + l.HoTen);
                hoadon.NV = l;
            }

            if (kt == 0)
            {
                TTMART.Giaodich();
                return;
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t│");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" CLIENT : ");
            Console.ResetColor();
            masp = Console.ReadLine();
            #region Tim Khach Hang Theo SDT
            int i = 0;
            while (i < DSKhachHang.Count)
            {
                if (DSKhachHang[i].Maso == masp)
                {
                    KhachHang a = DSKhachHang[i];
                    hoadon.KH = a;
                    break;
                }
                i++;
            }
            if (hoadon.KH == null)
            {
                DSKhachHang.Add(hoadon.KH = new KhachHang(masp, 0));
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t└──────────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t ENTER PRODUCT'S INFORMATION\n");
            hoadon.SP = new List<SanPham>();
            AddSP(DSSanPham, hoadon.SP);// add PD vao Bill
            Console.Clear();
            TTMART.XinChao();
            hoadon.Time = DateTime.Now;
            hoadon.Xuat();
            if (hoadon.KH.Diem >= hoadon.hd)
            {
                string choose;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\tCLIENT HAVE {0}-Point, PAYMENT METHOND?: ", hoadon.KH.Diem);
                Console.ResetColor();
                choose = Console.ReadLine();
                if (choose == "Point")
                {
                    hoadon.KH.Diem -= hoadon.hd;
                    hoadon.hd = 0;
                    Console.WriteLine("\t\t\t-PAID BY POINT- ");
                }
                else
                {
                    Console.WriteLine("\t\t\t-PAID BY MONEY- ");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t-PAID BY MONEY- ");
            }
            DSHoaDon.Add(hoadon);
        }

        public static void Update()
        {
            DateTime timnow = DateTime.Now;
            for (int i = 0; i < DSSanPham.Count; i++)
            {
                if ((DSSanPham[i].HSD - timnow).Days <= 0)
                {
                    SanPham a = DSSanPham[i];
                    DSHetHSD.Add(a);
                    DSSanPham[i].Soluong = 0;
                }
                if (("FD".Contains(DSSanPham[i].Masp) == true || "DK".Contains(DSSanPham[i].Masp) == true) && DSSanPham[i].Giamgia == null && (DSSanPham[i].HSD - timnow).Days > 0 && (DSSanPham[i].HSD - timnow).Days <= 60)
                {
                    DSSanPham[i].Giamgia = "SL50";
                }
                if ("FF".Contains(DSSanPham[i].Masp) == true && DSSanPham[i].Giamgia == null && (DSSanPham[i].HSD - timnow).Days > 0 && (DSSanPham[i].HSD - timnow).Days <= 2)
                {
                    DSSanPham[i].Giamgia = "HD3000";
                }
            }
        }//tự update sale

        public static void XinChao()
        {
            DateTime timenow = DateTime.Now;
            string Timeofday = null;
            if (timenow.Hour >= 1 && timenow.Hour < 12) Timeofday = "BUOI SANG";
            if (timenow.Hour >= 12 && timenow.Hour < 16) Timeofday = "BUOI CHIEU";
            if (timenow.Hour >= 16 && timenow.Hour < 24) Timeofday = "BUOI TOI";

            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t- CHAO {0} !! CHAO MUNG BAN DEN VOI CUA HANG TT -", Timeofday);
            Console.ResetColor();
        }

        public static void OutDSSanPham()
        {
            int t = 0;
            for (int i = 0; i < DSSanPham.Count; i++)
            {
                t = 1;
                DSSanPham[i].Thongtinsp();
            }
            if (t == 0) Console.WriteLine("\t -null-");
        }

        public static void OutDSHetHSD()
        {
            int t = 0;
            for (int i = 0; i < DSHetHSD.Count; i++)
            {
                t = 1;
                DSHetHSD[i].Thongtinsp();
            }
            if (t == 0) Console.WriteLine("\t -null-");
        }

        public static void OutDSHoaDon()
        {
            int t = 0;
            for (int i = 0; i < DSHoaDon.Count; i++)
            {
                t = 1;
                DSHoaDon[i].Xuat();
            }
            if (t == 0) Console.WriteLine("\t -null-");
        }

        public static void OutDSNhanVien()
        {
            int t = 0;
            for (int i = 0; i < DSNhanVien.Count; i++)
            {
                t = 1;
                DSNhanVien[i].Xuat();
            }
            if (t == 0) Console.WriteLine("\t -null-");
        }

        public static void OutDSKhachHang()
        {
            int t = 0;
            for (int a = 0; a < DSKhachHang.Count; a++)
            {
                for (int b = a + 1; b < DSKhachHang.Count; b++)
                {
                    if (DSKhachHang[a].Diem < DSKhachHang[b].Diem)
                    {
                        KhachHang temp = DSKhachHang[a];
                        DSKhachHang[a] = DSKhachHang[b];
                        DSKhachHang[b] = temp;
                    }
                }
            }
            Console.WriteLine("\t CLIENT \t RANK\tPOINT");
            for (int i = 0; i < DSKhachHang.Count; i++)
            {
                t = 1;
                DSKhachHang[i].Xuat();
            }
            if (t == 0) Console.WriteLine("\t -null-");
        }

        public static void OutDSGiamgia()
        {
            int temp = 0;
            var KQ = from l in TTMART.DSSanPham
                     where l.Giamgia != null
                     select l;
            foreach (var l in KQ)
            {
                temp = 1;
                ConsoleColor foreground = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t {0} ", l.Giamgia);
                Console.ResetColor();
                Console.WriteLine("{0}-{1}", l.Masp, l.Tensp);
            }
            if (temp == 0)
            {
                Console.WriteLine("\t -null- ");
            }
        }

    }

}

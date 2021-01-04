using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMart
{
    class Program
    {
        static void Main(string[] args)
        {
            TTMART.Add();
            TTMART.XinChao();
            Choose();
            Console.ReadKey();
        }
        static void Choose()
        {
            Console.Clear();
            TTMART.XinChao();
            Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
            Console.WriteLine("\t │  1.BAT DAU GIAO DICH         │");
            Console.WriteLine("\t │  2.DANG NHAP VAO HE THONG    │");
            Console.WriteLine("\t └──────────────────────────────┘");
            Console.Write("\t Lua chon: ");
            int choose;
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    TTMART.Giaodich();
                    Console.ReadKey();
                    Choose();
                    break;
                case 2:
                    Console.Clear();
                    TTMART.XinChao();
                    Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
                    Console.WriteLine("\t │  1.DS SAN PHAM.\t\t│");
                    Console.WriteLine("\t │  2.DS KHACH HANG.\t\t│");
                    Console.WriteLine("\t │  3.DS NHAN VIEN.\t\t│");
                    Console.WriteLine("\t │  4.DS GIAM GIA.\t\t│");
                    Console.WriteLine("\t │  5.DS SAN PHAM HET HSD.\t│");
                    Console.WriteLine("\t │  6.DS HOA DON.\t\t│");
                    Console.WriteLine("\t └──────────────────────────────┘");
                    Console.Write("\t Lua chon: ");
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1: 
                            {
                                Console.Clear();
                                TTMART.XinChao();
                                Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
                                Console.WriteLine("\t │  1.THEM SAN PHAM MOI.\t\t│");
                                Console.WriteLine("\t │  2.XOA SAN PHAM.\t\t│");
                                Console.WriteLine("\t │  3.TIM KIEM SAN PHAM.\t\t│");
                                Console.WriteLine("\t │  4.THOAT DS SAN PHAM.\t│");
                                Console.WriteLine("\t └──────────────────────────────┘");
                                Console.Write("\t Lua chon: ");
                                choose = int.Parse(Console.ReadLine());
                                string masp;
                                int temp = 0;
                                switch (choose)
                                {
                                    case 1: 
                                        Console.Write("\t MA SP  : ");
                                        masp = Console.ReadLine();
                                        switch (masp[1])
                                        {
                                            case 'F':
                                                ThucAnNhanh TN = new ThucAnNhanh();
                                                TN.Masp = masp;
                                                TN.Nhap();
                                                TTMART.DSSanPham.Add(TN);
                                                break;
                                            case 'D':
                                                ThucAn TA = new ThucAn();
                                                TA.Masp = masp;
                                                TA.Nhap();
                                                TTMART.DSSanPham.Add(TA);
                                                break;
                                            case 'K':
                                                ThucAn DK = new ThucAn();
                                                DK.Masp = masp;
                                                DK.Xuat();
                                                TTMART.DSSanPham.Add(DK);
                                                break;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("\t THEM THANH CONG!!\n\t ");
                                        Console.ResetColor();
                                        masp = Console.ReadLine();
                                        if (masp != "ket thuc") goto case 1;
                                        break;
                                    case 2: 
                                        Console.Write("\t MA SP : ");
                                        masp = Console.ReadLine();
                                        for (int i = 0; i < TTMART.DSSanPham.Count; i++)
                                        {
                                            if (masp == TTMART.DSSanPham[i].Masp)
                                            {
                                                temp = 1;
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.Write("\t XOA {0} - {1}!!\n\t ", TTMART.DSSanPham[i].Masp, TTMART.DSSanPham[i].Tensp);
                                                Console.ResetColor();
                                                TTMART.DSSanPham.Remove(TTMART.DSSanPham[i]);
                                                break;
                                            }
                                        }
                                        if (temp == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Khong ton tai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        masp = Console.ReadLine();
                                        if (masp != "ket thuc") goto case 2;
                                        break;
                                    case 3: 
                                        Console.Write("\t MA SP  : ");
                                        masp = Console.ReadLine();
                                        var KQ = from l in TTMART.DSSanPham
                                                 where l.Masp == masp
                                                 select l;
                                        foreach (var l in KQ)
                                        {
                                            temp = 1;
                                            l.Thongtinsp();
                                        }
                                        if (temp == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t TIM KIEM THAT BAI!!\n\t");
                                            Console.ResetColor();
                                        }
                                        masp = Console.ReadLine();
                                        if (masp != "ket thuc") goto case 3;
                                        break;
                                    case 4:
                                        TTMART.OutDSSanPham();
                                        Console.ReadKey();
                                        break;

                                }
                                masp = Console.ReadLine();
                                if (masp != "end") goto case 1;
                                Choose();
                                break;
                            }
                        case 2: //LISTCLIENT
                            {

                                Console.Clear();
                                TTMART.XinChao();
                                Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
                                Console.WriteLine("\t │  1.THEM KHACH HANG MOI.\t\t│");
                                Console.WriteLine("\t │  2.XOA KHACH HANG.\t\t│");
                                Console.WriteLine("\t │  3.TIM KIEM KHACH HANG.\t\t│");
                                Console.WriteLine("\t │  4.THOAT DS KHACH HANG.\t│");
                                Console.WriteLine("\t └──────────────────────────────┘");
                                Console.Write("\t Lua chon: ");
                                choose = int.Parse(Console.ReadLine());
                                string masp;
                                int temp = 0;
                                switch (choose)
                                {
                                    case 1: 
                                        {
                                            KhachHang a = new KhachHang();
                                            a.Nhap();
                                            TTMART.DSKhachHang.Add(a);
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("\t Them khach hang thanh cong!!\n\t ");
                                            Console.ResetColor();
                                            masp = Console.ReadLine();
                                            if (masp != "ket thuc") goto case 1;
                                            break;
                                        }
                                    case 2: 
                                        Console.Write("\t | MA SO  : ");
                                        masp = Console.ReadLine();
                                        for (int i = 0; i < TTMART.DSKhachHang.Count; i++)
                                        {
                                            if (masp == TTMART.DSKhachHang[i].Maso)
                                            {
                                                temp = 1;
                                                ConsoleColor foreground = Console.ForegroundColor;
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.Write("\t Remove {0}!!\n\t ", TTMART.DSKhachHang[i].Maso);
                                                Console.ResetColor();
                                                TTMART.DSKhachHang.Remove(TTMART.DSKhachHang[i]);
                                                break;
                                            }
                                        }
                                        if (temp == 0)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Khong ton tai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        masp = Console.ReadLine();
                                        if (masp != "ket thuc") goto case 2;
                                        break;
                                    case 3: 
                                        Console.Write("\t | MA SP  : ");
                                        masp = Console.ReadLine();
                                        var KQ = from l in TTMART.DSKhachHang
                                                 where l.Maso == masp
                                                 select l;
                                        foreach (var l in KQ)
                                        {
                                            temp = 1;
                                            l.Xuat();
                                        }
                                        if (temp == 0)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Tim kiem that bai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        masp = Console.ReadLine();
                                        if (masp != "ket thuc") goto case 3;
                                        break;
                                    case 4:
                                        TTMART.OutDSKhachHang();
                                        Console.ReadKey();
                                        break;
                                }
                                Choose();
                                break;
                            }
                        case 3: //LISTEMPLOYEE
                            {
                                Console.Clear();
                                TTMART.XinChao();
                                Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
                                Console.WriteLine("\t │  1.THEM NHAN VIEN MOI.\t\t│");
                                Console.WriteLine("\t │  2.XOA NHAN VIEN.\t\t│");
                                Console.WriteLine("\t │  3.TIM KIEM NHAN VIEN.\t\t│");
                                Console.WriteLine("\t │  4.THOAT DS NHAN VIEN.\t│");
                                Console.WriteLine("\t └──────────────────────────────┘");
                                Console.Write("\t Lua chon: ");
                                choose = int.Parse(Console.ReadLine());
                                string masp;
                                string maso;
                                int temp = 0;
                                switch (choose)
                                {
                                    case 1: 
                                        {
                                            NhanVien a = new NhanVien();
                                            a.Nhap();
                                            TTMART.DSNhanVien.Add(a);
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("\t Them thanh cong!!\n\t ");
                                            Console.ResetColor();
                                            masp = Console.ReadLine();
                                            if (masp != "ket thuc") goto case 1;
                                            break;
                                        }
                                    case 2: 
                                        Console.Write("\t | MA SO  : ");
                                        masp = Console.ReadLine();
                                        temp = 0;
                                        for (int i = 0; i < TTMART.DSNhanVien.Count; i++)
                                        {
                                            if (masp == TTMART.DSNhanVien[i].Maso)
                                            {
                                                temp = 1;
                                                ConsoleColor foreground = Console.ForegroundColor;
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.Write("\t XOA {0}!!\n\t ", TTMART.DSNhanVien[i].Maso);
                                                Console.ResetColor();
                                                TTMART.DSNhanVien.Remove(TTMART.DSNhanVien[i]);
                                                break;
                                            }
                                        }
                                        if (temp == 0)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\t Khong ton tai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        masp = Console.ReadLine();
                                        if (masp != "ket thuc") goto case 2;
                                        break;
                                    case 3: 
                                        Console.Write("\t | MA SO  : ");
                                        maso = Console.ReadLine();
                                        temp = 0;
                                        var KQ = from l in TTMART.DSNhanVien
                                                 where l.Maso == maso
                                                 select l;
                                        foreach (var l in KQ)
                                        {
                                            temp = 1;
                                            l.Xuat();
                                        }
                                        if (temp == 0)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Tim kiem that bai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        maso = Console.ReadLine();
                                        if (maso != "ket thuc") goto case 3;
                                        break;
                                    case 4:
                                        TTMART.OutDSNhanVien();
                                        Console.ReadKey();
                                        break;
                                }
                                Choose();
                                break;
                            }
                        case 4: 
                            {
                                Console.Clear();
                                TTMART.XinChao();
                                Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
                                Console.WriteLine("\t │  1.THEM MA GIAM GIA MOI.\t\t│");
                                Console.WriteLine("\t │  2.XOA MA GIAM GIA.\t\t│");
                                Console.WriteLine("\t │  3.THOAT DS GIAM GIA.\t\t│");
                                Console.WriteLine("\t └──────────────────────────────┘");
                                Console.Write("\t Lua chon: ");
                                choose = int.Parse(Console.ReadLine());
                                string ma;
                                int temp = 0;
                                switch (choose)
                                {
                                    case 1: // Add new SALE
                                        Console.Write("\t MA : ");
                                        ma = Console.ReadLine();
                                        for (int i = 0; i < TTMART.DSSanPham.Count; i++)
                                        {
                                            if (ma == TTMART.DSSanPham[i].Masp)
                                            {
                                                temp = 1;
                                                Console.WriteLine("\t TEN SP  :" + TTMART.DSSanPham[i].Tensp);
                                                Console.Write("\t GIAM GIA  : ");
                                                TTMART.DSSanPham[i].Giamgia = Console.ReadLine();
                                            }
                                        }
                                        if (temp == 1)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("\t Them vao thanh cong!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Them vao that bai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        ma = Console.ReadLine();
                                        if (ma != "ket thuc") goto case 1;
                                        break;
                                    case 2:
                                        Console.Write("\t MA  : ");
                                        ma = Console.ReadLine();
                                        for (int i = 0; i < TTMART.DSSanPham.Count; i++)
                                        {
                                            if (ma == TTMART.DSSanPham[i].Masp)
                                            {
                                                temp = 1;
                                                ConsoleColor foreground = Console.ForegroundColor;
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.Write("\t Xoa {0} thanh cong!!\n\t ", TTMART.DSSanPham[i].Tensp);
                                                Console.ResetColor();
                                                TTMART.DSSanPham[i].Giamgia = null;
                                                break;
                                            }
                                        }
                                        if (temp == 0)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Xoa that bai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        ma = Console.ReadLine();
                                        if (ma != "ket thuc") goto case 2;
                                        break;
                                    case 3: 
                                        TTMART.OutDSGiamgia();
                                        Console.ReadKey();
                                        break;
                                }
                                Choose();
                                break;
                            }
                        case 5: 
                            {
                                TTMART.OutDSHetHSD();
                                Console.ReadKey();
                                Choose();
                                break;
                            }
                        case 6: 
                            {
                                Console.Clear();
                                TTMART.XinChao();
                                Console.WriteLine("\n\t ┌          CHUC NANG :       ──┐");
                                Console.WriteLine("\t │  1.TIM HOA DON.\t\t│");
                                Console.WriteLine("\t │  2.THOAT DS HOA DON.\t\t│");
                                Console.WriteLine("\t └──────────────────────────────┘");
                                Console.Write("\t Lua chon: ");
                                choose = int.Parse(Console.ReadLine());
                                string maso;
                                int temp = 0;
                                switch (choose)
                                {
                                    case 1: 
                                        temp = 0;
                                        Console.Write("\t MA HOA DON  : ");
                                        maso = Console.ReadLine();
                                        var KQ = from l in TTMART.DSHoaDon
                                                 where l.NV.Maso == maso
                                                 select l;
                                        foreach (var l in KQ)
                                        {
                                            temp = 1;
                                            l.Xuat();
                                        }
                                        if (temp == 0)
                                        {
                                            ConsoleColor foreground = Console.ForegroundColor;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\t Tim kiem that bai!!\n\t ");
                                            Console.ResetColor();
                                        }
                                        maso = Console.ReadLine();
                                        if (maso != "ket thuc") goto case 1;
                                        break;
                                    case 2:
                                        TTMART.OutDSHoaDon();
                                        Console.ReadKey();
                                        break;
                                }
                                Choose();
                                break;
                            }
                    }
                    break;
            }
        }
    }
}

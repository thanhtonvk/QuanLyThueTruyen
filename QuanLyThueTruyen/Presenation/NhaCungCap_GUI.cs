using QuanLyThueTruyen.BusinessLayer;
using QuanLyThueTruyen.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Presenation
{
    class NhaCungCap_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|               QUẢN LÍ Nhà cung cấp               |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm Nhà cung cấp                         |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|2. Hiện thị danh sách Nhà cung cấp                |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|3. Sửa thông tin Nhà cung cấp                     |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|4. Xóa thông tin Nhà cung cấp                     |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|5. Tìm kiếm Nhà cung cấp                          |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }

        public static void Run(NhaCungCap_DAL NhaCungCap_DAL, NhaCungCap_BLL NhaCungCap_BLL, ArrayList arrayList)
        {
            NhaCungCap_DAL.DocFile(arrayList);
            int chon;
            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        NhaCungCap_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        NhaCungCap_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        NhaCungCap_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        NhaCungCap_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        NhaCungCap_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        NhaCungCap_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        NhaCungCap_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        NhaCungCap_BLL.TimKiem(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}

using QuanLyThueTruyen.BusinessLayer;
using QuanLyThueTruyen.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Presenation
{
    class DangNhap_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Đăng nhập                    |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Đăng kí                      |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Thoát                        |");
            Console.WriteLine("---------------------------------------------------");
        }
        public static void Chon(ArrayList arrayList)
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 3) break;
                switch (chon)
                {
                    case 1:
                        bool kt = true;
                        if (kt == DangNhap_BLL.DangNhap(arrayList))
                        {
                            Console.WriteLine("Đăng nhập thành công");
                            
                            View.Run();
                        }
                        else
                        {
                            Console.WriteLine("Đăng nhập thất bại");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        DangNhap_BLL.TaoTK(arrayList);
                        DangNhap_DAL.GhiFile(arrayList);
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyThueTruyen.BusinessLayer;
using QuanLyThueTruyen.DataAccess;

namespace QuanLyThueTruyen.Presenation
{
    class View
    {
        private static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |           QUẢN LÝ CHO THUÊ TRUYỆN                |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. QUẢN LÝ ĐỘC GIẢ                                |");
            Console.WriteLine("                                 |2. QUẢN LÝ HÓA ĐƠN                                |");
            Console.WriteLine("                                 |3. QUẢN LÝ NHÀ CUNG CẤP                           |");
            Console.WriteLine("                                 |4. QUẢN LÝ NHÂN VIÊN                              |");
            Console.WriteLine("                                 |5. QUẢN LÝ SẢN PHẨM                               |");
            Console.WriteLine("                                 |6. QUẢN LÝ THỂ LOẠI                               |");
            Console.WriteLine("                                 |0. THOÁT                                          |");
            Console.WriteLine("                                 |__________________________________________________|");
        }

        static DocGia_BLL DocGia_BLL = new DocGia_BLL();
        static HoaDon_BLL HoaDon_BLL = new HoaDon_BLL();
        static DocGia_DAL DocGia_DAL = new DocGia_DAL();
        static HoaDon_DAL HoaDon_DAL = new HoaDon_DAL();
        static NhaCungCap_BLL NhaCungCap_BLL = new NhaCungCap_BLL();
        static NhaCungCap_DAL NhaCungCap_DAL = new NhaCungCap_DAL();
        static NhanVien_BLL NhanVien_BLL = new NhanVien_BLL();
        static NhanVien_DAL NhanVien_DAL = new NhanVien_DAL();
        static TheLoai_BLL theLoai_BLL = new TheLoai_BLL();
        static TheLoai_DAL theLoai_DAL = new TheLoai_DAL();
        static SanPham_BLL SanPham_BLL = new SanPham_BLL();
        static SanPham_DAL SanPham_DAL = new SanPham_DAL();
        static ArrayList DocGia = new ArrayList();
        static ArrayList HoaDon = new ArrayList();
        static ArrayList NhaCungCap = new ArrayList();
        static ArrayList NhanVien = new ArrayList();
        static ArrayList TheLoai = new ArrayList();
        static ArrayList SanPham = new ArrayList();
        public static void Run()
        {
            DocGia_DAL.DocFile(DocGia);
            HoaDon_DAL.DocFile(HoaDon);
            NhaCungCap_DAL.DocFile(NhaCungCap);
            NhanVien_DAL.DocFile(NhanVien);
            SanPham_DAL.DocFile(SanPham);
            theLoai_DAL.DocFile(TheLoai);
            Console.Clear();
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
                        Console.Clear();
                        DocGia_GUI.Run(DocGia_DAL, DocGia_BLL, DocGia);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        HoaDon_GUI.Run(HoaDon_DAL, HoaDon_BLL, HoaDon);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        NhaCungCap_GUI.Run(NhaCungCap_DAL, NhaCungCap_BLL, NhaCungCap);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        //nhan vien ,sanpham,theloai
                        NhanVien_GUI.Run(NhanVien_DAL, NhanVien_BLL, NhanVien);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        SanPham_GUI.Run(SanPham_DAL, SanPham_BLL, SanPham);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        TheLoai_GUI.Run(theLoai_DAL, theLoai_BLL, TheLoai);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}


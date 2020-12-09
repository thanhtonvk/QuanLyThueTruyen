using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.BusinessLayer
{
    class NhanVien_BLL
    {

        public NhanVien find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            NhanVien result = null;
            foreach (NhanVien NhanVien in arrayList)
            {
                if (keyword.Equals(NhanVien.Manv) || keyword.Equals(NhanVien.Tennv))
                {
                    result = NhanVien;
                }
            }
            return result;

        }
        //string manv,string tennv,string ngaysinh,string sdt,string diachi
        public void display(NhanVien NhanVien)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", NhanVien.Manv, NhanVien.Tennv, NhanVien.Ngaysinh, NhanVien.Sdt, NhanVien.Diachi);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã nhân viên", "Tên nhân viên", "Ngày sinh", "SĐT", "Địa chỉ");
            foreach (NhanVien NhanVien in arrayList)
            {
                display(NhanVien);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            string manv = (arrayList.Count + 1000).ToString();
            Console.WriteLine("Nhập tên nhân viên");
            string tennv = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh");
            string ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập SĐt");
            string sdt = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Console.ReadLine();
           
            arrayList.Add(new NhanVien(manv, tennv, ngaysinh, sdt, diachi));
        }

        public void Sua(ArrayList arrayList)
        {

            NhanVien kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("Nhập tên nhân viên");
                kq.Tennv= Console.ReadLine();
                Console.WriteLine("Nhập ngày sinh");
                kq.Ngaysinh= Console.ReadLine();
                Console.WriteLine("Nhập SĐT");
                kq.Sdt = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ");
               kq.Diachi= Console.ReadLine();
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            NhanVien kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã nhân viên", "Tên nhân viên", "Ngày sinh", "SĐT", "Địa chỉ");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            NhanVien kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                arrayList.Remove(kq);
                Console.WriteLine("Xóa thành công");
            }
        }
    }
}

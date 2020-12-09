using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.BusinessLayer
{
    class DocGia_BLL
    {

        public DocGia find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            DocGia result = null;
            foreach (DocGia DocGia in arrayList)
            {
                if (keyword.Equals(DocGia.Ma) || keyword.Equals(DocGia.Ten))
                {
                    result = DocGia;
                }
            }
            return result;

        }
     
        public void display(DocGia DocGia)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", DocGia.Ma, DocGia.Ten, DocGia.Ngaysinh, DocGia.Sdt, DocGia.Diachi,DocGia.Ngaydangki);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã độc giả", "Tên độc giả", "Ngày sinh", "SĐT", "Địa chỉ","Ngày đăng kí");
            foreach (DocGia DocGia in arrayList)
            {
                display(DocGia);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            string manv = (arrayList.Count + 1000).ToString();
            Console.WriteLine("Nhập tên độc giả");
            string tennv = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh");
            string ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập SĐt");
            string sdt = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Console.ReadLine();
            Console.WriteLine("Ngày đăng kí");
            string ngaydk = Console.ReadLine();

            arrayList.Add(new DocGia(manv, tennv, ngaysinh, sdt, diachi,ngaydk));
        }

        public void Sua(ArrayList arrayList)
        {

            DocGia kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("Nhập tên độc giả");
                kq.Ten = Console.ReadLine();
                Console.WriteLine("Nhập ngày sinh");
                kq.Ngaysinh = Console.ReadLine();
                Console.WriteLine("Nhập SĐT");
                kq.Sdt = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ");
                kq.Diachi = Console.ReadLine();
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            DocGia kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã độc giả", "Tên độc giả", "Ngày sinh", "SĐT", "Địa chỉ", "Ngày đăng kí");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            DocGia kq = find(arrayList);
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

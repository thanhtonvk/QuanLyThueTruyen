using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.BusinessLayer
{
    class NhaCungCap_BLL
    {

        public NhaCungCap find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            NhaCungCap result = null;
            foreach (NhaCungCap NhaCungCap in arrayList)
            {
                if (keyword.Equals(NhaCungCap.Tennhacc) || keyword.Equals(NhaCungCap.Sdt))
                {
                    result = NhaCungCap;
                }
            }
            return result;

        }       
        public void display(NhaCungCap NhaCungCap)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", NhaCungCap.Tennhacc, NhaCungCap.Diachi,NhaCungCap.Sdt);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Tên nhà cung cấp", "Địa chỉ","Số điện thoại");
            foreach (NhaCungCap NhaCungCap in arrayList)
            {
                display(NhaCungCap);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            Console.WriteLine("Nhập tên nhà cung cấp");
            string tenncc = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            string sdt = Console.ReadLine();
            arrayList.Add(new NhaCungCap(tenncc, diachi,sdt));
        }

        public void Sua(ArrayList arrayList)
        {

            NhaCungCap kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                
                Console.WriteLine("Nhập tên nhà cung cấp");
                kq.Tennhacc = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ");
                kq.Diachi = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại");
                kq.Sdt = Console.ReadLine();

                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            NhaCungCap kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{1,-20}|", "Tên nhà CC", "Địa chỉ","SĐT");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            NhaCungCap kq = find(arrayList);
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

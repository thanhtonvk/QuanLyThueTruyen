using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.BusinessLayer
{
    class TheLoai_BLL
    {

        public TheLoai find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            TheLoai result = null;
            foreach (TheLoai TheLoai in arrayList)
            {
                if (keyword.Equals(TheLoai.Matheloai) || keyword.Equals(TheLoai.Ten))
                {
                    result = TheLoai;
                }
            }
            return result;

        }        //string matruyen,string tentruyen,string theloai,int giachothue,int soluongcu,int soluongmoi
        public void display(TheLoai TheLoai)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|", TheLoai.Matheloai, TheLoai.Ten);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|", "Mã thê loại", "Tên thể loại");
            foreach (TheLoai TheLoai in arrayList)
            {
                display(TheLoai);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            string matheloai = (arrayList.Count + 1000).ToString();
            Console.WriteLine("Nhập tên thể loại");
            string theloai = Console.ReadLine();
    
            arrayList.Add(new TheLoai(matheloai,theloai));
        }

        public void Sua(ArrayList arrayList)
        {

            TheLoai kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("Nhập tên truyện");
                kq.Ten = Console.ReadLine();
   
              
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            TheLoai kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|", "Mã thê loại", "Tên thể loại");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            TheLoai kq = find(arrayList);
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

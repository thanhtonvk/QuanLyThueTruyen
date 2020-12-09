using System;
using System.Text;
using System.Collections;
using QuanLyThueTruyen.Presenation;
namespace QuanLyThueTruyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            DangNhap_GUI.Chon(arrayList);
        }
    }
}

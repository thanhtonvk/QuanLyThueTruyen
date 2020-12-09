using QuanLyThueTruyen.DataAccess;
using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.BusinessLayer
{
    class DangNhap_BLL
    {
        public static void TaoTK(ArrayList list)
        {
            string tk = UserName();
            string mk = Password();
            list.Add(new DangNhap(tk, mk));
            DangNhap_DAL.GhiFile(list);
        }
        public static bool DangNhap(ArrayList list)
        {
            bool kt = false;
            DangNhap_DAL.DocFile(list);
            string tk = UserName();
            string mk = Password();
            foreach (DangNhap dangnhap in list)
            {
                if (tk.Equals(dangnhap.User) && mk.Equals(dangnhap.Password))
                {
                    kt = true;
                }
            }
            return kt;
        }
        public static string UserName()
        {
            string tk;
            while (true)
            {
                Console.WriteLine("Nhập tài khoản: ");
                tk = Console.ReadLine();
                if (tk != "") break;
            }
            return tk;
        }
        public static string Password()
        {
            string pass;
            while (true)
            {
                Console.WriteLine("Nhập mật khẩu: ");
                pass = Console.ReadLine();
                if (pass != "") break;
            }
            return pass;
        }
    }
}

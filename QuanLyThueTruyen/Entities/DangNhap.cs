using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Entities
{
    class DangNhap
    {
        private string user, password;
        public DangNhap()
        {

        }
        public DangNhap(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
        override
        public string ToString() => user + "#" + password;
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

    }
}

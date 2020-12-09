using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Entities
{
    class TheLoai
    {
        private string matheloai,ten;
        public TheLoai(string matheloai,string ten)
        {
            this.matheloai = matheloai;
            this.ten = ten;
        }
        override
            public string ToString()
        {
            return matheloai + "#" + ten;
        }
        public string Matheloai { get => matheloai; set => matheloai = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}

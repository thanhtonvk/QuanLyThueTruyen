using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Entities
{
    class DocGia
    {
        private string ten, ma, ngaysinh, sdt, diachi, ngaydangki;
        public DocGia(string ten,string ma,string ngaysinh,string sdt,string diachi,string ngaydangki)
        {
            this.ten = ten;
            this.ma = ma;
            this.ngaydangki = ngaydangki;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.diachi = diachi;
        }
        override
            public string ToString()
        {
            return ten + "#" + ma + "#" + ngaysinh + "#" + sdt + "#" + diachi + "#" + ngaydangki;
        }
        public string Ten { get => ten; set => ten = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ngaydangki { get => ngaydangki; set => ngaydangki = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Entities
{
    class SanPham
    {
        private string matruyen, tentruyen, theloai;
        private int giachothue, soluongcu, soluongmoi;
        public SanPham(string matruyen,string tentruyen,string theloai,int giachothue,int soluongcu,int soluongmoi)
        {
            this.matruyen = matruyen;
            this.tentruyen = tentruyen;
            this.theloai = theloai;
            this.giachothue = giachothue;
            this.soluongcu = soluongcu;
            this.soluongmoi = soluongmoi;
        }
        override
            public string ToString()
        {
            return matruyen + "#" + tentruyen + "#" + theloai + "#" + giachothue + "#" + soluongcu + "#" + soluongmoi;
        }
        public string Matruyen { get => matruyen; set => matruyen = value; }
        public string Tentruyen { get => tentruyen; set => tentruyen = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public int Giachothue { get => giachothue; set => giachothue = value; }
        public int Soluongcu { get => soluongcu; set => soluongcu = value; }
        public int Soluongmoi { get => soluongmoi; set => soluongmoi = value; }
    }
}

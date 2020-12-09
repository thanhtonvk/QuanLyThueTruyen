using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Entities
{
    class NhanVien
    {
        private string manv,tennv,ngaysinh,sdt,diachi;
        public NhanVien(string manv,string tennv,string ngaysinh,string sdt,string diachi)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.diachi = diachi;
        }
        override
            public string ToString()
        {
            return manv + "#" + tennv + "#" + ngaysinh + "#" + sdt + "#" + diachi;
        }
        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}

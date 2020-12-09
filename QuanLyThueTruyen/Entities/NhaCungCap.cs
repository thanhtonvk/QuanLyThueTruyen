using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThueTruyen.Entities
{
    class NhaCungCap
    {
        private string tennhacc, diachi, sdt;
        public NhaCungCap(string tennhacc,string diachi,string sdt)
        {
            this.tennhacc = tennhacc;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        override
            public string ToString()
        {
            return tennhacc + "#" + diachi + "#" + sdt;
        }
        public string Tennhacc { get => tennhacc; set => tennhacc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class HocSinh22110100
    {
        // Thuộc tính
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }
        public string MaHocSinh { get; set; }

        // Constructor (khởi tạo)
        public HocSinh22110100(string hoTen, int namSinh, string lop, string maHocSinh = null)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            Lop = lop;
            MaHocSinh = maHocSinh;
        }

        // Method 
        public int TinhTuoi()
        {
            return DateTime.Now.Year - NamSinh;
        }

        public override string ToString()
        {
            return $"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Lop: {Lop}, Ma hoc sinh: {MaHocSinh}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    public class ThongTinKhachHang
    {
        private static ThongTinKhachHang instance;

        public static ThongTinKhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinKhachHang();
                return ThongTinKhachHang.instance;
            }

            private set
            {
                ThongTinKhachHang.instance = value;
            }
        }
        private ThongTinKhachHang() { }
    }
    public class ThongTinTiec
    {
        private static ThongTinTiec thongtin;

        public static ThongTinTiec Thongtin
        {
            get
            {
                if (thongtin == null)
                    thongtin = new ThongTinTiec();
                return thongtin;
            }

            set
            {
                ThongTinTiec.thongtin = value;
            }
        }
    }
}

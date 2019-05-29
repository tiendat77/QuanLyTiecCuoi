using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QL_TiecCuoi.DAO
{
    public class DangNhapDAO
    {

        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAO();
                return instance;
            }

          private set
            {
                 instance = value;
            }
        }

       public DataTable DataProvide { get; private set; }

        private DangNhapDAO()
        { }
        public bool DangNhap(string TenDangNhap, string MatKhau)
        {
            string query = "select * from TaiKhoan where TenDangNhap = '"+ TenDangNhap +"' and MatKhau = '"+ MatKhau +"' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}

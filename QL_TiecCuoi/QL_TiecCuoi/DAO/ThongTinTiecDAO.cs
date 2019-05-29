using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class ThongTinTiecDAO
    {
        private static ThongTinTiecDAO instance;

        public static ThongTinTiecDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinTiecDAO();
                return ThongTinTiecDAO.instance;
            }

           private set
            {
                ThongTinTiecDAO.instance = value;
            }
        }
        private ThongTinTiecDAO() { }
    }
}

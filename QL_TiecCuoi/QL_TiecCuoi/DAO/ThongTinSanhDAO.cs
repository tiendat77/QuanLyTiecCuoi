using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    public class ThongTinSanhDAO
    {
        private static ThongTinSanhDAO instance;

        public static ThongTinSanhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinSanhDAO();
                return ThongTinSanhDAO.instance;
            }

            private set
            {
                ThongTinSanhDAO.instance = value;
            }
        }
        private ThongTinSanhDAO() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuDAO();
                return DichVuDAO.instance;
            }

            private set
            {
                DichVuDAO.instance = value;
            }
        }
        private DichVuDAO() { }
    }
}

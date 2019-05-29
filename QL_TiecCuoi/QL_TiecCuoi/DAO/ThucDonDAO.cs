using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class ThucDonDAO
    {
        private static ThucDonDAO instance;
        public static ThucDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThucDonDAO();
                return ThucDonDAO.instance;
            }

            private set
            {
                ThucDonDAO.instance = value;
            }
        }
        private ThucDonDAO() { }
    }
}

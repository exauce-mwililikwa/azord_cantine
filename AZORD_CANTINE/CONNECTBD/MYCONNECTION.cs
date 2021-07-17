using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZORD_CANTINE.CONNECTBD
{
    class MYCONNECTION
    {
        public static SqlConnection con=new SqlConnection("Data Source=DESKTOP-0FJ1LUK\\SA;Initial Catalog=CATINE;User ID=sa;Password=aliconnorecho");
    }
}

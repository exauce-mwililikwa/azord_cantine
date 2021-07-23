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
        public static SqlConnection con=new SqlConnection("Data Source=EXAUCE\\SA;Initial Catalog=CATINE;User ID=sa;Password=aliconnorecho");
    }
}

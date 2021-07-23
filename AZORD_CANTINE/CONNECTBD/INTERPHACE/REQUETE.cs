using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZORD_CANTINE.CONNECTBD.INTERPHACE
{
    class REQUETE
    {
        public static string LIMITE_ANNE_AJOUTER="SELECT (ISNULL(MAX(NIVEAU),0)+1) FROM NIVEAU";
    }
}

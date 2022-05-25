using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entities
{
    public static  class Baglanti
    {
        public static DBStokTakipEntities db = new DBStokTakipEntities();
        public static SqlConnection bgl = new SqlConnection("data source=94.73.170.10;Initial Catalog=u0241506_Pharma; User Id=u0241506_Pharma;Password=BXml94J5AVcm13T;;MultipleActiveResultSets=True;");
    }
}

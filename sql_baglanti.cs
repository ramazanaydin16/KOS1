using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KSO
{
    class sql_baglanti
    {
        public SqlConnection sql_baglantisi()
        {
            SqlConnection sql_baglan = new SqlConnection("Data Source=DESKTOP-O2UH4R3;Initial Catalog=KSO;Integrated Security=True");
            sql_baglan.Open();
            return sql_baglan;
        }
    }
}

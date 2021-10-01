using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLBH_PS18832_Son;Integrated Security=True");


    }
}

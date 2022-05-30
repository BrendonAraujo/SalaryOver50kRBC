using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RBC_Salario.DB
{
    public class DB
    {
        public static SqlConnection conection()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-JNS\SQLEXPRESS;Initial Catalog=RBCSALARIO;User ID=sa;Password=123";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
    }
}

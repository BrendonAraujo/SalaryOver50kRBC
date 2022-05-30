using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RBC_Salario.DB;
using System.Data;

namespace RBC_Salario.Controler
{
    public class CaseDAO
    {     
        public static int getSumRowCase()
        {
            int retorno = 0;
            SqlDataReader reader = null;
            string commandText = "SELECT COUNT(HANDLE) ROWNUM FROM salary";
            SqlConnection con = DB.DB.conection();
            SqlCommand command = new SqlCommand(commandText, con);
            con.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                retorno = reader.GetInt32("ROWNUM");
            }
            con.Close();
            return retorno;
        }
        public static void insertCase(Case newCase)
        {
            string commandText = "INSERT INTO salary (AGE, WORKCLASS, EDUCATION, marital_status, OCCUPATION, relationship, RACE, SEX, hour_per_week, NATIVE_COUNTRY) VALUES (@AGE, @WORKCLASS, @EDUCATION, @marital_status, @OCCUPATION, @relationship, @RACE, @SEX, @hour_per_week, @NATIVE_COUNTRY)";
            SqlConnection con = DB.DB.conection();
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@AGE", newCase.age);
            command.Parameters.AddWithValue("@WORKCLASS", newCase.workClass);
            command.Parameters.AddWithValue("@EDUCATION", newCase.age);
            command.Parameters.AddWithValue("@marital_status", newCase.workClass);
            command.Parameters.AddWithValue("@OCCUPATION", newCase.age);
            command.Parameters.AddWithValue("@relationship", newCase.workClass);
            command.Parameters.AddWithValue("@RACE", newCase.age);
            command.Parameters.AddWithValue("@SEX", newCase.workClass);
            command.Parameters.AddWithValue("@hour_per_week", newCase.age);
            command.Parameters.AddWithValue("@NATIVE_COUNTRY", newCase.workClass);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        public static SqlDataReader GetCases()
        {
            List<Case> retorno = new List<Case>();
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT * FROM salary";
            SqlCommand command = new SqlCommand(commandText, con);
            con.Open();
            reader = command.ExecuteReader();
            return reader;
        }
        public static List<String> getEducationList()
        {
            List<String> retorno = new List<string>();
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT EDUCATION FROM salary GROUP BY education ORDER BY education";
            SqlCommand command = new SqlCommand(commandText, con);
            con.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);
                
            }
            reader.Close();
            con.Close();
            return retorno;
        }
        public static List<String> getMaritalStatusList()
        {
            List<String> retorno = new List<string>(); ;
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT MARITAL_STATUS FROM salary GROUP BY MARITAL_STATUS ORDER BY MARITAL_STATUS";
            SqlCommand command = new SqlCommand(commandText, con);
            con.Open();

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);

            }
            reader.Close();
            con.Close();
            return retorno;
        }
        public static List<String> getOcupationList()
        {
            List<String> retorno = new List<string>(); ;
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT occupation FROM salary GROUP BY occupation ORDER BY occupation";
            SqlCommand command = new SqlCommand(commandText, con);
            con.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);

            }
            reader.Close();
            con.Close();
            return retorno;
        }
        public static List<String> getRelationShipList()
        {
        List<String> retorno = new List<string>(); ;
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT RelationShip FROM salary GROUP BY RelationShip ORDER BY RelationShip";
            SqlCommand command = new SqlCommand(commandText, con);
            con.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);

            }
            reader.Close();
            con.Close();
            return retorno;
        }
        public static List<String> getRaceList()
        {
            List<String> retorno = new List<string>(); ;
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT race FROM salary GROUP BY race ORDER BY race";
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);

            }
            reader.Close();
            con.Close();
            return retorno;
        }
        public static List<String> getWorkClassList()
        {
            List<String> retorno = new List<string>(); ;
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT workclass FROM salary GROUP BY workclass ORDER BY workclass";
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);

            }
            reader.Close();
            con.Close();
            return retorno;
        }
        public static List<String> getNativeCountryList()
        {
            List<String> retorno = new List<string>(); ;
            SqlDataReader reader = null;
            SqlConnection con = DB.DB.conection();
            string commandText = "SELECT NATIVE_COUNTRY FROM salary GROUP BY NATIVE_COUNTRY ORDER BY NATIVE_COUNTRY";
            con.Open();
            SqlCommand command = new SqlCommand(commandText, con);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                while (reader.Read())
                {
                    retorno.Add(reader.GetString(0));
                }
                //retorno = Convert.ToString(reader["salary"]);

            }
            reader.Close();
            con.Close();
            return retorno;
        }
    }
}

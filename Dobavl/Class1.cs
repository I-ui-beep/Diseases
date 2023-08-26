using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Заболевания.Dobavl
{
    class Class1
    {
        public SqlConnection con;

        public Class1()
        {
           
            con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
        }
    }
    class Data_Insert: Class1
    {
        public void Insert_to_DB(string b_name, string S_1)
        {
            using (SqlCommand command = new SqlCommand())
            {
                con.Open();
                command.CommandText = "INSERT INTO 'pr_calves'('Name_b','S_1') VALUES (@b_name, @S_1)";
                command.CommandType = CommandType.Text;
                command.Connection = con;

                command.Parameters.Add("@b_name", SqlDbType.VarChar).Value = b_name;
                command.Parameters.Add("@S_1", SqlDbType.VarChar).Value = S_1;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch(FormatException)
                {

                }
                con.Close();
            }
        }
    }
}

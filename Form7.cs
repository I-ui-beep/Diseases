using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Заболевания
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Form9 Ad;
        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;
            SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
            DataTable zTable = new DataTable();
            SqlDataAdapter zAdapter;
            con1.Open();
            
            SqlCommand command = new SqlCommand("Select * FROM avtor WHERE Name_log = @ul AND Name_pass = @up", con1);
            command.Parameters.Add("@ul", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", SqlDbType.VarChar).Value = passUser; 
            zAdapter = new SqlDataAdapter(command);
            zAdapter.Fill(zTable);
            con1.Close();

            if (zTable.Rows.Count <= 0)
            {
                MessageBox.Show("Неправильные логин/пароль");
            }
            else
            {
                Ad = new Form9();
                Ad.ShowDialog(this);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


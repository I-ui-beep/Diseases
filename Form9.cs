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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView1.DataSource = zTable.DefaultView;

                SqlConnection con2 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable z2Table = new DataTable();
                SqlDataAdapter z2Adapter;
                con2.Open();
                SqlCommand command2 = new SqlCommand("Select * FROM Symptoms_Calves", con2);
                z2Adapter = new SqlDataAdapter(command2);
                z2Adapter.Fill(z2Table);
                con2.Close();
                dataGridView2.DataSource = z2Table.DefaultView;

                SqlConnection con3 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable z3Table = new DataTable();
                SqlDataAdapter z3Adapter;
                con3.Open();
                SqlCommand command3 = new SqlCommand("Select * FROM avtor", con3);
                z3Adapter = new SqlDataAdapter(command3);
                z3Adapter.Fill(z3Table);
                con3.Close();
                dataGridView3.DataSource = z3Table.DefaultView;

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }
    }
}

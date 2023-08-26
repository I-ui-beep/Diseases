using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Заболевания
{
    public partial class Form4 : Form
    {



        public Form4()
        {
            InitializeComponent();
        }

   




        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            checkBox3.Visible = true;
            checkBox37.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_3 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
            /*finally
            {
                if (con1.State == ConnectionState.Open)
                    con1.Close();
            }*/
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            checkBox39.Visible = true;
            checkBox4.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_2 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }


            // for (int i = 0; i < dataGridView1.Rows.Count; i++)

            // {
            // if (dataGridView1["S_1", i].Value != null ))
            //
            // {
            //    DataGridViewRow dgvDelRow = dataGridView1.Rows[i];
            //dataGridView1.Rows.Remove(dgvDelRow);
            // }
            // }
            //.Refresh();
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            checkBox5.Visible = true;
            checkBox40.Visible = true;
            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_4 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            checkBox6.Visible = true;
            checkBox41.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_5 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            checkBox7.Visible = true;
            checkBox42.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_6 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            checkBox44.Visible = true;
            checkBox43.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_9 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            checkBox10.Visible = true;
            checkBox9.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_10 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            checkBox45.Visible = true;
            checkBox12.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_12 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
            checkBox47.Visible = true;
            checkBox46.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_7 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = true;
            checkBox8.Visible = true;
            checkBox48.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_8 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label37.Visible = true;
            checkBox49.Visible = true;
            checkBox50.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_28 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            label36.Visible = true;
            checkBox51.Visible = true;
            checkBox52.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_36 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            label35.Visible = true;
            checkBox53.Visible = true;
            checkBox54.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_32 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            label13.Visible = true;
            checkBox55.Visible = true;
            checkBox56.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_1 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            label14.Visible = true;
            checkBox1.Visible = true;
            checkBox13.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_13 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            label18.Visible = true;
            checkBox21.Visible = true;
            checkBox32.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_21 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            label21.Visible = true;
            checkBox27.Visible = true;
            checkBox36.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_27 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            label19.Visible = true;
            checkBox57.Visible = true;
            checkBox58.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_29 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {
            label20.Visible = true;
            checkBox59.Visible = true;
            checkBox60.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_16 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {
            label17.Visible = true;
            checkBox16.Visible = true;
            checkBox17.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_17 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            label16.Visible = true;
            checkBox30.Visible = true;
            checkBox61.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_30 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            label15.Visible = true;
            checkBox23.Visible = true;
            checkBox62.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_23 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            label34.Visible = true;
            checkBox24.Visible = true;
            checkBox34.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_34 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            label25.Visible = true;
            checkBox63.Visible = true;
            checkBox64.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_24 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            label32.Visible = true;
            checkBox26.Visible = true;
            checkBox65.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_26 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            label33.Visible = true;
            checkBox11.Visible = true;
            checkBox25.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_11 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            label23.Visible = true;
            checkBox66.Visible = true;
            checkBox67.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_25 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox66_CheckedChanged(object sender, EventArgs e)
        {
            label22.Visible = true;
            checkBox19.Visible = true;
            checkBox35.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_19 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            label24.Visible = true;
            checkBox68.Visible = true;
            checkBox69.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_35 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox68_CheckedChanged(object sender, EventArgs e)
        {
            label31.Visible = true;
            checkBox14.Visible = true;
            checkBox22.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_22 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            label30.Visible = true;
            checkBox70.Visible = true;
            checkBox71.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_14 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox70_CheckedChanged(object sender, EventArgs e)
        {
            label29.Visible = true;
            checkBox72.Visible = true;
            checkBox73.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_18 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox72_CheckedChanged(object sender, EventArgs e)
        {
            label28.Visible = true;
            checkBox18.Visible = true;
            checkBox20.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_20 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            label27.Visible = true;
            checkBox15.Visible = true;
            checkBox29.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_15 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            label26.Visible = true;
            checkBox28.Visible = true;
            checkBox31.Visible = true;

            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_31 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            checkBox3.Visible = true;
            checkBox37.Visible = true;
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            checkBox39.Visible = true;
            checkBox4.Visible = true;

          /*  try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_2 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            checkBox5.Visible = true;
            checkBox40.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_4 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/

         }

         private void checkBox40_CheckedChanged(object sender, EventArgs e)
         {
             label6.Visible = true;
             checkBox6.Visible = true;
             checkBox41.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_5 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/

         }

         private void checkBox41_CheckedChanged(object sender, EventArgs e)
         {
             label8.Visible = true;
             checkBox7.Visible = true;
             checkBox42.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_6 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/

         }

         private void checkBox42_CheckedChanged(object sender, EventArgs e)
         {
             label9.Visible = true;
             checkBox44.Visible = true;
             checkBox43.Visible = true;

             /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_9 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/

         }

         private void checkBox43_CheckedChanged(object sender, EventArgs e)
         {
             label10.Visible = true;
             checkBox10.Visible = true;
             checkBox9.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_10 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            checkBox45.Visible = true;
            checkBox12.Visible = true;

            /*  try
              {
                  SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                  DataTable zTable = new DataTable();
                  SqlDataAdapter zAdapter;
                  con1.Open();
                  SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_12 != 1 ", con1);
                  zAdapter = new SqlDataAdapter(command);
                  zAdapter.Fill(zTable);
                  con1.Close();
                  dataGridView3.DataSource = zTable.DefaultView;

                  dataGridView3.DataSource = null;


              }
              catch
              {
                  MessageBox.Show("Ошибка соединения");
              }*/
          }

          private void checkBox12_CheckedChanged(object sender, EventArgs e)
          {
              label11.Visible = true;
              checkBox47.Visible = true;
              checkBox46.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_7 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = true;
            checkBox8.Visible = true;
            checkBox48.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_8 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox48_CheckedChanged(object sender, EventArgs e)
         {
             label37.Visible = true;
             checkBox49.Visible = true;
             checkBox50.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_28 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox50_CheckedChanged(object sender, EventArgs e)
         {
             label36.Visible = true;
             checkBox51.Visible = true;
             checkBox52.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_36 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox52_CheckedChanged(object sender, EventArgs e)
         {
             label35.Visible = true;
             checkBox53.Visible = true;
             checkBox54.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_32 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox54_CheckedChanged(object sender, EventArgs e)
         {
             label13.Visible = true;
             checkBox55.Visible = true;
             checkBox56.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_1 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox56_CheckedChanged(object sender, EventArgs e)
         {
             label14.Visible = true;
             checkBox1.Visible = true;
             checkBox13.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_13 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            label18.Visible = true;
            checkBox21.Visible = true;
            checkBox32.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_21 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox32_CheckedChanged(object sender, EventArgs e)
         {
             label21.Visible = true;
             checkBox27.Visible = true;
             checkBox36.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_27 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox36_CheckedChanged(object sender, EventArgs e)
         {
             label19.Visible = true;
             checkBox57.Visible = true;
             checkBox58.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_29 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox58_CheckedChanged(object sender, EventArgs e)
         {
             label20.Visible = true;
             checkBox59.Visible = true;
             checkBox60.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_16 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox60_CheckedChanged(object sender, EventArgs e)
         {
             label17.Visible = true;
             checkBox16.Visible = true;
             checkBox17.Visible = true;

            /*  try
              {
                  SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                  DataTable zTable = new DataTable();
                  SqlDataAdapter zAdapter;
                  con1.Open();
                  SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_17 != 1 ", con1);
                  zAdapter = new SqlDataAdapter(command);
                  zAdapter.Fill(zTable);
                  con1.Close();
                  dataGridView3.DataSource = zTable.DefaultView;

                  dataGridView3.DataSource = null;


              }
              catch
              {
                  MessageBox.Show("Ошибка соединения");
              }*/
          }

          private void checkBox17_CheckedChanged(object sender, EventArgs e)
          {
              label16.Visible = true;
              checkBox30.Visible = true;
              checkBox61.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_30 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox61_CheckedChanged(object sender, EventArgs e)
         {
             label15.Visible = true;
             checkBox23.Visible = true;
             checkBox62.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_23 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox62_CheckedChanged(object sender, EventArgs e)
         {
             label34.Visible = true;
             checkBox24.Visible = true;
             checkBox34.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_34 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox34_CheckedChanged(object sender, EventArgs e)
         {
             label25.Visible = true;
             checkBox63.Visible = true;
             checkBox64.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_24 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox64_CheckedChanged(object sender, EventArgs e)
         {
             label32.Visible = true;
             checkBox26.Visible = true;
             checkBox65.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_26 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox65_CheckedChanged(object sender, EventArgs e)
        {
            label33.Visible = true;
            checkBox11.Visible = true;
            checkBox25.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_11 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox25_CheckedChanged(object sender, EventArgs e)
         {
             label23.Visible = true;
             checkBox66.Visible = true;
             checkBox67.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_25 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox67_CheckedChanged(object sender, EventArgs e)
        {
            label22.Visible = true;
            checkBox19.Visible = true;
            checkBox35.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_19 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox35_CheckedChanged(object sender, EventArgs e)
         {
             label24.Visible = true;
             checkBox68.Visible = true;
             checkBox69.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_35 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox69_CheckedChanged(object sender, EventArgs e)
         {
             label31.Visible = true;
             checkBox14.Visible = true;
             checkBox22.Visible = true;

            /*  try
              {
                  SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                  DataTable zTable = new DataTable();
                  SqlDataAdapter zAdapter;
                  con1.Open();
                  SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_22 != 1 ", con1);
                  zAdapter = new SqlDataAdapter(command);
                  zAdapter.Fill(zTable);
                  con1.Close();
                  dataGridView3.DataSource = zTable.DefaultView;

                  dataGridView3.DataSource = null;


              }
              catch
              {
                  MessageBox.Show("Ошибка соединения");
              }*/
          }

          private void checkBox22_CheckedChanged(object sender, EventArgs e)
          {
              label30.Visible = true;
              checkBox70.Visible = true;
              checkBox71.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_14 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox71_CheckedChanged(object sender, EventArgs e)
        {
            label29.Visible = true;
            checkBox72.Visible = true;
            checkBox73.Visible = true;

            /*  try
              {
                  SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                  DataTable zTable = new DataTable();
                  SqlDataAdapter zAdapter;
                  con1.Open();
                  SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_18 != 1 ", con1);
                  zAdapter = new SqlDataAdapter(command);
                  zAdapter.Fill(zTable);
                  con1.Close();
                  dataGridView3.DataSource = zTable.DefaultView;

                  dataGridView3.DataSource = null;


              }
              catch
              {
                  MessageBox.Show("Ошибка соединения");
              }*/
          }

          private void checkBox73_CheckedChanged(object sender, EventArgs e)
          {
              label28.Visible = true;
              checkBox18.Visible = true;
              checkBox20.Visible = true;

            /*try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_20 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            label27.Visible = true;
            checkBox15.Visible = true;
            checkBox29.Visible = true;

            /* try
             {
                 SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                 DataTable zTable = new DataTable();
                 SqlDataAdapter zAdapter;
                 con1.Open();
                 SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_15 != 1 ", con1);
                 zAdapter = new SqlDataAdapter(command);
                 zAdapter.Fill(zTable);
                 con1.Close();
                 dataGridView3.DataSource = zTable.DefaultView;

                 dataGridView3.DataSource = null;


             }
             catch
             {
                 MessageBox.Show("Ошибка соединения");
             }*/
         }

         private void checkBox29_CheckedChanged(object sender, EventArgs e)
         {
             label26.Visible = true;
             checkBox28.Visible = true;
             checkBox31.Visible = true;

            /*  try
              {
                  SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                  DataTable zTable = new DataTable();
                  SqlDataAdapter zAdapter;
                  con1.Open();
                  SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_31 != 1 ", con1);
                  zAdapter = new SqlDataAdapter(command);
                  zAdapter.Fill(zTable);
                  con1.Close();
                  dataGridView3.DataSource = zTable.DefaultView;

                  dataGridView3.DataSource = null;


              }
              catch
              {
                  MessageBox.Show("Ошибка соединения");
              }*/
          }

          private void button1_Click(object sender, EventArgs e)
          {
              try
              {
                  SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                  DataTable zTable = new DataTable();
                  SqlDataAdapter zAdapter;
                  con1.Open();
                  SqlCommand command = new SqlCommand("Select TOP 5 Name_dis_c FROM B_C_V GROUP BY Name_dis_c ORDER BY COUNT(*) DESC ", con1);
                  zAdapter = new SqlDataAdapter(command);
                  zAdapter.Fill(zTable);
                  con1.Close();
                  dataGridView3.DataSource = zTable.DefaultView;




              }
              catch
              {
                  MessageBox.Show("Ошибка соединения");
              }
              /*SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
               for(int i=0; i<dataGridView1.Rows.Count-1; i++)
               {
                   SqlCommand command = new SqlCommand(@"INSERT INTO pr_calves (Name_b, S_1) VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "')", con);
                   con.Open();
                   command.ExecuteNonQuery();
                   con.Close();
               }
               dataGridView1.Rows.Clear();*/
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select TOP 5 Name_dis_c FROM B_C_V GROUP BY Name_dis_c ORDER BY COUNT(*) DESC ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;




            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            } /* try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("DELETE FROM B_C_V WHERE S_33 != 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                dataGridView3.DataSource = null;


            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }*/
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                DataTable zTable = new DataTable();
                SqlDataAdapter zAdapter;
                con1.Open();
                SqlCommand command = new SqlCommand("Select * FROM diseases_calves WHERE S_33 = 1 ", con1);
                zAdapter = new SqlDataAdapter(command);
                zAdapter.Fill(zTable);
                con1.Close();
                dataGridView3.DataSource = zTable.DefaultView;

                if (dataGridView3.Rows.Count != 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = NOTEBOOK; Initial Catalog = Заболевания; Integrated Security = True");
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        SqlCommand com1 = new SqlCommand(@"INSERT INTO B_C_V (Name_dis_c, S_1,S_2,S_3,S_4,S_5,S_6,S_7,S_8,S_9,S_10,S_11,S_12,S_13,S_14,S_15,S_16,S_17,S_18,S_19,S_20,S_21,S_22,S_23,S_24,S_25,S_26,S_27,S_28,S_29,S_30,S_31,S_32,S_33,S_34,S_35,S_36) VALUES ('" + dataGridView3.Rows[i].Cells[1].Value + "','" + dataGridView3.Rows[i].Cells[2].Value + "', '" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[6].Value + "','" + dataGridView3.Rows[i].Cells[7].Value + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "','" + dataGridView3.Rows[i].Cells[11].Value + "','" + dataGridView3.Rows[i].Cells[12].Value + "','" + dataGridView3.Rows[i].Cells[13].Value + "','" + dataGridView3.Rows[i].Cells[14].Value + "','" + dataGridView3.Rows[i].Cells[15].Value + "','" + dataGridView3.Rows[i].Cells[16].Value + "','" + dataGridView3.Rows[i].Cells[17].Value + "','" + dataGridView3.Rows[i].Cells[18].Value + "','" + dataGridView3.Rows[i].Cells[19].Value + "','" + dataGridView3.Rows[i].Cells[20].Value + "','" + dataGridView3.Rows[i].Cells[21].Value + "','" + dataGridView3.Rows[i].Cells[22].Value + "','" + dataGridView3.Rows[i].Cells[23].Value + "','" + dataGridView3.Rows[i].Cells[24].Value + "','" + dataGridView3.Rows[i].Cells[25].Value + "','" + dataGridView3.Rows[i].Cells[26].Value + "','" + dataGridView3.Rows[i].Cells[27].Value + "','" + dataGridView3.Rows[i].Cells[28].Value + "','" + dataGridView3.Rows[i].Cells[29].Value + "','" + dataGridView3.Rows[i].Cells[30].Value + "','" + dataGridView3.Rows[i].Cells[31].Value + "','" + dataGridView3.Rows[i].Cells[32].Value + "','" + dataGridView3.Rows[i].Cells[33].Value + "','" + dataGridView3.Rows[i].Cells[34].Value + "','" + dataGridView3.Rows[i].Cells[35].Value + "','" + dataGridView3.Rows[i].Cells[36].Value + "', '" + dataGridView3.Rows[i].Cells[37].Value + "')", con);
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    dataGridView3.DataSource = null;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




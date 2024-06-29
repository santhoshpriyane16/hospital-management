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

namespace hospital_management_project
{
    public partial class Adminaddstaff : Form
    {
        public Adminaddstaff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Adminaddstaff_Load(object sender, EventArgs e)
        {
            try
            {
                //showing the data from User_table 
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                command.Connection = adminconn;
                command.CommandText = "select * from User_table";
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                // user_table.DataSource = ds.Tables[0];

                DataTable tempDT = new DataTable();
                tempDT = dt.DefaultView.ToTable(true, "userid", "Roles");
                //Now bind this to DataGridView
                user_table.DataSource = tempDT;
                adminconn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_lgsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true"))
                {
                    SqlDataReader reader = null;
                    SqlCommand command = new SqlCommand();
                    command.Connection = adminconn;
                    SqlParameter param = new SqlParameter("@reguid", SqlDbType.VarChar);
                    command.Parameters.Add(param).Value = txt_aduserid.Text;
                    command.CommandText = "select * from User_table where userid=@reguid";
                    command.CommandType = CommandType.Text;
                    adminconn.Open();
                    reader = command.ExecuteReader();
                    //checking userid already exists in database or not
                    if (reader.HasRows)
                    {

                        MessageBox.Show("Userid already exists");
                        txt_aduserid.Clear();
                        txt_adrole.ResetText();

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("adduserbyadmin_sp", adminconn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter param1 = new SqlParameter("@userid", SqlDbType.VarChar);
                        cmd.Parameters.Add(param1).Value = txt_aduserid.Text;

                        SqlParameter param2 = new SqlParameter("@role", SqlDbType.VarChar);
                        cmd.Parameters.Add(param2).Value = txt_adrole.Text;




                        MessageBox.Show("ADDED SUCCESSFULLY");

                        reader.Close();
                        // Adminpanel adminpanel = new Adminpanel();
                        //adminpanel.Show();
                        // this.Hide();
                        txt_aduserid.Clear();
                        txt_adrole.ResetText();
                        cmd.ExecuteNonQuery();
                        adminconn.Close();


                        ////updating the data from User_table
                        adminconn.Open();
                        user_table.DataSource = null;
                        user_table.Update();
                        user_table.Refresh();


                        //SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                        // SqlCommand command = new SqlCommand();

                        command.Connection = adminconn;
                        command.CommandText = "select * from User_table";
                        SqlDataAdapter DA = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        DA.Fill(dt);
                        // user_table.DataSource = ds.Tables[0];
                        // user_table.DataSource = dt.Tables[0];

                        DataTable tempDT = new DataTable();
                        tempDT = dt.DefaultView.ToTable(true, "userid", "Roles");
                        //Now bind this to DataGridView
                        user_table.DataSource = tempDT;

                        adminconn.Close();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_aslogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_asexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void user_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminpanel admin = new Adminpanel();
            admin.Show();
            this.Hide();
        }
    }
}

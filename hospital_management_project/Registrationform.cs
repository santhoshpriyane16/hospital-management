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
using System.Runtime.ExceptionServices;

namespace hospital_management_project
{

    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
        }
        public static string SetValueFortxt_reguid = "";
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_reguid_TextChanged(object sender, EventArgs e)
        {

        }

        public void btn_reguidsub_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                adminconn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                command.Connection = adminconn;
                SqlParameter param1 = new SqlParameter("@reguid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_reguid.Text;
                command.CommandText = "select * from User_table where userid=@reguid";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    //passing reguid to complete registration if user doesnt registered using password
                    SetValueFortxt_reguid = txt_reguid.Text;
                    //CHECKING WHETHER THE USER ALREADY REGISTERED//

                    command.Connection = adminconn;
                    SqlParameter param2 = new SqlParameter("@reguid", SqlDbType.VarChar);
                    command.Parameters.Add(param2).Value = txt_reguid.Text;
                    SqlDataAdapter da = new SqlDataAdapter("select upassword from User_table where userid='" + txt_reguid.Text + "'", adminconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string txt_pwd = dt.Rows[0]["upassword"].ToString();


                    if (txt_pwd == "")
                    {
                        compregistration compregistration = new compregistration();
                        compregistration.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User has already registered. please try logging in..");
                        txt_reguid.Clear();
                        Login login = new Login();
                        login.Show();
                        this.Hide();


                    }



                }
                else
                {
                    MessageBox.Show("User not found,RETRY or Please contact admin");
                    txt_reguid.Clear();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}


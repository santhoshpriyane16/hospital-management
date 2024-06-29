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
    public partial class compregistration : Form
    {
        public compregistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration_form register = new Registration_form();
            register.Show();
            this.Hide();
        }

        private void txt_reguid_TextChanged(object sender, EventArgs e)
        {

        }

        private void compregistration_Load(object sender, EventArgs e)
        {
            txt_reguid.Text = Registration_form.SetValueFortxt_reguid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                adminconn.Open();

                command.Connection = adminconn;
                SqlParameter param1 = new SqlParameter("@reguid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_reguid.Text;
                SqlParameter param2 = new SqlParameter("@usrpwd", SqlDbType.VarChar);
                command.Parameters.Add(param2).Value = txt_usrpwd.Text;
                if (txt_usrpwd.Text == txt_usrconpwd.Text)
                {
                    command.CommandText = "update User_table set upassword=@usrpwd where userid=@reguid";
                    command.CommandType = CommandType.Text;
                    MessageBox.Show("PASSWORD UPDATED SUCCESSFULLY. TRY LOG IN");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("'Password' and 'confirm password' must be same.");
                }

                string ConnString = (@"Data Source=.\; Initial Catalog=HMS; Integrated Security=true");

                // string cmdString = "select * from User_table where userid=@username";

                //checking and deleting whether the userid was found password change approved table
                //adminconn.Open();
                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataAdapter da = new SqlDataAdapter("select userid from tbl_passchangeapproved where userid='" + txt_reguid.Text + "'", adminconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    command.CommandText = "DELETE FROM tbl_passchangeapproved WHERE userid = @reguid";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    adminconn.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_usrpwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

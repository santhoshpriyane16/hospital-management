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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string SetValueFortxt_lguserid ="";
        public static string SetValueFortxt_lgrole ="";
        private void button1_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration_form Register = new Registration_form();
            Register.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adminpanel admin = new Adminpanel();
            admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subadmin staff = new Subadmin();
            staff.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Doctorspanel doctor = new Doctorspanel();
            doctor.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel_passchangerequesition.Hide();
            
        }

        private void btn_lgsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnString = (@"Data Source=.\; Initial Catalog=HMS; Integrated Security=true");

                // string cmdString = "select * from User_table where userid=@username";

                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataAdapter da = new SqlDataAdapter("select Roles from User_table where userid='" + txt_lguserid.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)

                {


                    SqlDataAdapter ds = new SqlDataAdapter("select Roles from User_table where userid='" + txt_lguserid.Text + "' and upassword='" + txt_lgpwd.Text + "'", conn);
                    DataTable dt1 = new DataTable();
                    ds.Fill(dt1);
                    if (dt1.Rows.Count == 1)
                    {
                        //passing userid to profile updation
                        SetValueFortxt_lguserid = txt_lguserid.Text;
                        //--
                        //passing role to panel
                        string txt_lgrole = dt.Rows[0]["Roles"].ToString();
                        SetValueFortxt_lgrole = txt_lgrole;
                        //--

                        //checking the roles and redirecting to the appropriate panel
                        switch (dt.Rows[0]["Roles"] as string)
                        {

                            case "ADMIN":
                                {
                                    Adminpanel adminpanel = new Adminpanel();
                                    adminpanel.Show();
                                    this.Hide();
                                    break;

                                }
                            case "SUBADMIN":
                                {
                                    Subadmin subadmin = new Subadmin();
                                    subadmin.Show();
                                    this.Hide();
                                    break;
                                }
                            case "DOCTOR":
                                {
                                    Doctorspanel doctorspanel = new Doctorspanel();
                                    doctorspanel.Show();
                                    this.Hide();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT PASSWORD or YOU HAVE TO COMPLETE YOUR REGISTRATION USING 'NEW REGISTRATION' PANEL");
                        txt_lguserid.Clear();
                        txt_lgpwd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                    txt_lguserid.Clear();
                    txt_lgpwd.Clear();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_passchangerequesition.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                //FORGOT PASSWORD
                //checking whether the user id exists in usertable or not
                string ConnString = (@"Data Source=.\; Initial Catalog=HMS; Integrated Security=true");
                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataAdapter da = new SqlDataAdapter("select * from User_table where userid='" + txt_passchrequid.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Open();
                if (dt.Rows.Count == 1)
                {
                    //checking whether the user already requested for password change and it is still in pending..
                    //MessageBox.Show("User found");
                    SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_passchangereq where userid='" + txt_passchrequid.Text + "'", conn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    //checking whether the userid in approved table
                    SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_passchangeapproved where userid='" + txt_passchrequid.Text + "'", conn);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    if (dt1.Rows.Count == 1)
                    {
                        MessageBox.Show("Your request is already in pending for admin's approval. Please contact admin");
                        txt_passchrequid.Clear();
                    }
                    else if (dt2.Rows.Count == 1)
                    {
                        MessageBox.Show("Your request has been approved by admin. please try to change password");
                        conn.Close();
                        txt_passchrequid.Clear();
                        panel_passchangerequesition.Hide();
                    }

                    else
                    {
                        SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                        SqlCommand command = new SqlCommand();
                        adminconn.Open();

                        command.Connection = adminconn;
                        SqlParameter param1 = new SqlParameter("@userid", SqlDbType.VarChar);
                        command.Parameters.Add(param1).Value = txt_passchrequid.Text;
                        command.CommandText = "insert into tbl_passchangereq (userid) values (@userid)";
                        command.CommandType = CommandType.Text;
                        MessageBox.Show("Your requisition for password change is submitted successfully for admin's approval");
                        command.ExecuteNonQuery();
                        txt_passchrequid.Clear();
                        panel_passchangerequesition.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("User not found");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_panpassreqcan_Click(object sender, EventArgs e)
        {
            panel_passchangerequesition.Hide();
        }

        private void btn_reqexit_Click(object sender, EventArgs e)
        {
            panel_passchangerequesition.Hide();
        }

        private void panel_passchangerequesition_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

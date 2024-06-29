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
    public partial class staff_profile : Form
    {
        public staff_profile()
        {
            InitializeComponent();
        }
        public static string SetValueFortxt_prouid = "";

        private void btn_reguidsub_Click(object sender, EventArgs e)
        {
            try
            {
                //checking whether userid exists or not and then panel1 OR panel2 will be visible.
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                adminconn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                command.Connection = adminconn;
                SqlParameter param1 = new SqlParameter("@reguid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_prouserid.Text;
                command.CommandText = "select * from User_table where userid=@reguid";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    SqlDataAdapter da = new SqlDataAdapter("select Roles from User_table where userid='" + txt_prouserid.Text + "'", adminconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string txt_userrole = dt.Rows[0]["Roles"].ToString();
                    ///
                    ///
                    //checking whether the userid is belongs to staff or doctor
                    if (txt_userrole == "STAFF")
                    {
                        SetValueFortxt_prouid = txt_prouserid.Text;
                        command.Connection = adminconn;
                        SqlParameter param2 = new SqlParameter("@prouid", SqlDbType.VarChar);
                        command.Parameters.Add(param2).Value = txt_prouserid.Text;
                        command.CommandText = "select * from staff_protable where userid=@prouid";
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            panel_staffproview.Visible = true;
                            panel_staffproview.Refresh();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("User profile needs to update ");
                            txt_prouserid.Clear();
                            panel_staffproview.Visible = false;

                        }
                    }

                    else if (txt_userrole == "ADMIN" || txt_userrole == "SUBADMIN")
                    {
                        MessageBox.Show("you are admin or subadmin");
                    }
                    else
                    {
                        MessageBox.Show("This is doctors user-id, so please visit doctors profile tab in the admin panel");

                        // SetValueFortxt_prouid = txt_prouserid.Text;
                        //command.Connection = adminconn;
                        // SqlParameter param3 = new SqlParameter("@prouid", SqlDbType.VarChar);
                        // command.Parameters.Add(param3).Value = txt_prouserid.Text;
                        // command.CommandText = "select * from staff_protable where userid=@prouid";
                        //command.CommandType = CommandType.Text;
                        //reader = command.ExecuteReader();
                        // if (reader.HasRows)
                        // {
                        //      reader.Close();
                        //      MessageBox.Show("User profile has already updated");
                        //      txt_prouserid.Clear();

                        //  }
                        //   else
                        //  {
                        //      panel_staffpro.Visible = true;
                        //  }

                    }
                    reader.Close();
                    command.ExecuteNonQuery();
                    //checking whether the user has the profile already or not//



                }


                else
                {
                    MessageBox.Show("User not found,RETRY or Please contact admin");
                    txt_prouserid.Clear();
                    panel_staffproview.Visible = false;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_backstfpro_Click(object sender, EventArgs e)
        {
            Adminpanel admin = new Adminpanel();
            admin.Show();
            this.Hide();
        }

        private void staff_profile_Load(object sender, EventArgs e)
        {
            panel_staffproview.Visible = false;
            panel_stfproeditandupd.Visible = false;
        }

        private void panel_staffproview_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                adminconn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                command.Connection = adminconn;
                SqlParameter param1 = new SqlParameter("@prouid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_prouserid.Text;
                command.CommandText = "select * from staff_protable where userid=@prouid";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlDataAdapter da = new SqlDataAdapter("select * from staff_protable where userid='" + txt_prouserid.Text + "'", adminconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txt_prouid.Text = staff_profile.SetValueFortxt_prouid;
                    txt_stfnameview.Text = dt.Rows[0]["name"].ToString();
                    txt_stffnameview.Text = dt.Rows[0]["fathername"].ToString();
                    txt_stfgenderview.Text = dt.Rows[0]["gender"].ToString();
                    txt_stfaddressview.Text = dt.Rows[0]["address"].ToString();
                    txt_stfphoneview.Text = dt.Rows[0]["phonenumber"].ToString();
                    txt_stfcategoryview.Text = dt.Rows[0]["category"].ToString();
                    txt_stfqualiview.Text = dt.Rows[0]["qualification"].ToString();
                    txt_stfjoindateview.Value = DateTime.Parse(dt.Rows[0]["dateofjoining"].ToString());

                    command.ExecuteNonQuery();
                    adminconn.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_stfprocan_Click(object sender, EventArgs e)
        {
            staff_profile stfpro = new staff_profile();
            stfpro.Show();
            this.Hide();
        }

        private void btn_stfproedit_Click(object sender, EventArgs e)
        {
            panel_staffproview.Visible = false;
            panel_stfproeditandupd.Visible = true;
        }

        private void btn_stfupdchange_Click(object sender, EventArgs e)
        {
            try
            {
                //edit and updates the changes to the database using stored procedure
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand cmd = new SqlCommand("sp_editstaffprofile", adminconn);
                adminconn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@userid", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_stfprouid.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_stfnameup.Text;
                SqlParameter param3 = new SqlParameter("@fathername", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = txt_stffnameup.Text;
                SqlParameter param4 = new SqlParameter("@gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_stfgenderup.Text;
                SqlParameter param5 = new SqlParameter("@address", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_stfaddressup.Text;
                SqlParameter param6 = new SqlParameter("@phonenumber", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_stfphoneup.Text;
                SqlParameter param7 = new SqlParameter("@category", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = txt_stfcategoryup.Text;
                SqlParameter param8 = new SqlParameter("@qualification", SqlDbType.VarChar);
                cmd.Parameters.Add(param8).Value = txt_stfqualificationup.Text;
                SqlParameter param9 = new SqlParameter("@date_stfeditdoj", SqlDbType.VarChar);
                cmd.Parameters.Add(param9).Value = date_stfdojup.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully for userid: " + txt_stfprouid.Text);
                staff_profile stfpro = new staff_profile();
                stfpro.Show();
                this.Hide();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void panel_stfproeditandupd_Paint(object sender, PaintEventArgs e)
        { 
            try
            {
                //fetching the data to appropriate fields 
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                adminconn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                command.Connection = adminconn;
                SqlParameter param1 = new SqlParameter("@prouid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_prouserid.Text;
                command.CommandText = "select * from staff_protable where userid=@prouid";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlDataAdapter da = new SqlDataAdapter("select * from staff_protable where userid='" + txt_prouserid.Text + "'", adminconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txt_stfprouid.Text = staff_profile.SetValueFortxt_prouid;
                    // txt_stfnameview.Text = dt.Rows[0]["name"].ToString();
                    // txt_stffnameview.Text = dt.Rows[0]["fathername"].ToString();
                    //  txt_stfgenderview.Text = dt.Rows[0]["gender"].ToString();
                    // txt_stfaddressview.Text = dt.Rows[0]["address"].ToString();
                    // txt_stfphoneview.Text = dt.Rows[0]["phonenumber"].ToString();
                    // txt_stfcategoryview.Text = dt.Rows[0]["category"].ToString();
                    //  txt_stfqualiview.Text = dt.Rows[0]["qualification"].ToString();
                    // txt_stfjoindateview.Value = DateTime.Parse(dt.Rows[0]["dateofjoining"].ToString());

                    command.ExecuteNonQuery();
                    adminconn.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_editcngcancel_Click(object sender, EventArgs e)
        {
            panel_stfproeditandupd.Hide();
        }
    }
}

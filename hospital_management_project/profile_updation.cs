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
    public partial class profile_updation : Form
    {
        public profile_updation()
        {
            InitializeComponent();
        }
        //global varaible to store the given userid and get it on the panel 1 profile edit.
        public static string SetValueFortxt_prouid = "";

        private void profile_updation_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel_staffpro.Visible = false;
            //accessing userid from login page
            //txt_prouserid.Text = Login.SetValueFortxt_lguserid;
            //--
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Adminpanel adminpanel = new Adminpanel();
            adminpanel.Show();
            this.Hide();
        }

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
                    if (txt_userrole == "DOCTOR")
                    {
                        SetValueFortxt_prouid = txt_prouserid.Text;
                        command.Connection = adminconn;
                        SqlParameter param2 = new SqlParameter("@prouid", SqlDbType.VarChar);
                        command.Parameters.Add(param2).Value = txt_prouserid.Text;
                        command.CommandText = "select * from docprofile where userid=@prouid";
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Close();
                            MessageBox.Show("User profile has already updated");
                            txt_prouserid.Clear();
                            panel1.Visible = false;
                        }
                        else
                        {
                            panel1.Visible = true;
                        }
                    }

                    else if (txt_userrole == "ADMIN" || txt_userrole == "SUBADMIN")
                    {
                        MessageBox.Show("you are admin or subadmin");
                    }
                    else
                    {

                        SetValueFortxt_prouid = txt_prouserid.Text;
                        command.Connection = adminconn;
                        SqlParameter param3 = new SqlParameter("@prouid", SqlDbType.VarChar);
                        command.Parameters.Add(param3).Value = txt_prouserid.Text;
                        command.CommandText = "select * from staff_protable where userid=@prouid";
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Close();
                            MessageBox.Show("User profile has already updated");
                            txt_prouserid.Clear();

                        }
                        else
                        {
                            panel_staffpro.Visible = true;
                        }

                    }
                    reader.Close();
                    command.ExecuteNonQuery();
                    //checking whether the user has the profile already or not//



                }


                else
                {
                    MessageBox.Show("User not found,RETRY or Please contact admin");
                    txt_prouserid.Clear();
                    panel1.Visible = false;
                    panel_staffpro.Visible = false;
                }
                //---
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txt_adprouid.Text = profile_updation.SetValueFortxt_prouid;
        }

        private void btn_lgsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //inserting data by admin to the database using stored procedure
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand cmd = new SqlCommand("adddoctorprofile_sp", adminconn);
                adminconn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@userid", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_adprouid.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_prodocname.Text;
                SqlParameter param3 = new SqlParameter("@fathername", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = txt_prodocfname.Text;
                SqlParameter param4 = new SqlParameter("@gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_prodocgender.Text;
                SqlParameter param5 = new SqlParameter("@address", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_prodocaddress.Text;
                SqlParameter param6 = new SqlParameter("@phonenumber", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_prodocphone.Text;
                SqlParameter param7 = new SqlParameter("@yearsofexperience", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = txt_prodocexp.Text;
                SqlParameter param8 = new SqlParameter("@dateofjoined", SqlDbType.VarChar);
                cmd.Parameters.Add(param8).Value = date_prodocjoined.Text;
                SqlParameter param9 = new SqlParameter("@specialisation", SqlDbType.VarChar);
                cmd.Parameters.Add(param9).Value = txt_prodocspecial.Text;

                MessageBox.Show("Profile updated successfully for userid: " + txt_adprouid.Text);
                profile_updation profile_Updation = new profile_updation();
                profile_Updation.Show();
                this.Hide();

                cmd.ExecuteNonQuery();
                adminconn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminpanel admin = new Adminpanel();
            admin.Show();
            this.Hide();
        }

        private void btn_stfprosub_Click(object sender, EventArgs e)
        {
            try
            {
                //adding staff data in staff profile table using stored procedure named staff_protable
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand cmd = new SqlCommand("dbo.addstaffprofile_sp", adminconn);
                adminconn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@userid", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_prouid.Text;
                SqlParameter param2 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_stfname.Text;
                SqlParameter param3 = new SqlParameter("@fathername", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = txt_stffname.Text;
                SqlParameter param4 = new SqlParameter("@gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_stfgender.Text;
                SqlParameter param5 = new SqlParameter("@address", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_stfaddress.Text;
                SqlParameter param6 = new SqlParameter("@phonenumber", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_stfphone.Text;
                SqlParameter param7 = new SqlParameter("@category", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = txt_stfcategory.Text;
                SqlParameter param8 = new SqlParameter("@qualification", SqlDbType.VarChar);
                cmd.Parameters.Add(param8).Value = txt_stfquali.Text;
                SqlParameter param9 = new SqlParameter("@dateofjoined", SqlDbType.VarChar);
                cmd.Parameters.Add(param9).Value = txt_stfjoindate.Text;

                MessageBox.Show("Profile updated successfully for userid: " + txt_adprouid.Text);
                profile_updation profile_Updation = new profile_updation();
                profile_Updation.Show();
                this.Hide();

                cmd.ExecuteNonQuery();
                adminconn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_stfphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prouid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel_staffpro_Paint(object sender, PaintEventArgs e)
        {
            txt_prouid.Text = profile_updation.SetValueFortxt_prouid;
        }

        private void btn_stfprocan_Click(object sender, EventArgs e)
        {
            Adminpanel adminpanel = new Adminpanel();
        }
    }
}

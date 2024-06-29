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
    public partial class docprofiletosubadmin : Form
    {
        public docprofiletosubadmin()
        {
            InitializeComponent();
        }
        public static string SetValueFortxt_prouid = "";

        private void panel_docpro1_Paint(object sender, PaintEventArgs e)
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
                command.CommandText = "select * from docprofile where userid=@prouid";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlDataAdapter da = new SqlDataAdapter("select * from docprofile where userid='" + txt_prouserid.Text + "'", adminconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txt_adprouid.Text = docprofiletosubadmin.SetValueFortxt_prouid;
                    txt_prodocname.Text = dt.Rows[0]["name"].ToString();
                    txt_prodocfname.Text = dt.Rows[0]["fathername"].ToString();
                    txt_prodocgender.Text = dt.Rows[0]["gender"].ToString();
                    txt_prodocaddress.Text = dt.Rows[0]["address"].ToString();
                    txt_prodocphone.Text = dt.Rows[0]["phonenumber"].ToString();
                    txt_prodocexp.Text = dt.Rows[0]["yearsofexperience"].ToString();
                    date_prodocjoined.Value = DateTime.Parse(dt.Rows[0]["dateofjoined"].ToString());
                    txt_prodocspecial.Text = dt.Rows[0]["specialisation"].ToString();
                    command.ExecuteNonQuery();
                    adminconn.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void docprofiletosubadmin_Load(object sender, EventArgs e)
        {
            panel_docpro1.Visible = false;
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
                            panel_docpro1.Visible = true;
                            panel_docpro1.Refresh();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("User profile needs to update ");
                            txt_prouserid.Clear();
                            panel_docpro1.Visible = false;

                        }
                    }

                    else if (txt_userrole == "ADMIN" || txt_userrole == "SUBADMIN")
                    {
                        MessageBox.Show("you are admin or subadmin");
                    }
                    else
                    {
                        MessageBox.Show("This is staff's user-id, so please visit staffs profile tab in the sub-admin panel");

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
                    panel_docpro1.Visible = false;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_docprotosubadback_Click(object sender, EventArgs e)
        {
            Subadmin subadmin = new Subadmin();
            subadmin.Show();
            this.Hide();
        }

        private void btn_docprotosubadexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

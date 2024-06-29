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
    public partial class Sabookappointment : Form
    {
        public Sabookappointment()
        {
            InitializeComponent();
        }
        public static string SetValueFortxt_category = "";
        public static string SetvalueFortxt_docidaptmt = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Staffbookappointment_Load(object sender, EventArgs e)
        {
           
           
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Subadmin subadmin = new Subadmin();
            subadmin.Show();
            this.Hide();
        }

        private void txt_aptmtdoccategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
    }

        private void btn_entcataptmtbook_Click(object sender, EventArgs e)
        {
            ///////sorting doctors list in combobox based on the category selected...
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                adminconn.Open();
                //SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                txt_appointmentdoc.Items.Clear();
                command.Connection = adminconn;
                //SqlParameter param1 = new SqlParameter("@category", SqlDbType.VarChar);
                //command.Parameters.Add(param1).Value = txt_aptmtdoccategory.Text;
                SetValueFortxt_category = txt_aptmtdoccategory.Text;
                SqlDataAdapter da = new SqlDataAdapter("select name from docprofile where specialisation ='" + SetValueFortxt_category + "'", adminconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //string docname = dt.Rows[0]["name"].ToString();
                //command.CommandText = "select name from docprofile where specialisation ='" + txt_aptmtdoccategory.Text +"'";
                //command = new SqlCommand(command.CommandText, adminconn);
                //command.CommandType = CommandType.Text;
                //reader = command.ExecuteReader();



                txt_appointmentdoc.Items.Add(dt.Rows[0]["name"].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("DOCTORS NOT FOUND ON THE SELECTED CATEGORY.");
            }
           
            


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_entdocsabookaptmt_Click(object sender, EventArgs e)
        {
            try
            {
                ////selecting doctor's userid based on the doctor's name selected


                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                adminconn.Open();
                //SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                // txt_aptmtdocuidclkentdoc.Text.Remove();
                command.Connection = adminconn;
                //SqlParameter param1 = new SqlParameter("@category", SqlDbType.VarChar);
                //command.Parameters.Add(param1).Value = txt_aptmtdoccategory.Text;
                SetvalueFortxt_docidaptmt = txt_appointmentdoc.Text;
                SqlDataAdapter da = new SqlDataAdapter("select userid from docprofile where name ='" + SetvalueFortxt_docidaptmt + "'", adminconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //string docname = dt.Rows[0]["name"].ToString();
                //command.CommandText = "select name from docprofile where specialisation ='" + txt_aptmtdoccategory.Text +"'";
                //command = new SqlCommand(command.CommandText, adminconn);
                //command.CommandType = CommandType.Text;
                //reader = command.ExecuteReader();



                txt_aptmtdocuidclkentdoc.Items.Add(dt.Rows[0]["userid"].ToString());
                //textBox1.Text=(dt.Rows[0]["userid"].ToString());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_reqaptmtsub_Click(object sender, EventArgs e)
        {
            try
            {
                //inserting data by admin to the database using stored procedure
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand cmd = new SqlCommand("sp_requestappointmentsubbysa", adminconn);
                adminconn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@patientname", SqlDbType.NVarChar);
                cmd.Parameters.Add(param1).Value = txt_apptname.Text;
                SqlParameter param2 = new SqlParameter("@husorfathername", SqlDbType.NVarChar);
                cmd.Parameters.Add(param2).Value = txt_aptmtfname.Text;
                SqlParameter param3 = new SqlParameter("@fatherorhusband", SqlDbType.NVarChar);
                cmd.Parameters.Add(param3).Value = txt_aptmtpatfaorhusslctbox.Text;
                SqlParameter param4 = new SqlParameter("@address", SqlDbType.NText);
                cmd.Parameters.Add(param4).Value = txt_aptmtaddress.Text;
                SqlParameter param5 = new SqlParameter("@phonenumber", SqlDbType.BigInt);
                cmd.Parameters.Add(param5).Value = txt_aptmtphone.Text;
                SqlParameter param6 = new SqlParameter("@doccategory", SqlDbType.NVarChar);
                cmd.Parameters.Add(param6).Value = txt_aptmtdoccategory.Text;
                SqlParameter param7 = new SqlParameter("@docname", SqlDbType.NVarChar);
                cmd.Parameters.Add(param7).Value = txt_appointmentdoc.Text;
                SqlParameter param8 = new SqlParameter("@docuserid", SqlDbType.NVarChar);
                cmd.Parameters.Add(param8).Value = txt_aptmtdocuidclkentdoc.Text;
                SqlParameter param9 = new SqlParameter("@appointmentdate", SqlDbType.Date);
                cmd.Parameters.Add(param9).Value = date_aptmtdate.Text;
                SqlParameter param10 = new SqlParameter("@appointmenttime", SqlDbType.Time);
                cmd.Parameters.Add(param10).Value = time_aptmttime.Text;
                SqlParameter param11 = new SqlParameter("@comment", SqlDbType.NText);
                cmd.Parameters.Add(param11).Value = txt_aptmtbookcomment.Text;

                MessageBox.Show("Appointment has been requested for patient : " + txt_apptname.Text + " " + txt_aptmtfname.Text);
                Sabookappointment sabookappointment = new Sabookappointment();
                sabookappointment.Show();
                this.Hide();

                cmd.ExecuteNonQuery();
                adminconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error occured.{0}", ex.Message);
            }
        }

        private void btn_saviewappointments_Click(object sender, EventArgs e)
        {
            appointmentsviewsa appointmentsviewsa = new appointmentsviewsa();
            appointmentsviewsa.Show();
        }
    }
}

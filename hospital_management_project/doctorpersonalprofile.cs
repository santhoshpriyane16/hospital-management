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
    public partial class doctorpersonalprofile : Form
    {
        public doctorpersonalprofile()
        {
            InitializeComponent();
        }

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
                command.Parameters.Add(param1).Value = Login.SetValueFortxt_lguserid;
                command.CommandText = "select * from docprofile where userid=@prouid";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlDataAdapter da = new SqlDataAdapter("select * from docprofile where userid='" + Login.SetValueFortxt_lguserid + "'", adminconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txt_adprouid.Text = Login.SetValueFortxt_lguserid;
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

        private void btn_doceprproexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_docperproback_Click(object sender, EventArgs e)
        {
            Doctorspanel doctorspanel = new Doctorspanel();
            doctorspanel.Show();
            this.Hide();
        }

        private void doctorpersonalprofile_Load(object sender, EventArgs e)
        {

        }
    }
}

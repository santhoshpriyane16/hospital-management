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
using System.Globalization;
namespace hospital_management_project
{
    public partial class appointmentsviewsa : Form
    {
        public appointmentsviewsa()
        {
            InitializeComponent();
        }

        private void appointmentsviewsa_Load(object sender, EventArgs e)
        {
            try
            {
                //showing the data from tbl_reqappointmentbook 
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                command.Connection = adminconn;
                command.CommandText = "select * from tbl_reqappointmentbook";
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                // user_table.DataSource = ds.Tables[0];

                DataTable tempDT = new DataTable();
                tempDT = dt.DefaultView.ToTable(true, "appointmentid", "patientname", "patientfaorhusname", "fatherorhusband", "address", "phonenumber", "doccategory", "docname", "docuserid", "appointmentdate", "appointmenttime", "comment");
                //Now bind this to DataGridView of subadmin's appointment view table
                view_appointmentstosa.DataSource = tempDT;
                adminconn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_asexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void view_appointmentstosa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //////showing extended data via double-click on the datagridview named view_appointmentstosa/////
                ///
                appointmentsextendedviewtosa extsaview = new appointmentsextendedviewtosa();
                extsaview.txt_saaptviewexaptid.Text = this.view_appointmentstosa.CurrentRow.Cells[0].Value.ToString();
                extsaview.txt_saaptviewexpname.Text = this.view_appointmentstosa.CurrentRow.Cells[1].Value.ToString();
                extsaview.txt_saaptviewexpfhname.Text = this.view_appointmentstosa.CurrentRow.Cells[2].Value.ToString();
                extsaview.txt_saaptviewexpforh.Text = this.view_appointmentstosa.CurrentRow.Cells[3].Value.ToString();
                extsaview.txt_saaptviewexptaddress.Text = this.view_appointmentstosa.CurrentRow.Cells[4].Value.ToString();
                extsaview.txt_saaptviewexphone.Text = this.view_appointmentstosa.CurrentRow.Cells[5].Value.ToString();
                extsaview.txt_saaptviewexdoccat.Text = this.view_appointmentstosa.CurrentRow.Cells[6].Value.ToString();
                extsaview.txt_saaptviewexdocname.Text = this.view_appointmentstosa.CurrentRow.Cells[7].Value.ToString();
                extsaview.txt_saaptviewexdocid.Text = this.view_appointmentstosa.CurrentRow.Cells[8].Value.ToString();
                //DateTime dateTime = DateTime.ParseExact(view_appointmentstosa.CurrentRow.Cells[8].Value.ToString(), "dd-mm-yyyy",CultureInfo.InvariantCulture);
                extsaview.date_saaptviewexaptdate.Text = this.view_appointmentstosa.CurrentRow.Cells[9].Value.ToString(); ;
                //DateTime Time = DateTime.ParseExact(view_appointmentstosa.CurrentRow.Cells[9].Value.ToString(), "hh:mi:ss", CultureInfo.InvariantCulture);
                extsaview.time_saaptviewexapttime.Text = this.view_appointmentstosa.CurrentRow.Cells[10].Value.ToString();
                extsaview.txt_saaptviewexcomment.Text = this.view_appointmentstosa.CurrentRow.Cells[11].Value.ToString();
                extsaview.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

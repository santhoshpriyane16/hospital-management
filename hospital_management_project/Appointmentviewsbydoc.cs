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
    public partial class Appointmentviewsbydoc : Form
    {
        public Appointmentviewsbydoc()
        {
            InitializeComponent();
        }

        private void Appointmentviewsbydoc_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                command.Connection = adminconn;
                command.CommandText = "select * from tbl_reqappointmentbook where docuserid ='" + Login.SetValueFortxt_lguserid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                // user_table.DataSource = ds.Tables[0];

                DataTable tempDT = new DataTable();
                tempDT = dt.DefaultView.ToTable(true, "appointmentid", "patientname", "patientfaorhusname", "fatherorhusband", "address", "phonenumber", "appointmentdate", "appointmenttime", "comment");
                //Now bind this to DataGridView of subadmin's appointment view table
                view_appointmentstodoc.DataSource = tempDT;
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

        private void view_appointmentstodoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //////showing extended data via double-click on the datagridview named view_appointmentstosa/////
                ///
                appointmentextendedviewtodoctor extdocview = new appointmentextendedviewtodoctor();
                extdocview.txt_docaptviewexaptid.Text = this.view_appointmentstodoc.CurrentRow.Cells[0].Value.ToString();
                extdocview.txt_docaptviewexpname.Text = this.view_appointmentstodoc.CurrentRow.Cells[1].Value.ToString();
                extdocview.txt_docaptviewexpfhname.Text = this.view_appointmentstodoc.CurrentRow.Cells[2].Value.ToString();
                extdocview.txt_docaptviewexpforh.Text = this.view_appointmentstodoc.CurrentRow.Cells[3].Value.ToString();
                extdocview.txt_docaptviewexptaddress.Text = this.view_appointmentstodoc.CurrentRow.Cells[4].Value.ToString();
                extdocview.txt_docaptviewexphone.Text = this.view_appointmentstodoc.CurrentRow.Cells[5].Value.ToString();

                //DateTime dateTime = DateTime.ParseExact(view_appointmentstosa.CurrentRow.Cells[8].Value.ToString(), "dd-mm-yyyy",CultureInfo.InvariantCulture);
                extdocview.date_docaptviewexaptdate.Text = this.view_appointmentstodoc.CurrentRow.Cells[6].Value.ToString(); ;
                //DateTime Time = DateTime.ParseExact(view_appointmentstosa.CurrentRow.Cells[9].Value.ToString(), "hh:mi:ss", CultureInfo.InvariantCulture);
                extdocview.time_docaptviewexapttime.Text = this.view_appointmentstodoc.CurrentRow.Cells[7].Value.ToString();
                extdocview.txt_docaptviewexcomment.Text = this.view_appointmentstodoc.CurrentRow.Cells[8].Value.ToString();
                extdocview.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}

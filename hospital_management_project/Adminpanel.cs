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
    public partial class Adminpanel : Form
    {
        public Adminpanel()
        {
            InitializeComponent();
        }
        public static string SetValueFortxt_passrequid = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_staffprofile_Click(object sender, EventArgs e)
        {
            staff_profile stfprofile = new staff_profile();
            stfprofile.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminaddstaff addstaff = new Adminaddstaff();
            addstaff.Show();
            this.Hide();
        }

        private void Adminpanel_Load(object sender, EventArgs e)
        {
            //cursor bm
            Bitmap bm = new Bitmap(new Bitmap("E:\\c# project/hospital_staff_management_project/hospital_management_project/Resources/steth_cursor.png"), 30,30);
            this.Cursor = new Cursor(bm.GetHicon());

            //accessing role from login
            txt_profname.Text = Login.SetValueFortxt_lgrole;
            txt_userid.Text = Login.SetValueFortxt_lguserid;
            pan_passchngreq.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctors_profile doctorprofile = new doctors_profile();
            doctorprofile.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_uptprodr_Click(object sender, EventArgs e)
        {
            profile_updation proup = new profile_updation();
            proup.Show();
            this.Hide();
        }

        private void btn_staffprofile_Click_1(object sender, EventArgs e)
        {
            staff_profile stfpro = new staff_profile();
            stfpro.Show();
            this.Hide();
        }

        private void txt_profname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan_passchngreq_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //showing the data from tbl_reqappointmentbook 
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                command.Connection = adminconn;
                command.CommandText = "select * from tbl_passchangereq";
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                // user_table.DataSource = ds.Tables[0];

                DataTable tempDT = new DataTable();
                tempDT = dt.DefaultView.ToTable(true, "userid");
                //Now bind this to DataGridView of subadmin's appointment view table
                gridview_passchngreq.DataSource = tempDT;
                adminconn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            //
            //foreach(DataRow row in dt.Rows)
            //{
            //  this.listView_passchangereq listView = new this.listView_passchangereq();
            //}
            //command.CommandText = "select * from tbl_passchangereq";
           // SqlConnectioncnn = new SqlConnection(con);
           // adminconn.Open();
           // SqlCommandcmd = new SqlCommand(sql, cnn);
            //SqlDataReader Reader = command.ExecuteReader();
            //listView1.Items.Clear();
           // while (Reader.Read())
          //  {
              //  ListViewItem lv = new ListViewItem(Reader.ToString());
              //  lv.SubItems.Add(Reader.GetString(0));
                
              //  listView1.Items.Add(lv);
            //}
            //Reader.Close();
            //adminconn.Close();
            //listView1.Show();
        }

        private void gridview_passchngreq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_passchangereq_Click(object sender, EventArgs e)
        {
            pan_passchngreq.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pan_passchngreq.Hide();
        }

        private void gridview_passchngreq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            requisitionextviewtoadmin reqchng = new requisitionextviewtoadmin();
            reqchng.txt_passchreqapuid.Text = this.gridview_passchngreq.CurrentRow.Cells[0].Value.ToString();
            reqchng.Show();
        }
    }
}

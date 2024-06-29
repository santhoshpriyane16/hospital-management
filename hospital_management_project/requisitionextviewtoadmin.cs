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
    public partial class requisitionextviewtoadmin : Form
    {
        public requisitionextviewtoadmin()
        {
            InitializeComponent();
        }

        private void btn_panapr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                command.Connection = adminconn;
                adminconn.Open();
                SqlParameter param1 = new SqlParameter("@uid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_passchreqapuid.Text;
                command.CommandText = "insert into tbl_passchangeapproved (userid) values (@uid)";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                adminconn.Close();
                adminconn.Open();
                command.CommandText = "DELETE FROM tbl_passchangereq WHERE userid = @uid";
                command.CommandType = CommandType.Text;
                MessageBox.Show("The password change requisition for userid:'" + txt_passchreqapuid.Text + "' has been approved'");
                command.ExecuteNonQuery();
                adminconn.Close();
                adminconn.Open();
                command.CommandText = "update User_table set upassword = NULL WHERE userid = @uid";
                command.CommandType = CommandType.Text;
                txt_passchreqapuid.Clear();
                Adminpanel adminpanel = new Adminpanel();
                adminpanel.gridview_passchngreq.Refresh();

                command.ExecuteNonQuery();
                adminconn.Close();
                this.Hide();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
           
        }

        private void btn_panrej_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection adminconn = new SqlConnection(@"Data Source =.\ ; Initial Catalog = HMS ; Integrated Security = true");
                SqlCommand command = new SqlCommand();
                command.Connection = adminconn;
                adminconn.Open();
                SqlParameter param1 = new SqlParameter("@uid", SqlDbType.VarChar);
                command.Parameters.Add(param1).Value = txt_passchreqapuid.Text;
                command.CommandText = "insert into tbl_passchangerejected (userid) values (@uid)";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                adminconn.Close();
                adminconn.Open();
                command.CommandText = "DELETE FROM tbl_passchangereq WHERE userid = @uid";
                command.CommandType = CommandType.Text;
                MessageBox.Show("The password change requisition for userid:'" + txt_passchreqapuid.Text + "' has been rejected'");
                command.ExecuteNonQuery();
                adminconn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void requisitionextviewtoadmin_Load(object sender, EventArgs e)
        {

        }
    }
}

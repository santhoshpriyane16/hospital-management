using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_project
{
    public partial class Subadmin : Form
    {
        public Subadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sabookappointment bookappointment = new Sabookappointment();
            bookappointment.Show();
            this.Hide();
        }

        private void Subadmin_Load(object sender, EventArgs e)
        {
            //accessing role from login
            txt_profname.Text = Login.SetValueFortxt_lgrole;

            txt_userid.Text = Login.SetValueFortxt_lguserid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_subaddocpro_Click(object sender, EventArgs e)
        {
            docprofiletosubadmin docprofiletosubadmin = new docprofiletosubadmin();
            docprofiletosubadmin.Show();
            this.Hide();
        }

        private void btn_subadstfpro_Click(object sender, EventArgs e)
        {
            staffprotosubadmin staffprotosubadmin = new staffprotosubadmin();
            staffprotosubadmin.Show();
            this.Hide();
        }
    }
}

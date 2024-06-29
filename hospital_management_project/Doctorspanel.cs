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
    public partial class Doctorspanel : Form
    {
        public Doctorspanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointmentviewsbydoc appointmentviewsbydoc = new Appointmentviewsbydoc();
            appointmentviewsbydoc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_uptprodr_Click(object sender, EventArgs e)
        {
            doctorpersonalprofile docperpro = new doctorpersonalprofile();
            docperpro.Show();
            this.Hide();
        }

        private void txt_profname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctorspanel_Load(object sender, EventArgs e)
        {
            //accessing role from login
            txt_profname.Text = Login.SetValueFortxt_lgrole;
            //accessing userid from login
            txt_userid.Text = Login.SetValueFortxt_lguserid;
        }
    }
}

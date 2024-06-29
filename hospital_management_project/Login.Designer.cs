namespace hospital_management_project
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_newuser = new System.Windows.Forms.Button();
            this.btn_lgsubmit = new System.Windows.Forms.Button();
            this.txt_lgpwd = new System.Windows.Forms.TextBox();
            this.txt_lguserid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.LinkLabel();
            this.panel_passchangerequesition = new System.Windows.Forms.Panel();
            this.btn_reqexit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_panpassreqcan = new System.Windows.Forms.Button();
            this.btn_panpasschreqsub = new System.Windows.Forms.Button();
            this.txt_passchrequid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_passchangerequesition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_newuser
            // 
            this.btn_newuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btn_newuser, "btn_newuser");
            this.btn_newuser.Name = "btn_newuser";
            this.btn_newuser.UseVisualStyleBackColor = false;
            this.btn_newuser.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_lgsubmit
            // 
            this.btn_lgsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_lgsubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lgsubmit.FlatAppearance.BorderSize = 10;
            this.btn_lgsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btn_lgsubmit, "btn_lgsubmit");
            this.btn_lgsubmit.Name = "btn_lgsubmit";
            this.btn_lgsubmit.UseCompatibleTextRendering = true;
            this.btn_lgsubmit.UseVisualStyleBackColor = false;
            this.btn_lgsubmit.Click += new System.EventHandler(this.btn_lgsubmit_Click);
            // 
            // txt_lgpwd
            // 
            resources.ApplyResources(this.txt_lgpwd, "txt_lgpwd");
            this.txt_lgpwd.Name = "txt_lgpwd";
            // 
            // txt_lguserid
            // 
            resources.ApplyResources(this.txt_lguserid, "txt_lguserid");
            this.txt_lguserid.Name = "txt_lguserid";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.ActiveLinkColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.password, "password");
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.password.LinkColor = System.Drawing.Color.Blue;
            this.password.Name = "password";
            this.password.TabStop = true;
            this.password.VisitedLinkColor = System.Drawing.Color.Blue;
            this.password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.password_LinkClicked);
            // 
            // panel_passchangerequesition
            // 
            this.panel_passchangerequesition.BackColor = System.Drawing.Color.Gray;
            this.panel_passchangerequesition.Controls.Add(this.btn_reqexit);
            this.panel_passchangerequesition.Controls.Add(this.label6);
            this.panel_passchangerequesition.Controls.Add(this.btn_panpassreqcan);
            this.panel_passchangerequesition.Controls.Add(this.btn_panpasschreqsub);
            this.panel_passchangerequesition.Controls.Add(this.txt_passchrequid);
            this.panel_passchangerequesition.Controls.Add(this.label5);
            resources.ApplyResources(this.panel_passchangerequesition, "panel_passchangerequesition");
            this.panel_passchangerequesition.Name = "panel_passchangerequesition";
            this.panel_passchangerequesition.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_passchangerequesition_Paint);
            // 
            // btn_reqexit
            // 
            this.btn_reqexit.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_reqexit, "btn_reqexit");
            this.btn_reqexit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reqexit.Name = "btn_reqexit";
            this.btn_reqexit.UseVisualStyleBackColor = false;
            this.btn_reqexit.Click += new System.EventHandler(this.btn_reqexit_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Name = "label6";
            // 
            // btn_panpassreqcan
            // 
            this.btn_panpassreqcan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btn_panpassreqcan, "btn_panpassreqcan");
            this.btn_panpassreqcan.Name = "btn_panpassreqcan";
            this.btn_panpassreqcan.UseVisualStyleBackColor = false;
            this.btn_panpassreqcan.Click += new System.EventHandler(this.btn_panpassreqcan_Click);
            // 
            // btn_panpasschreqsub
            // 
            this.btn_panpasschreqsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_panpasschreqsub.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_panpasschreqsub.FlatAppearance.BorderSize = 10;
            this.btn_panpasschreqsub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btn_panpasschreqsub, "btn_panpasschreqsub");
            this.btn_panpasschreqsub.Name = "btn_panpasschreqsub";
            this.btn_panpasschreqsub.UseCompatibleTextRendering = true;
            this.btn_panpasschreqsub.UseVisualStyleBackColor = false;
            this.btn_panpasschreqsub.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_passchrequid
            // 
            resources.ApplyResources(this.txt_passchrequid, "txt_passchrequid");
            this.txt_passchrequid.Name = "txt_passchrequid";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Name = "label5";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hospital_management_project.Properties.Resources.Suraksha_Hos;
            this.ControlBox = false;
            this.Controls.Add(this.panel_passchangerequesition);
            this.Controls.Add(this.password);
            this.Controls.Add(this.btn_newuser);
            this.Controls.Add(this.btn_lgsubmit);
            this.Controls.Add(this.txt_lgpwd);
            this.Controls.Add(this.txt_lguserid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_passchangerequesition.ResumeLayout(false);
            this.panel_passchangerequesition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newuser;
        private System.Windows.Forms.Button btn_lgsubmit;
        private System.Windows.Forms.TextBox txt_lgpwd;
        private System.Windows.Forms.TextBox txt_lguserid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel password;
        private System.Windows.Forms.Panel panel_passchangerequesition;
        private System.Windows.Forms.Button btn_panpasschreqsub;
        private System.Windows.Forms.TextBox txt_passchrequid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_panpassreqcan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reqexit;
    }
}


namespace hospital_management_project
{
    partial class Adminaddstaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_asexit = new System.Windows.Forms.Button();
            this.btn_aslogout = new System.Windows.Forms.Button();
            this.txt_aduserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adrole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_lgsubmit = new System.Windows.Forms.Button();
            this.user_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_asexit
            // 
            this.btn_asexit.BackColor = System.Drawing.Color.Red;
            this.btn_asexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_asexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_asexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_asexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asexit.Font = new System.Drawing.Font("Centaur", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_asexit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_asexit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_asexit.Location = new System.Drawing.Point(1288, 12);
            this.btn_asexit.Name = "btn_asexit";
            this.btn_asexit.Size = new System.Drawing.Size(54, 27);
            this.btn_asexit.TabIndex = 30;
            this.btn_asexit.Text = "X";
            this.btn_asexit.UseVisualStyleBackColor = false;
            this.btn_asexit.Click += new System.EventHandler(this.btn_asexit_Click);
            // 
            // btn_aslogout
            // 
            this.btn_aslogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_aslogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_aslogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_aslogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_aslogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aslogout.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aslogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_aslogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_aslogout.Location = new System.Drawing.Point(12, 12);
            this.btn_aslogout.Name = "btn_aslogout";
            this.btn_aslogout.Size = new System.Drawing.Size(87, 27);
            this.btn_aslogout.TabIndex = 36;
            this.btn_aslogout.Text = "logout";
            this.btn_aslogout.UseVisualStyleBackColor = false;
            this.btn_aslogout.Click += new System.EventHandler(this.btn_aslogout_Click);
            // 
            // txt_aduserid
            // 
            this.txt_aduserid.Location = new System.Drawing.Point(208, 208);
            this.txt_aduserid.Name = "txt_aduserid";
            this.txt_aduserid.Size = new System.Drawing.Size(181, 20);
            this.txt_aduserid.TabIndex = 37;
            this.txt_aduserid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "ADD STAFF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_adrole
            // 
            this.txt_adrole.FormattingEnabled = true;
            this.txt_adrole.Items.AddRange(new object[] {
            "SUB-ADMIN",
            "DOCTOR",
            "STAFF"});
            this.txt_adrole.Location = new System.Drawing.Point(208, 251);
            this.txt_adrole.Name = "txt_adrole";
            this.txt_adrole.Size = new System.Drawing.Size(180, 21);
            this.txt_adrole.TabIndex = 39;
            this.txt_adrole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "ENTER USERID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "ROLE";
            // 
            // btn_lgsubmit
            // 
            this.btn_lgsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_lgsubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lgsubmit.FlatAppearance.BorderSize = 10;
            this.btn_lgsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_lgsubmit.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic);
            this.btn_lgsubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_lgsubmit.Location = new System.Drawing.Point(250, 292);
            this.btn_lgsubmit.Name = "btn_lgsubmit";
            this.btn_lgsubmit.Padding = new System.Windows.Forms.Padding(4);
            this.btn_lgsubmit.Size = new System.Drawing.Size(87, 29);
            this.btn_lgsubmit.TabIndex = 41;
            this.btn_lgsubmit.Text = "Submit";
            this.btn_lgsubmit.UseCompatibleTextRendering = true;
            this.btn_lgsubmit.UseVisualStyleBackColor = false;
            this.btn_lgsubmit.Click += new System.EventHandler(this.btn_lgsubmit_Click);
            // 
            // user_table
            // 
            this.user_table.AllowUserToDeleteRows = false;
            this.user_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.user_table.DefaultCellStyle = dataGridViewCellStyle4;
            this.user_table.Location = new System.Drawing.Point(510, 101);
            this.user_table.Name = "user_table";
            this.user_table.ReadOnly = true;
            this.user_table.Size = new System.Drawing.Size(521, 433);
            this.user_table.TabIndex = 43;
            this.user_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_table_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 44;
            this.button1.Text = "< back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hospital_management_project.Properties.Resources.staffs;
            this.pictureBox1.Location = new System.Drawing.Point(142, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(546, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 37);
            this.label2.TabIndex = 45;
            this.label2.Text = "Suraksha Hospital";
            // 
            // Adminaddstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_table);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_lgsubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adrole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_aduserid);
            this.Controls.Add(this.btn_aslogout);
            this.Controls.Add(this.btn_asexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminaddstaff";
            this.Text = "Adminaddstaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Adminaddstaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_asexit;
        private System.Windows.Forms.Button btn_aslogout;
        private System.Windows.Forms.TextBox txt_aduserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_adrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_lgsubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView user_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
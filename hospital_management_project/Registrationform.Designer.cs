namespace hospital_management_project
{
    partial class Registration_form
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
            this.Register = new System.Windows.Forms.Label();
            this.txt_reguid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_reguidsub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Register.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic);
            this.Register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Register.Location = new System.Drawing.Point(1055, 67);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(253, 29);
            this.Register.TabIndex = 12;
            this.Register.Text = "New Registeration";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // txt_reguid
            // 
            this.txt_reguid.Location = new System.Drawing.Point(1109, 124);
            this.txt_reguid.Name = "txt_reguid";
            this.txt_reguid.Size = new System.Drawing.Size(181, 20);
            this.txt_reguid.TabIndex = 18;
            this.txt_reguid.TextChanged += new System.EventHandler(this.txt_reguid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1050, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "UserId";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Centaur", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1320, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reguidsub
            // 
            this.btn_reguidsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_reguidsub.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reguidsub.FlatAppearance.BorderSize = 10;
            this.btn_reguidsub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_reguidsub.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic);
            this.btn_reguidsub.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_reguidsub.Location = new System.Drawing.Point(1155, 161);
            this.btn_reguidsub.Name = "btn_reguidsub";
            this.btn_reguidsub.Padding = new System.Windows.Forms.Padding(4);
            this.btn_reguidsub.Size = new System.Drawing.Size(87, 29);
            this.btn_reguidsub.TabIndex = 40;
            this.btn_reguidsub.Text = "Submit";
            this.btn_reguidsub.UseCompatibleTextRendering = true;
            this.btn_reguidsub.UseVisualStyleBackColor = false;
            this.btn_reguidsub.Click += new System.EventHandler(this.btn_reguidsub_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic);
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(12, 67);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3);
            this.button3.Size = new System.Drawing.Size(88, 29);
            this.button3.TabIndex = 41;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(504, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(353, 35);
            this.label20.TabIndex = 70;
            this.label20.Text = "Suraksha Hospital";
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 600);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_reguidsub);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_reguid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration_form";
            this.Text = "Registration_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registration_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.TextBox txt_reguid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_reguidsub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label20;
    }
}
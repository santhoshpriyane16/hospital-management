namespace hospital_management_project
{
    partial class requisitionextviewtoadmin
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
            this.btn_panrej = new System.Windows.Forms.Button();
            this.btn_panapr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_passchreqapuid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_panrej
            // 
            this.btn_panrej.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_panrej.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic);
            this.btn_panrej.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_panrej.Location = new System.Drawing.Point(381, 114);
            this.btn_panrej.Name = "btn_panrej";
            this.btn_panrej.Padding = new System.Windows.Forms.Padding(3);
            this.btn_panrej.Size = new System.Drawing.Size(88, 29);
            this.btn_panrej.TabIndex = 23;
            this.btn_panrej.Text = "Reject";
            this.btn_panrej.UseVisualStyleBackColor = false;
            this.btn_panrej.Click += new System.EventHandler(this.btn_panrej_Click);
            // 
            // btn_panapr
            // 
            this.btn_panapr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_panapr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_panapr.FlatAppearance.BorderSize = 10;
            this.btn_panapr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_panapr.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Italic);
            this.btn_panapr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_panapr.Location = new System.Drawing.Point(289, 114);
            this.btn_panapr.Name = "btn_panapr";
            this.btn_panapr.Padding = new System.Windows.Forms.Padding(4);
            this.btn_panapr.Size = new System.Drawing.Size(87, 29);
            this.btn_panapr.TabIndex = 22;
            this.btn_panapr.Text = "Approve";
            this.btn_panapr.UseCompatibleTextRendering = true;
            this.btn_panapr.UseVisualStyleBackColor = false;
            this.btn_panapr.Click += new System.EventHandler(this.btn_panapr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(231, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Userid";
            // 
            // txt_passchreqapuid
            // 
            this.txt_passchreqapuid.Location = new System.Drawing.Point(289, 66);
            this.txt_passchreqapuid.Name = "txt_passchreqapuid";
            this.txt_passchreqapuid.Size = new System.Drawing.Size(181, 20);
            this.txt_passchreqapuid.TabIndex = 20;
            // 
            // requisitionextviewtoadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(761, 209);
            this.Controls.Add(this.btn_panrej);
            this.Controls.Add(this.btn_panapr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_passchreqapuid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "requisitionextviewtoadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "requisitionextviewtoadmin";
            this.Load += new System.EventHandler(this.requisitionextviewtoadmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_panrej;
        private System.Windows.Forms.Button btn_panapr;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_passchreqapuid;
    }
}
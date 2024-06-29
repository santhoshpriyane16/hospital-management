namespace hospital_management_project
{
    partial class appointmentsviewsa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_asexit = new System.Windows.Forms.Button();
            this.view_appointmentstosa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_appointmentstosa)).BeginInit();
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
            this.btn_asexit.Location = new System.Drawing.Point(1272, 12);
            this.btn_asexit.Name = "btn_asexit";
            this.btn_asexit.Size = new System.Drawing.Size(54, 27);
            this.btn_asexit.TabIndex = 31;
            this.btn_asexit.Text = "X";
            this.btn_asexit.UseVisualStyleBackColor = false;
            this.btn_asexit.Click += new System.EventHandler(this.btn_asexit_Click);
            // 
            // view_appointmentstosa
            // 
            this.view_appointmentstosa.AllowUserToDeleteRows = false;
            this.view_appointmentstosa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_appointmentstosa.BackgroundColor = System.Drawing.Color.White;
            this.view_appointmentstosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.view_appointmentstosa.DefaultCellStyle = dataGridViewCellStyle1;
            this.view_appointmentstosa.Location = new System.Drawing.Point(65, 85);
            this.view_appointmentstosa.Name = "view_appointmentstosa";
            this.view_appointmentstosa.ReadOnly = true;
            this.view_appointmentstosa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_appointmentstosa.Size = new System.Drawing.Size(1199, 458);
            this.view_appointmentstosa.TabIndex = 44;
            this.view_appointmentstosa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_appointmentstosa_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 40);
            this.label1.TabIndex = 45;
            this.label1.Text = "APPOINTMENTS";
            // 
            // appointmentsviewsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_appointmentstosa);
            this.Controls.Add(this.btn_asexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appointmentsviewsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appointmentsviewsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.appointmentsviewsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_appointmentstosa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_asexit;
        private System.Windows.Forms.DataGridView view_appointmentstosa;
        private System.Windows.Forms.Label label1;
    }
}
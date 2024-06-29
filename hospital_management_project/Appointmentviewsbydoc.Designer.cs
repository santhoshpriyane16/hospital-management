namespace hospital_management_project
{
    partial class Appointmentviewsbydoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.view_appointmentstodoc = new System.Windows.Forms.DataGridView();
            this.btn_asexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_appointmentstodoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 40);
            this.label1.TabIndex = 48;
            this.label1.Text = "APPOINTMENTS";
            // 
            // view_appointmentstodoc
            // 
            this.view_appointmentstodoc.AllowUserToDeleteRows = false;
            this.view_appointmentstodoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_appointmentstodoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view_appointmentstodoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.view_appointmentstodoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.view_appointmentstodoc.Location = new System.Drawing.Point(38, 94);
            this.view_appointmentstodoc.Name = "view_appointmentstodoc";
            this.view_appointmentstodoc.ReadOnly = true;
            this.view_appointmentstodoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_appointmentstodoc.Size = new System.Drawing.Size(1199, 458);
            this.view_appointmentstodoc.TabIndex = 47;
            this.view_appointmentstodoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_appointmentstodoc_CellDoubleClick);
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
            this.btn_asexit.Location = new System.Drawing.Point(1256, 12);
            this.btn_asexit.Name = "btn_asexit";
            this.btn_asexit.Size = new System.Drawing.Size(54, 27);
            this.btn_asexit.TabIndex = 46;
            this.btn_asexit.Text = "X";
            this.btn_asexit.UseVisualStyleBackColor = false;
            this.btn_asexit.Click += new System.EventHandler(this.btn_asexit_Click);
            // 
            // Appointmentviewsbydoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_appointmentstodoc);
            this.Controls.Add(this.btn_asexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointmentviewsbydoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointmentviewsbydoc";
            this.Load += new System.EventHandler(this.Appointmentviewsbydoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_appointmentstodoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView view_appointmentstodoc;
        private System.Windows.Forms.Button btn_asexit;
    }
}
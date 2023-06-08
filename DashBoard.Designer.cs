namespace HospitalMangementSystem
{
    partial class DashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumOfAdmins = new System.Windows.Forms.Label();
            this.NumOfDoctors = new System.Windows.Forms.Label();
            this.NumOfUsers = new System.Windows.Forms.Label();
            this.NumOfPatients = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Controls.Add(this.NumOfAdmins);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Location = new System.Drawing.Point(75, 132);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 180);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of  \r\nAdmins:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.Controls.Add(this.NumOfDoctors);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.Color.Teal;
            this.guna2Panel2.Location = new System.Drawing.Point(447, 132);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(180, 180);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.NumOfUsers);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2Panel3.Location = new System.Drawing.Point(261, 221);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(180, 180);
            this.guna2Panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of  \r\nUsers:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.Controls.Add(this.NumOfPatients);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2Panel4.Location = new System.Drawing.Point(633, 221);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(180, 180);
            this.guna2Panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of  \r\nDoctors:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 60);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number Of  \r\nPatiens:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfAdmins
            // 
            this.NumOfAdmins.AutoSize = true;
            this.NumOfAdmins.BackColor = System.Drawing.Color.Transparent;
            this.NumOfAdmins.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.NumOfAdmins.Location = new System.Drawing.Point(77, 108);
            this.NumOfAdmins.Name = "NumOfAdmins";
            this.NumOfAdmins.Size = new System.Drawing.Size(22, 30);
            this.NumOfAdmins.TabIndex = 1;
            this.NumOfAdmins.Text = "?";
            this.NumOfAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfDoctors
            // 
            this.NumOfDoctors.AutoSize = true;
            this.NumOfDoctors.BackColor = System.Drawing.Color.Transparent;
            this.NumOfDoctors.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.NumOfDoctors.Location = new System.Drawing.Point(75, 108);
            this.NumOfDoctors.Name = "NumOfDoctors";
            this.NumOfDoctors.Size = new System.Drawing.Size(22, 30);
            this.NumOfDoctors.TabIndex = 2;
            this.NumOfDoctors.Text = "?";
            this.NumOfDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfUsers
            // 
            this.NumOfUsers.AutoSize = true;
            this.NumOfUsers.BackColor = System.Drawing.Color.Transparent;
            this.NumOfUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfUsers.ForeColor = System.Drawing.Color.Teal;
            this.NumOfUsers.Location = new System.Drawing.Point(74, 112);
            this.NumOfUsers.Name = "NumOfUsers";
            this.NumOfUsers.Size = new System.Drawing.Size(22, 30);
            this.NumOfUsers.TabIndex = 3;
            this.NumOfUsers.Text = "?";
            this.NumOfUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfPatients
            // 
            this.NumOfPatients.AutoSize = true;
            this.NumOfPatients.BackColor = System.Drawing.Color.Transparent;
            this.NumOfPatients.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfPatients.ForeColor = System.Drawing.Color.Teal;
            this.NumOfPatients.Location = new System.Drawing.Point(80, 112);
            this.NumOfPatients.Name = "NumOfPatients";
            this.NumOfPatients.Size = new System.Drawing.Size(22, 30);
            this.NumOfPatients.TabIndex = 4;
            this.NumOfPatients.Text = "?";
            this.NumOfPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(888, 524);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumOfAdmins;
        private System.Windows.Forms.Label NumOfDoctors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumOfUsers;
        private System.Windows.Forms.Label NumOfPatients;
        private System.Windows.Forms.Label label4;
    }
}

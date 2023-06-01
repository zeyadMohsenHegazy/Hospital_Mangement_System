namespace HospitalMangementSystem
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TapControlUser = new Guna.UI2.WinForms.Guna2TabControl();
            this.TapAddUser = new System.Windows.Forms.TabPage();
            this.t = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddDoctorTap = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UserNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddNewUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Role = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RoleList = new System.Windows.Forms.ListBox();
            this.TapControlUser.SuspendLayout();
            this.TapAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 2;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TapControlUser
            // 
            this.TapControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TapControlUser.Controls.Add(this.TapAddUser);
            this.TapControlUser.Controls.Add(this.AddDoctorTap);
            this.TapControlUser.Controls.Add(this.tabPage3);
            this.TapControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TapControlUser.ItemSize = new System.Drawing.Size(180, 40);
            this.TapControlUser.Location = new System.Drawing.Point(0, 0);
            this.TapControlUser.Name = "TapControlUser";
            this.TapControlUser.SelectedIndex = 0;
            this.TapControlUser.Size = new System.Drawing.Size(847, 464);
            this.TapControlUser.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TapControlUser.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TapControlUser.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TapControlUser.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TapControlUser.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TapControlUser.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TapControlUser.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TapControlUser.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TapControlUser.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TapControlUser.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TapControlUser.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TapControlUser.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TapControlUser.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TapControlUser.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TapControlUser.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TapControlUser.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TapControlUser.TabIndex = 0;
            this.TapControlUser.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.TapControlUser.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // TapAddUser
            // 
            this.TapAddUser.BackColor = System.Drawing.Color.White;
            this.TapAddUser.Controls.Add(this.RoleList);
            this.TapAddUser.Controls.Add(this.Role);
            this.TapAddUser.Controls.Add(this.AddNewUserBtn);
            this.TapAddUser.Controls.Add(this.PasswordTxt);
            this.TapAddUser.Controls.Add(this.UserNameTxt);
            this.TapAddUser.Controls.Add(this.guna2HtmlLabel2);
            this.TapAddUser.Controls.Add(this.t);
            this.TapAddUser.Controls.Add(this.guna2HtmlLabel1);
            this.TapAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TapAddUser.Location = new System.Drawing.Point(4, 4);
            this.TapAddUser.Name = "TapAddUser";
            this.TapAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.TapAddUser.Size = new System.Drawing.Size(839, 416);
            this.TapAddUser.TabIndex = 0;
            this.TapAddUser.Text = "Add new User";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.Transparent;
            this.t.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.t.Location = new System.Drawing.Point(111, 125);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(119, 26);
            this.t.TabIndex = 1;
            this.t.Text = "User Name:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(352, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 26);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Add User";
            // 
            // AddDoctorTap
            // 
            this.AddDoctorTap.Location = new System.Drawing.Point(4, 4);
            this.AddDoctorTap.Name = "AddDoctorTap";
            this.AddDoctorTap.Padding = new System.Windows.Forms.Padding(3);
            this.AddDoctorTap.Size = new System.Drawing.Size(839, 416);
            this.AddDoctorTap.TabIndex = 1;
            this.AddDoctorTap.Text = "Add new Doctor";
            this.AddDoctorTap.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(382, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(109, 26);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Password:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxt.DefaultText = "";
            this.UserNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxt.Location = new System.Drawing.Point(111, 157);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.PasswordChar = '\0';
            this.UserNameTxt.PlaceholderText = "";
            this.UserNameTxt.SelectedText = "";
            this.UserNameTxt.Size = new System.Drawing.Size(200, 36);
            this.UserNameTxt.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Location = new System.Drawing.Point(382, 157);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '\0';
            this.PasswordTxt.PlaceholderText = "";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.Size = new System.Drawing.Size(200, 36);
            this.PasswordTxt.TabIndex = 4;
            // 
            // AddNewUserBtn
            // 
            this.AddNewUserBtn.Animated = true;
            this.AddNewUserBtn.AutoRoundedCorners = true;
            this.AddNewUserBtn.BorderColor = System.Drawing.Color.White;
            this.AddNewUserBtn.BorderRadius = 5;
            this.AddNewUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddNewUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddNewUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddNewUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddNewUserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.AddNewUserBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddNewUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewUserBtn.Location = new System.Drawing.Point(111, 221);
            this.AddNewUserBtn.Name = "AddNewUserBtn";
            this.AddNewUserBtn.Size = new System.Drawing.Size(180, 45);
            this.AddNewUserBtn.TabIndex = 5;
            this.AddNewUserBtn.Text = "ADD";
            this.AddNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Role.Location = new System.Drawing.Point(616, 125);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(109, 26);
            this.Role.TabIndex = 6;
            this.Role.Text = "Password:";
            // 
            // RoleList
            // 
            this.RoleList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleList.FormattingEnabled = true;
            this.RoleList.ItemHeight = 22;
            this.RoleList.Items.AddRange(new object[] {
            "receptionist",
            "admin"});
            this.RoleList.Location = new System.Drawing.Point(616, 157);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(163, 26);
            this.RoleList.TabIndex = 7;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 464);
            this.ControlBox = false;
            this.Controls.Add(this.TapControlUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.TapControlUser.ResumeLayout(false);
            this.TapAddUser.ResumeLayout(false);
            this.TapAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TabControl TapControlUser;
        private System.Windows.Forms.TabPage TapAddUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel t;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TabPage AddDoctorTap;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Role;
        private Guna.UI2.WinForms.Guna2Button AddNewUserBtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox UserNameTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ListBox RoleList;
    }
}
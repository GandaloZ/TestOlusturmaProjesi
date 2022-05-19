namespace Test_Olusturma
{
    partial class LoginPage
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
            this.gb_admin = new System.Windows.Forms.GroupBox();
            this.chcb_showpswrd = new System.Windows.Forms.CheckBox();
            this.lb_pswrd = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_pswrd = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.bt_admin = new System.Windows.Forms.Button();
            this.gb_guest = new System.Windows.Forms.GroupBox();
            this.bt_guest = new System.Windows.Forms.Button();
            this.gb_admin.SuspendLayout();
            this.gb_guest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_admin
            // 
            this.gb_admin.Controls.Add(this.chcb_showpswrd);
            this.gb_admin.Controls.Add(this.lb_pswrd);
            this.gb_admin.Controls.Add(this.lb_name);
            this.gb_admin.Controls.Add(this.txt_pswrd);
            this.gb_admin.Controls.Add(this.txt_name);
            this.gb_admin.Controls.Add(this.bt_admin);
            this.gb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_admin.Location = new System.Drawing.Point(13, 13);
            this.gb_admin.Name = "gb_admin";
            this.gb_admin.Size = new System.Drawing.Size(314, 237);
            this.gb_admin.TabIndex = 0;
            this.gb_admin.TabStop = false;
            this.gb_admin.Text = "Admin Login:";
            // 
            // chcb_showpswrd
            // 
            this.chcb_showpswrd.AutoSize = true;
            this.chcb_showpswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcb_showpswrd.Location = new System.Drawing.Point(157, 147);
            this.chcb_showpswrd.Name = "chcb_showpswrd";
            this.chcb_showpswrd.Size = new System.Drawing.Size(114, 19);
            this.chcb_showpswrd.TabIndex = 5;
            this.chcb_showpswrd.Text = "Show Password";
            this.chcb_showpswrd.UseVisualStyleBackColor = true;
            this.chcb_showpswrd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_pswrd
            // 
            this.lb_pswrd.AutoSize = true;
            this.lb_pswrd.Location = new System.Drawing.Point(24, 116);
            this.lb_pswrd.Name = "lb_pswrd";
            this.lb_pswrd.Size = new System.Drawing.Size(82, 20);
            this.lb_pswrd.TabIndex = 4;
            this.lb_pswrd.Text = "Password:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(24, 52);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(55, 20);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name:";
            // 
            // txt_pswrd
            // 
            this.txt_pswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pswrd.Location = new System.Drawing.Point(147, 116);
            this.txt_pswrd.Name = "txt_pswrd";
            this.txt_pswrd.PasswordChar = '*';
            this.txt_pswrd.Size = new System.Drawing.Size(137, 23);
            this.txt_pswrd.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.Location = new System.Drawing.Point(147, 49);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(137, 23);
            this.txt_name.TabIndex = 1;
            // 
            // bt_admin
            // 
            this.bt_admin.Location = new System.Drawing.Point(49, 182);
            this.bt_admin.Name = "bt_admin";
            this.bt_admin.Size = new System.Drawing.Size(186, 34);
            this.bt_admin.TabIndex = 0;
            this.bt_admin.Text = "Login as Admin";
            this.bt_admin.UseVisualStyleBackColor = true;
            this.bt_admin.Click += new System.EventHandler(this.bt_admin_Click);
            // 
            // gb_guest
            // 
            this.gb_guest.Controls.Add(this.bt_guest);
            this.gb_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_guest.Location = new System.Drawing.Point(353, 13);
            this.gb_guest.Name = "gb_guest";
            this.gb_guest.Size = new System.Drawing.Size(200, 166);
            this.gb_guest.TabIndex = 1;
            this.gb_guest.TabStop = false;
            this.gb_guest.Text = "Guest:";
            // 
            // bt_guest
            // 
            this.bt_guest.Location = new System.Drawing.Point(33, 49);
            this.bt_guest.Name = "bt_guest";
            this.bt_guest.Size = new System.Drawing.Size(140, 67);
            this.bt_guest.TabIndex = 0;
            this.bt_guest.Text = "Login as Guest";
            this.bt_guest.UseVisualStyleBackColor = true;
            this.bt_guest.Click += new System.EventHandler(this.bt_guest_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.gb_guest);
            this.Controls.Add(this.gb_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.gb_admin.ResumeLayout(false);
            this.gb_admin.PerformLayout();
            this.gb_guest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_admin;
        private System.Windows.Forms.Button bt_admin;
        private System.Windows.Forms.GroupBox gb_guest;
        private System.Windows.Forms.Button bt_guest;
        private System.Windows.Forms.Label lb_pswrd;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_pswrd;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.CheckBox chcb_showpswrd;
    }
}


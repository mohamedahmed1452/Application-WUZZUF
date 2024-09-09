namespace WUZZUF
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lgin = new System.Windows.Forms.Button();
            this.gterCompany = new System.Windows.Forms.Button();
            this.gterUser = new System.Windows.Forms.Button();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.radCompany = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(156, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(156, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(190, 28);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // lgin
            // 
            this.lgin.BackColor = System.Drawing.Color.Transparent;
            this.lgin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgin.Location = new System.Drawing.Point(102, 306);
            this.lgin.Name = "lgin";
            this.lgin.Size = new System.Drawing.Size(177, 38);
            this.lgin.TabIndex = 5;
            this.lgin.Text = "Login";
            this.lgin.UseVisualStyleBackColor = false;
            this.lgin.Click += new System.EventHandler(this.lgin_Click);
            // 
            // gterCompany
            // 
            this.gterCompany.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gterCompany.Location = new System.Drawing.Point(296, 430);
            this.gterCompany.Name = "gterCompany";
            this.gterCompany.Size = new System.Drawing.Size(262, 38);
            this.gterCompany.TabIndex = 6;
            this.gterCompany.Text = "Register As Company";
            this.gterCompany.UseVisualStyleBackColor = true;
            this.gterCompany.Click += new System.EventHandler(this.gterCompany_Click);
            // 
            // gterUser
            // 
            this.gterUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gterUser.Location = new System.Drawing.Point(28, 430);
            this.gterUser.Name = "gterUser";
            this.gterUser.Size = new System.Drawing.Size(233, 38);
            this.gterUser.TabIndex = 7;
            this.gterUser.Text = "Register As User";
            this.gterUser.UseVisualStyleBackColor = true;
            this.gterUser.Click += new System.EventHandler(this.gterUser_Click);
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUser.ForeColor = System.Drawing.Color.Black;
            this.radUser.Location = new System.Drawing.Point(195, 130);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(96, 25);
            this.radUser.TabIndex = 0;
            this.radUser.TabStop = true;
            this.radUser.Text = "As User";
            this.radUser.UseVisualStyleBackColor = true;
            // 
            // radCompany
            // 
            this.radCompany.AutoSize = true;
            this.radCompany.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompany.ForeColor = System.Drawing.Color.Black;
            this.radCompany.Location = new System.Drawing.Point(195, 236);
            this.radCompany.Name = "radCompany";
            this.radCompany.Size = new System.Drawing.Size(137, 25);
            this.radCompany.TabIndex = 1;
            this.radCompany.TabStop = true;
            this.radCompany.Text = "As Company";
            this.radCompany.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.ForeColor = System.Drawing.Color.Black;
            this.radAdmin.Location = new System.Drawing.Point(195, 182);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(112, 25);
            this.radAdmin.TabIndex = 2;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "As Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(608, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(673, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 54);
            this.label4.TabIndex = 9;
            this.label4.Text = "In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(619, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 54);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wuzzuf";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WUZZUF.Properties.Resources.rsz_081958vxwgk2tbgtikbisx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radUser);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.gterUser);
            this.Controls.Add(this.gterCompany);
            this.Controls.Add(this.radCompany);
            this.Controls.Add(this.lgin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lgin;
        private System.Windows.Forms.Button gterCompany;
        private System.Windows.Forms.Button gterUser;
        private System.Windows.Forms.RadioButton radUser;
        private System.Windows.Forms.RadioButton radCompany;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


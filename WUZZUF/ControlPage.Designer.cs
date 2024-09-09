
namespace WUZZUF
{
    partial class ControlPage
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
            this.dGView = new System.Windows.Forms.DataGridView();
            this.radComp = new System.Windows.Forms.RadioButton();
            this.radUsers = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Label();
            this.sv = new System.Windows.Forms.Button();
            this.imageBack6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // dGView
            // 
            this.dGView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(14, 227);
            this.dGView.Name = "dGView";
            this.dGView.RowHeadersWidth = 51;
            this.dGView.RowTemplate.Height = 26;
            this.dGView.Size = new System.Drawing.Size(1053, 377);
            this.dGView.TabIndex = 0;
            // 
            // radComp
            // 
            this.radComp.AutoSize = true;
            this.radComp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radComp.ForeColor = System.Drawing.Color.White;
            this.radComp.Location = new System.Drawing.Point(577, 114);
            this.radComp.Name = "radComp";
            this.radComp.Size = new System.Drawing.Size(112, 25);
            this.radComp.TabIndex = 1;
            this.radComp.TabStop = true;
            this.radComp.Text = "Companies";
            this.radComp.UseVisualStyleBackColor = true;
            // 
            // radUsers
            // 
            this.radUsers.AutoSize = true;
            this.radUsers.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUsers.ForeColor = System.Drawing.Color.White;
            this.radUsers.Location = new System.Drawing.Point(389, 114);
            this.radUsers.Name = "radUsers";
            this.radUsers.Size = new System.Drawing.Size(73, 25);
            this.radUsers.TabIndex = 0;
            this.radUsers.TabStop = true;
            this.radUsers.Text = "Users";
            this.radUsers.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(427, 160);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(206, 38);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(478, 29);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(62, 21);
            this.admin.TabIndex = 3;
            this.admin.Text = "label1";
            // 
            // sv
            // 
            this.sv.Location = new System.Drawing.Point(465, 645);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(206, 42);
            this.sv.TabIndex = 4;
            this.sv.Text = "Save";
            this.sv.UseVisualStyleBackColor = true;
            this.sv.Click += new System.EventHandler(this.sv_Click);
            // 
            // imageBack6
            // 
            this.imageBack6.Image = global::WUZZUF.Properties.Resources.istockphoto_1271818873_612x612__2_;
            this.imageBack6.Location = new System.Drawing.Point(898, 12);
            this.imageBack6.Name = "imageBack6";
            this.imageBack6.Size = new System.Drawing.Size(168, 55);
            this.imageBack6.TabIndex = 37;
            this.imageBack6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imageBack6.UseVisualStyleBackColor = true;
            this.imageBack6.Click += new System.EventHandler(this.imageBack6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 57);
            this.label4.TabIndex = 43;
            this.label4.Text = "Wuzzuf";
            // 
            // ControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::WUZZUF.Properties.Resources.rsz_24k_black_wallpaper_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 722);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radComp);
            this.Controls.Add(this.imageBack6);
            this.Controls.Add(this.radUsers);
            this.Controls.Add(this.sv);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dGView);
            this.Name = "ControlPage";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.RadioButton radComp;
        private System.Windows.Forms.RadioButton radUsers;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button sv;
        private System.Windows.Forms.Button imageBack6;
        private System.Windows.Forms.Label label4;
    }
}
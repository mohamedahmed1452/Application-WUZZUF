
namespace WUZZUF
{
    partial class UserHomePage
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
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.generatebtn = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameUser = new System.Windows.Forms.Label();
            this.imageBack3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(766, 45);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(337, 22);
            this.searchbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(694, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "search";
            // 
            // searchbtn
            // 
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchbtn.Location = new System.Drawing.Point(608, 85);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(152, 35);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // generatebtn
            // 
            this.generatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generatebtn.Location = new System.Drawing.Point(820, 85);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(160, 35);
            this.generatebtn.TabIndex = 3;
            this.generatebtn.Text = "Country Report";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // generate
            // 
            this.generate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generate.Location = new System.Drawing.Point(1025, 85);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(176, 35);
            this.generate.TabIndex = 4;
            this.generate.Text = "Company Report";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(506, 133);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(930, 590);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 590);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // nameUser
            // 
            this.nameUser.AutoSize = true;
            this.nameUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameUser.Location = new System.Drawing.Point(378, 46);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(51, 21);
            this.nameUser.TabIndex = 7;
            this.nameUser.Text = "label";
            // 
            // imageBack3
            // 
            this.imageBack3.Image = global::WUZZUF.Properties.Resources.istockphoto_1271818873_612x612__2_;
            this.imageBack3.Location = new System.Drawing.Point(1323, 12);
            this.imageBack3.Name = "imageBack3";
            this.imageBack3.Size = new System.Drawing.Size(173, 55);
            this.imageBack3.TabIndex = 36;
            this.imageBack3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imageBack3.UseVisualStyleBackColor = true;
            this.imageBack3.Click += new System.EventHandler(this.imageBack3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 54);
            this.label2.TabIndex = 37;
            this.label2.Text = "Wuzzuf";
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WUZZUF.Properties.Resources.rsz_124k_black_wallpaper_141;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1510, 731);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageBack3);
            this.Controls.Add(this.nameUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbox);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "UserHomePage";
            this.Text = "User Home Page";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Button generate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.Button imageBack3;
        private System.Windows.Forms.Label label2;
    }
}





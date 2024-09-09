using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WUZZUF
{
    public partial class ViewJobD : Form
    {
        string ordb = "data source=orcl;user id=scott;password=tiger;";
        OracleConnection conn;
        int jobId;
        public ViewJobD(int id)
        {
            InitializeComponent();
            jobId = id;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(ordb);
            conn.Open();
           

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select * from JOBS,Companies where jobs.company_id=companies.id and JOBS.ID =:id";
            cmd.Parameters.Add("id", jobId);
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txtTitle.Text = dr[1].ToString();
                Country.Text = dr[2].ToString();
                txtSalary.Text = dr[3].ToString();
                txtPos.Text = dr[4].ToString();
                txtExp.Text = dr[5].ToString();
                txtdesc.Text = dr[7].ToString();
                txtCompName.Text = dr[11].ToString();
            }
  
            dr.Close();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void imageBack4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage frm6 = new UserHomePage(Login.Id_User);
            frm6.ShowDialog();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

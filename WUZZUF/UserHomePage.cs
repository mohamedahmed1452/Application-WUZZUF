using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WUZZUF
{
    public partial class UserHomePage : Form
    {
        String ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        CrystalReport1 CR;
        CrystalReport2 CR2;
        int idUser;
        public UserHomePage(int id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "SEARCH_HOME_PAGE";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("title", searchbox.Text);
            c.Parameters.Add("jobs",OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            CR = new CrystalReport1();
            CR2 = new CrystalReport2();




            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select * from Users where id=:id";
            cmd.Parameters.Add("id", idUser);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nameUser.Text = "Welcome "+dr[1].ToString();
            }
            dr.Close();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            nameUser.BackColor = Color.Transparent;

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, searchbox.Text);
            crystalReportViewer1.ReportSource = CR;
            
        }

        private void generate_Click(object sender, EventArgs e)
        {
            CR2.SetParameterValue(0, searchbox.Text);
            crystalReportViewer1.ReportSource = CR2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
       
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            // Extract the ID value from the selected row
            int id= Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
          
            // Create an instance of the target form
            // Pass the ID value to the other form
            this.Hide();
            ViewJobD frm5 = new ViewJobD(id);
            frm5.ShowDialog();
            Application.Exit();
        }

        private void imageBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
            Application.Exit();
        }
    }
}

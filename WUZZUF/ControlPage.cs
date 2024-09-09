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
    public partial class ControlPage : Form
    {
        string ordb = "data source=orcl;user id=scott;password=tiger;";
        OracleConnection conn;

        DataSet ds;
        int jobId;
        OracleDataAdapter adapter;
        public ControlPage(int id)
        {
            InitializeComponent();
            jobId = id;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select * from Admin where id=:id";
            cmd.Parameters.Add("id", jobId);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                admin.Text = "Hello Sir "+dr[1].ToString();
            }
            dr.Close();
            radUsers.BackColor = Color.Transparent;
            admin.BackColor = Color.Transparent;
            radComp.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



           string constr = "Data Source=orcl; User Id = scott; Password = tiger;";

           string cmdstr = "";

            if (radUsers.Checked)
            {
                cmdstr = "select * from Users";
            }
            else if (radComp.Checked)
            {
                cmdstr = "select * from Companies";
            }

             ds = new DataSet();

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.Fill(ds);
            dGView.DataSource = ds.Tables[0];


        }

        private void sv_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder =new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);


        }

        private void imageBack6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
            Application.Exit();
        }
    }
}

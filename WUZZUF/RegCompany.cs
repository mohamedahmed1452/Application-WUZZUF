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
    public partial class RegCompany : Form
    {
        int maxComID, newComID;
        string ordb = "data source=orcl;user id=scott;password=tiger;";
        OracleConnection conn;
        public RegCompany()
        {
            InitializeComponent();
        }

        private void svCompany_Click(object sender, EventArgs e)
        {

            if (cobUer.Text != "" && cobPass.Text != "" && cobName.Text != "")
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GETCOMPID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    maxComID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                    newComID = maxComID + 1;
                }
                catch
                {
                    newComID = 1;
                }




                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "INSERT_COMPANY";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("id", newComID);
                c.Parameters.Add("user_name", cobUer.Text);
                c.Parameters.Add("password", cobPass.Text);
                c.Parameters.Add("name", cobName.Text);
                c.Parameters.Add("description", cobDes.Text);
                c.Parameters.Add("logo", comLogo.Text);
                c.Parameters.Add("website", comWeb.Text);

                c.ExecuteNonQuery();
                MessageBox.Show("New company is added");
                cobUer.Text = "";
                cobPass.Text = "";
                cobName.Text = "";
                cobDes.Text = "";
                comLogo.Text = "";
                comWeb.Text = "";
            }
            else
            {
                MessageBox.Show("Please Fill All Mandatory Data involve {name,user_name,password}");
            }
        }

        private void imageBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
            Application.Exit();
        }

        private void cobUer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }
    }
}

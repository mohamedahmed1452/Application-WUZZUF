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
    public partial class RegUser : Form
    {
        int maxUserID=0, newUserID=0;
        string ordb = "data source=orcl;user id=scott;password=tiger;";
        OracleConnection conn;
        public RegUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;


        }

        private void imageBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
            Application.Exit();
        }

        private void svUser_Click(object sender, EventArgs e)
        {

            if (cobUFname.Text != "" && cobULname.Text != "" && cobUEmail.Text != "" && cobUpass.Text != "")
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GETID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    maxUserID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                    newUserID = maxUserID + 1;
                }
                catch
                {
                    newUserID = 1;
                }




                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "INSERT_USER";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("RID", newUserID);
                c.Parameters.Add("fname", cobUFname.Text);
                c.Parameters.Add("lname", cobULname.Text);
                c.Parameters.Add("email", cobUEmail.Text);
                c.Parameters.Add("pass", cobUpass.Text);
                c.Parameters.Add("phone_number", cobUphone.Text);
                c.Parameters.Add("locations", cobUloc.Text);
                c.Parameters.Add("education", cobUedu.Text);
                c.Parameters.Add("work_experience", cobUwork.Text);

                c.ExecuteNonQuery();
                MessageBox.Show("New User is added");
                cobUFname.Text = "";
                cobULname.Text = "";
                cobUpass.Text = "";
                cobUEmail.Text = "";
                cobUphone.Text = "";
                cobUloc.Text = "";
                cobUedu.Text = "";
                cobUwork.Text = "";
            }
            else
            {
                MessageBox.Show("Please Fill All Mandatory Data involve {First Name,Last Name,Email,Password}");
            }

        }
    }
}

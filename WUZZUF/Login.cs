using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace WUZZUF
{
 
    public partial class Login : Form
    {
        public static int Id_Company = 0;
        public static int Id_User = 0;
        public static int Id_Admin = 0;
        string ordb = "data source=orcl;user id=scott;password=tiger;";
        OracleConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            radUser.BackColor = Color.Transparent;
            radCompany.BackColor = Color.Transparent;
            radAdmin.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;

        }

        private void lgin_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (radUser.Checked)
            {
                cmd.CommandText = "SELECT * FROM users where email=:E and password=:P";
                cmd.Parameters.Add("E", txtName.Text);
                cmd.Parameters.Add("P", txtPass.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_User = Convert.ToInt32(dr[0].ToString());
                    this.Hide();
                    UserHomePage frm6 = new UserHomePage(Id_User);
                    frm6.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("wrong login as user try again");
                }

            }
            else if (radCompany.Checked)
            {
                cmd.CommandText = "SELECT * FROM companies where user_name=:E and password=:P";
                cmd.Parameters.Add("E", txtName.Text);
                cmd.Parameters.Add("P", txtPass.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_Company = Convert.ToInt32(dr[0].ToString());
                    this.Hide();
                    compHomePage frm4 = new compHomePage(Id_Company);
                    frm4.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("wrong login as company try again");
                }
            }
            else if (radAdmin.Checked)
            {


                cmd.CommandText = "SELECT * FROM Admin where email=:E and password=:P";
                cmd.Parameters.Add("E", txtName.Text);
                cmd.Parameters.Add("P", txtPass.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_Admin = Convert.ToInt32(dr[0].ToString());
                    this.Hide();
                    ControlPage frm7 = new ControlPage(Id_Admin);
                    frm7.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("wrong login as Admin try again");
                }


            }


        }

        private void gterUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegUser frm2= new RegUser();
            frm2.ShowDialog();
            Application.Exit();
        }

        private void gterCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegCompany frm3 = new RegCompany();
            frm3.ShowDialog();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

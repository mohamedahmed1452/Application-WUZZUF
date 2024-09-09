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
    public partial class compHomePage : Form
    {
        int maxJobID = 0, newJobID=0;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        int CompId;
        OracleConnection conn;
        public compHomePage(int id)
        {
            InitializeComponent();
            CompId = id;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select ID from JOBS ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cobJid.Items.Add(dr[0]);
            }
            dr.Close();





            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = " select * from Companies where id=:id";
            c.Parameters.Add("id", CompId);

            OracleDataReader dr2 = c.ExecuteReader();
            while (dr2.Read())
            {
                //CompName.Text = "Hello " + dr2[3].ToString();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {


            if (cobJid.Text != "")
            {

                OracleCommand C = new OracleCommand();
                C.Connection = conn;
                C.CommandText = "Delete from JOBS where ID =:id";
                C.CommandType = CommandType.Text;
                C.Parameters.Add("id", cobJid.Text);

                int r = C.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("remove job done successfully");
                    cobJid.Items.RemoveAt(cobJid.SelectedIndex);
                    txtTitle.Text = "";
                    txtDesc.Text = "";
                    txtCoun.Text = "";
                    txtSala.Text = "";
                    txtPos.Text = "";
                    txtExp.Text = "";
                }
            }
            else
            {
                MessageBox.Show("please select specific id");
            }
        }

        private void cobJid_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select * from JOBS where ID=:id";
            cmd.Parameters.Add("id", cobJid.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTitle.Text = dr[1].ToString();
                txtCoun.Text =  dr[2].ToString();
                txtSala.Text =  dr[3].ToString();
                txtPos.Text  =  dr[4].ToString();
                txtExp.Text  =  dr[5].ToString();
                txtDesc.Text = dr[6].ToString();
            }
            dr.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GETJOBIB";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                maxJobID = Convert.ToInt32(c.Parameters["id"].Value.ToString());
                newJobID = maxJobID + 1;
            }
            catch
            {
                newJobID = 1;
            }







            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into JOBS values(:id_job,:title,:Country,:Salary,:Position,:Exprience_level,:id_comp,:Description)";
            cmd.Parameters.Add("id_job", newJobID);
            cmd.Parameters.Add("title", txtTitle.Text);
            cmd.Parameters.Add("Country", txtCoun.Text);
            cmd.Parameters.Add("Salary", txtSala.Text);
            cmd.Parameters.Add("Position", txtPos.Text);
            cmd.Parameters.Add("Exprience_level", txtExp.Text);
            cmd.Parameters.Add("id_comp", CompId);
            cmd.Parameters.Add("Description", txtDesc.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cobJid.Items.Add(newJobID);
                MessageBox.Show("new jobs added successfully");

                cobJid.Text = "";
                txtTitle.Text = "";
                txtDesc.Text = "";
                txtCoun.Text = "";
                txtSala.Text = "";
                txtPos.Text = "";
                txtExp.Text = "";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class REGISTER : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1EUO5KU;Initial Catalog=demo_ado;Integrated Security=True;");
        public REGISTER()
        {
            InitializeComponent();
        }

        private void RFReEntrTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (RFPwdTxtBox.Text == RFReEntrTxtBox.Text)
            {
                RFcmprLbl.Visible = true;
                RFcmprLbl.Text = "Matching";
                RFcmprLbl.ForeColor = Color.Green;
            }
            else
            {

                RFcmprLbl.Visible = true;
                RFcmprLbl.Text = "Mis-Matching";
                RFcmprLbl.ForeColor = Color.Red;
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (RFUNmeTxtBox.Text != "" && RFPwdTxtBox.Text != "" && RFReEntrTxtBox.Text != "")
            {
                if (RFcmprLbl.Text == "Matching")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customer values('" + RFUNmeTxtBox.Text + "','" + RFPwdTxtBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("REGISTER SUCESSFUL");
                    LOGIN ln = new LOGIN();
                    ln.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INCORRECT PASSWORD");
                }
            }
        }

        private void RFUpdateBtn_Click(object sender, EventArgs e)
        {
            if (RFUNmeTxtBox.Text != "" && RFPwdTxtBox.Text != "" && RFReEntrTxtBox.Text != "")
            {
                if (RFcmprLbl.Text == "Matching")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Customer set UN='"+RFUNmeTxtBox.Text+"',Pwd='"+RFPwdTxtBox.Text+"' where CID="+RFCIDtxtBox.Text+" ",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("UPDATE SUCESSFUL");
                    LOGIN ln = new LOGIN();
                    ln.Show();
                    this.Hide();
                }
            }
        }

        private void RFdeleteBtn_Click(object sender, EventArgs e)
        {
            if (RFUNmeTxtBox.Text != "" && RFPwdTxtBox.Text != "" && RFReEntrTxtBox.Text != "")
            {
                if (RFcmprLbl.Text == "Matching")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from customer where CID="+RFCIDtxtBox.Text+" ",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("DELETED SUCESSFUL");
                    LOGIN ln = new LOGIN();
                    ln.Show();
                    this.Hide();
                }
            }
        }
    }
}

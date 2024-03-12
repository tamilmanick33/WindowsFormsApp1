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
    public partial class LOGIN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1EUO5KU;Initial Catalog=demo_ado;Integrated Security=True;");
        public LOGIN()
        {
            InitializeComponent();
        }

        private void SignUPLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTER reg = new REGISTER();
            reg.Show();
            this.Hide();
        }

        private void LOginbtn_Click(object sender, EventArgs e)
        {
            if(LFUNmeTxtBox.Text!=""&&LFPwdTxtBox.Text!="")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Customer where UN='" + LFUNmeTxtBox.Text+"' and Pwd='"+LFPwdTxtBox.Text+"'",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count>0)
                {
                    MessageBox.Show("LOGIN SUCESS");
                    LFUNmeTxtBox.Text = "";
                    LFPwdTxtBox.Text = "";
                }
                else
                {
                    MessageBox.Show("INVALID PASSWORD");
                }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER CORRECT DETAILS");
            }
        }
    }
}

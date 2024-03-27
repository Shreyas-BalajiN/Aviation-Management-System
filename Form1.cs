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
namespace Aviation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private string getUserName()
        {
            con.Open();
            string syntax = "SELECT value FROM System where property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;

        }
        private string getPassword()
        {
            con.Open();
            string syntax = "SELECT value FROM System where property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp= dr[0].ToString();
            con.Close();
            return temp;
        }


            private void button1_Click(object sender, EventArgs e)
        {
            String userid = getUserName(), password = getPassword(), uname, pwd;
            uname = textBox1.Text;
            pwd = textBox2.Text;
            if (uname.Equals(userid) && pwd.Equals(password))
            {
                
                appbody obj = new appbody();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("wrong credentials");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

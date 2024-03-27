using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aviation
{
    public partial class ticketsUserControl5 : UserControl
    {
        private static ticketsUserControl5 _instance;
        public static ticketsUserControl5 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ticketsUserControl5();
                }
                return _instance;
            }
        }
        public ticketsUserControl5()
        {
            InitializeComponent();
        }

        private void ticketsUserControl5_Load(object sender, EventArgs e)
        {

        }
        public string ticket_no;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public SqlCommand cmd;
        public SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string syntax = "SELECT ticket_no FROM Ticket where name='" + textBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label3.Text = ticket_no = dr[0].ToString();
            con.Close();
        }
    }
}

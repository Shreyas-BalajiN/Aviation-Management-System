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
    public partial class flight_UserControl2 : UserControl
    {
        private static flight_UserControl2 _instance;
        public static flight_UserControl2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new flight_UserControl2();
                }
                return _instance;
            }
        }
        public flight_UserControl2()
        {
            InitializeComponent();
        }

        public string status;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string syntax = "SELECT status FROM Flight where flight_no='" + textBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label2.Text = status = dr[0].ToString();
            con.Close();
        }

        private void flight_UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}

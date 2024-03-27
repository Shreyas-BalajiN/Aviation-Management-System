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
    public partial class passenger_UserControl1 : UserControl
    {
        private static passenger_UserControl1 _instance;
        public static passenger_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new passenger_UserControl1();
                }
                return _instance;
            }
        }
        public passenger_UserControl1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void refresh_datagridview()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Showpassengerdata_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("      <<INVALID SQL OPERATION>>:\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("PassengerAdd_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@passport_no",textBox3.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@gender", textBox5.Text);
            cmd.Parameters.AddWithValue("@age", textBox4.Text);
            cmd.Parameters.AddWithValue("@ticket_num", textBox6.Text);
            cmd.Parameters.AddWithValue("@flight_no", textBox7.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("      <<INVALID SQL OPERATION>>:\n" + ex);
            }
            con.Close();
            refresh_datagridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updatepass_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@passport_no", textBox3.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox4.Text);
            cmd.Parameters.AddWithValue("@gender", textBox5.Text);
            cmd.Parameters.AddWithValue("@ticket_num", textBox6.Text);
            cmd.Parameters.AddWithValue("@flight_no", textBox7.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("      <<INVALID SQL OPERATION>>:\n" + ex);
            }
            con.Close();
            refresh_datagridview();
        }

        private void passenger_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_datagridview();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DELETE_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deletepass_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<INVALID SQL OPERATION>>:\n" + ex);
                }
                con.Close();
                refresh_datagridview();

            }
            catch(Exception ex)
            {
                MessageBox.Show(" "+ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SEARCH_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchpass_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
               
                try
                {
                        cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<INVALID SQL OPERATION>>:\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string syntax = "SELECT TOP(1) message FROM messagetable order by 1 desc";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            MessageBox.Show(temp);
        }
    }
}

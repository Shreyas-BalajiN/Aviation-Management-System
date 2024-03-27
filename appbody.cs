using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Aviation
{
    public partial class appbody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public appbody()
        {
            InitializeComponent();
            isSlidingpanelexpanded = true;
            expandslidingpanelGUI();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void expandslidingpanelGUI()
        {
            passengerinfo_button.Text = "PASSENGER";
            flightinfo_button.Text = "FLIGHT";
            AandA_buttton.Text = "AIRPORT AND AIRLINES";
            about_button.Text = "ABOUT";
            slidingpanel_togglebutton.Text = "SLIDE";
            ticketinfo_button.Text = "TICKET INFO";
            slidingpanel_togglebutton.Image = Properties.Resources.icons8_double_left_24;
            passengerinfo_button.Image = null;
            flightinfo_button.Image = null;
            AandA_buttton.Image = null;
            about_button.Image = null;
            ticketinfo_button.Image = null;
        
        }

        public void retractlidingpanelGUI()
        {
            passengerinfo_button.Text = "";
            flightinfo_button.Text = "";
            AandA_buttton.Text = "";
            about_button.Text = "";
            ticketinfo_button.Text = "";
            slidingpanel_togglebutton.Image = Properties.Resources.icons8_double_right_24;
            passengerinfo_button.Image = Properties.Resources.icons8_user_30;
            flightinfo_button.Image = Properties.Resources.icons8_airplane_mode_on_24;
            AandA_buttton.Image = Properties.Resources.icons8_luggage_trolley_24;
            about_button.Image = Properties.Resources.icons8_about_24;
            ticketinfo_button.Image = Properties.Resources.icons8_two_tickets_241;

        }
        bool isSlidingpanelexpanded;
        const int maxsliderwidth = 180;
        const int minsliderwidth = 60;

        private void Slidingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void slidingpanel_togglebutton_Click(object sender, EventArgs e)
        {
            if (isSlidingpanelexpanded)
            {
                retractlidingpanelGUI();
            }
            slidingpanel_timer.Start();
        }

        private void slidingpanel_timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingpanelexpanded)
            {
                Slidingpanel.Width -= 30;
                if (Slidingpanel.Width <= minsliderwidth)
                {
                    isSlidingpanelexpanded = false;
                    slidingpanel_timer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                Slidingpanel.Width += 30;
                if (Slidingpanel.Width >= maxsliderwidth)
                {
                    isSlidingpanelexpanded = true;
                    slidingpanel_timer.Stop();
                    expandslidingpanelGUI();
                    this.Refresh();
                }
            }
        }

        private void appbody_Load(object sender, EventArgs e)
        {

        }

        private void passengerinfo_button_Click(object sender, EventArgs e)
        {
            if(!contentpanel.Controls.Contains(passenger_UserControl1.Instance))
            {

                contentpanel.Controls.Add(passenger_UserControl1.Instance);
                passenger_UserControl1.Instance.Dock = DockStyle.Fill;
                passenger_UserControl1.Instance.BringToFront();
            }
            else
            {
                passenger_UserControl1.Instance.BringToFront();
            }
        }

        private void flightinfo_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(flight_UserControl2.Instance))
            {

                contentpanel.Controls.Add(flight_UserControl2.Instance);
                flight_UserControl2.Instance.Dock = DockStyle.Fill;
                flight_UserControl2.Instance.BringToFront();
            }
            else
            {
                
                flight_UserControl2.Instance.BringToFront();
            }
        }

        private void settings_buttton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(settings_UserControl3.Instance))
            {

                contentpanel.Controls.Add(settings_UserControl3.Instance);
                settings_UserControl3.Instance.Dock = DockStyle.Fill;
                settings_UserControl3.Instance.BringToFront();
            }
            else
            {

                settings_UserControl3.Instance.BringToFront();
            }
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(aboutUserControl4.Instance))
            {

                contentpanel.Controls.Add(aboutUserControl4.Instance);
                aboutUserControl4.Instance.Dock = DockStyle.Fill;
                aboutUserControl4.Instance.BringToFront();
            }
            else
            {

                aboutUserControl4.Instance.BringToFront();
            }
        }

        private void ticketinfo_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(ticketsUserControl5.Instance))
            {

                contentpanel.Controls.Add(ticketsUserControl5.Instance);
                ticketsUserControl5.Instance.Dock = DockStyle.Fill;
                ticketsUserControl5.Instance.BringToFront();
            }
            else
            {

                ticketsUserControl5.Instance.BringToFront();
            }

        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

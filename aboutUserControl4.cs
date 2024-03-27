using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviation
{
    public partial class aboutUserControl4 : UserControl
    {
        private static aboutUserControl4 _instance;
        public static aboutUserControl4 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new aboutUserControl4();
                }
                return _instance;
            }
        }
        public aboutUserControl4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void aboutUserControl4_Load(object sender, EventArgs e)
        {

        }
    }
}

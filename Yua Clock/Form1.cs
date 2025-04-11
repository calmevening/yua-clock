using System;
using System.Windows.Forms;

namespace Yua_Clock
{
    public partial class frm_yua : Form
    {
        public frm_yua()
        {
            InitializeComponent();
        }

        private void tm_time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.TimeOfDay + " " + DateTime.Now.ToLongDateString();
            tm_time.Start();
        }


        private void frm_yua_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMOCSCourse2020WindowsFormsWinTimer1
{
    public partial class UserControl1Timer : UserControl
    {
        public UserControl1Timer()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //private void timer1_Tick_1(object sender, EventArgs e)
        // {

        // }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

        }
        public bool TimeEnabled
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }



        // public bool TimeEnabled
        // {
        //     get { return timer1.Enabled; }
        //    set { timer1.Enabled = value; }
        //}

        private void UserControl1Timer_Load(object sender, EventArgs e)
        {

        }
    }
}




    




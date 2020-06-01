using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2020WindowsFormsAppAlg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    a = Convert.ToInt32(Text); //замена консольного ввода
                    b = Convert.ToInt32(Text);
                    int c = a / b;
                }
                catch (Exception)
                {
                }
            }

        }






    }
}
}

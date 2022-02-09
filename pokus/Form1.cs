using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int box1 = Convert.ToInt32(textBox1.Text);
            int box2 = Convert.ToInt32(textBox2.Text);
            int soucet = box1 + box2;
            label1.Text = "soucet je "+ soucet;
            int odcitani = box1 - box2;
            label2.Text = "odecteni je " + odcitani;
        }
    }
}

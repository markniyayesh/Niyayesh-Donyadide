using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button x;
            x = (Button)sender;

            textBox1.Text +=x.Text;

           //textBox1.Text.Substring(0, 4);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           int x ="salam-khobi".IndexOf('-');
            string y = "jam".Substring(x+1, "jam".Length-x-1);
        }
    }
}

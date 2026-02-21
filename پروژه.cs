using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseEventArgs e;
            this.button5.MouseWheel += new MouseEventHandler(this.MouseWheel);
        }
        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            button5.Width += e.Delta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("loading...wait!");

        }

        // تعریف صحیح Delegate و Event
        public delegate void SampleEventHandler(int value);


        private void button1(object sender, EventArgs e)
        {
            MessageBox.Show("Please try again!");

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (m == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                 if (e is CancelEventArgs cancelEventArgs)
            {
                cancelEventArgs.Cancel = true;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "bee" && txt_pass.Text == "2099")
                MessageBox.Show("hello "+ txt_username.Text);
            else
                MessageBox.Show("Invalid Username or Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private new void MouseClick(object sender, MouseEventArgs e)
        {
                MessageBox.Show(e.X + " , " + e.Y);
            }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleanup_System_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel26.Visible = false;
        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel26.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel7.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel14.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel18.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel17.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel26.Visible = true;
        }
    }
}

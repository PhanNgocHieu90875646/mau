using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mau
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel4.Controls.Add(childform);
            panel4.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());

        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form9());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form8());
        }
    }
}

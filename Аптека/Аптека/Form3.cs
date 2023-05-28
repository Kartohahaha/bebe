using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аптека
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                Form4 frm = new Form4();
                frm.Show();
                this.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {

                Form2 frm = new Form2();
                frm.Show();
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                Form6 frm = new Form6();
                frm.Show();
                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {

                Form7 frm = new Form7();
                frm.Show();
                this.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {

                Form8 frm = new Form8();
                frm.Show();
                this.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {

                Form9 frm = new Form9();
                frm.Show();
                this.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {

                Form10 frm = new Form10();
                frm.Show();
                this.Close();

            }
        }
    }
}

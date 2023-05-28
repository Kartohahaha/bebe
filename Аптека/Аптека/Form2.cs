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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                Form3 frm = new Form3();
                frm.Show();
                this.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {

                Form5 frm = new Form5();
                frm.Show();
                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {

                Form11 frm = new Form11();
                frm.Show();
                this.Close();

            }
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Устинова Екатерина", "Автор");
        }
    }
}

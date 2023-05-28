namespace Аптека
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user1" && textBox2.Text == "12345")
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Неправильный логин или пароль");
            }

        }
    }
}
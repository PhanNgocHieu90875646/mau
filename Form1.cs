namespace mau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dd = new Form2();
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                if (textBox2.Text == "a" && textBox1.Text == "12")
                {
                    dd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai khoan ma ban nhap khong ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Moi ban nhap thong tin", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

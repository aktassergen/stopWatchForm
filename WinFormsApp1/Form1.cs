namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "0";
            timer1.Interval = 1000;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // x = Convert.ToInt32(textBox1.Text);
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            x = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            label2.Text = x.ToString();
        }




    }
}
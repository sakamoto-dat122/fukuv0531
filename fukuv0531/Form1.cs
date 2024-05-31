namespace fukuv0531
{
    public partial class Form1 : Form
    {
        int vy = 15;
        int vx = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vy = -15;
            timer1.Enabled = true;
            timer2.Enabled = false;
            label1.Text = "Å™";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
            timer1.Enabled = true;
            timer2.Enabled = false;
            label1.Text = "Å´";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = -15;
            timer1.Enabled = false;
            timer2.Enabled = true;
            label1.Text = "Å©";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 15;
            timer1.Enabled = false;
            timer2.Enabled = true;
            label1.Text = "Å®";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vy;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            label1.Text = "ç‚ñ{îéìl";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float fw = 3.14f;
            string str = $"{fw}";
            int a = (int)fw;
            //MessageBox.Show($"{a}");
            str = "3";
            a = int.Parse(str);
            fw = a;
            fw = float.Parse(str);
        }
    }
}
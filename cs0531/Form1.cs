namespace cs0531
{
    public partial class Form1 : Form
    {
        int vx, vy = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
                vx = 10;
            if (label1.Top < 0)
                vy = 10;
        }
    }
}
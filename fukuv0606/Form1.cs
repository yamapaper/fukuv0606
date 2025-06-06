namespace fukuv0606
{
    public partial class Form1 : Form
    {
        int vx = -4;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            if (label1.Left < 0)
            {
                vx = -vx;
                label1.Left = 0;
                label1.Left += vx;
            }
            else if (label1.Right > this.ClientSize.Width)
            {
                vx = -vx;
                label1.Left += vx;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "‚â‚Ü‚¾‚¯‚ñ‚½";
            timer1.Enabled = false;
        }
    }
}

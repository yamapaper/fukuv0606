namespace fukuv0606
{
    public partial class Form1 : Form
    {
        int vx = -4;
        int vy = -4;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            if (label1.Left < 0)
            {
                if(Math.Abs(vx) <= 30) { 
                    vx = -vx + 2;
                }
                
                label1.Left += vx;
            }
            else if (label1.Right > this.ClientSize.Width)
            {
                if (Math.Abs(vx) <= 30)
                {
                    vx = -vx - 2;
                }
                label1.Left += vx;
            }

            label1.Top += vy;
            if (label1.Top < 0)
            {
                if (Math.Abs(vy) <= 30)
                {
                    vy = -vy + 2;
                }
                label1.Top += vy;
            }
            else if (label1.Bottom > this.ClientSize.Height)
            {
                if (Math.Abs(vy) <= 30)
                {
                    vy = -vy - 2;
                }
                label1.Top += vy;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "‚â‚Ü‚¾‚¯‚ñ‚½";
            timer1.Enabled = false;
        }
    }
}

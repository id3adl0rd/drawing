namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;//Здесь рисуем
        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);

            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bmp)) {
                g.DrawLine(Pens.Black, 10, 10, 100, 100);
            }
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen p = new Pen(Color.Black);
                Rectangle rect = new Rectangle(50, 20, 200, 200);
                g.DrawPie(p, rect, -20, 60);
                g.DrawPie(p, rect, 60, 90);
                g.DrawPie(p, rect, 90, 130);
                g.DrawPie(p, rect, 150, 340);
            }
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawRectangle(Pens.Black, 30, 30, 50, 80);
            }
            pictureBox1.Image = bmp;
        }
    }
}
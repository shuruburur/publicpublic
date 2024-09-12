namespace Version_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = @"F:\загрузка (1).jfif";

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imagePath = @"F:\загрузка (2).jfif";

            if (File.Exists(imagePath))
            {
                pictureBox2.Image = Image.FromFile(imagePath);
            }
        }
    }
}

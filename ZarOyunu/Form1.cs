namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = true;

            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);

            toplamben = toplamben + a + b;

            label3.Text = a.ToString();
            label2.Text = b.ToString();

            label16.Text = toplamben.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-1.jpg";
            }
            else if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-2.png";
            }
            else if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-3.png";
            }
            else if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-4.jpg";
            }
            else if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-5.png";
            }
            else if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-6.png";
            }


            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-1.jpg";
            }
            else if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-2.png";
            }
            else if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-3.png";
            }
            else if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-4.jpg";
            }
            else if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-5.png";
            }
            else if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-6.png";
            }








        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            toplampc = toplampc + c + d;

            label10.Text = c.ToString();
            label11.Text = d.ToString();

            label17.Text = toplampc.ToString();

            if (c == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-1.jpg";
            }
            else if (c == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-2.png";
            }
            else if (c == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-3.png";
            }
            else if (c == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-4.jpg";
            }
            else if (c == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-5.png";
            }
            else if (c == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-6.png";
            }


            if (d == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-1.jpg";
            }
            else if (d == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-2.png";
            }
            else if (d == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-3.png";
            }
            else if (d == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-4.jpg";
            }
            else if (d == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-5.png";
            }
            else if (d == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\ATIF\\Downloads\\zar-6.png";
            }

            if (toplamben >= 100 && toplampc < 100)
            {
                MessageBox.Show("Birinci Oyuncu Kazandý!");

                label16.Text = "0";
                label17.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label10.Text = "0";
                label11.Text = "0";
                toplamben = 0;
                toplampc = 0;




            }

            else if (toplampc >= 100 && toplamben < 100)
            {

                MessageBox.Show("Bilgisayar Kazandý!");

                label16.Text = "0";
                label17.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label10.Text = "0";
                label11.Text = "0";
                toplamben = 0;
                toplampc = 0;

            }

            else if (toplamben >= 100 && toplampc >= 100)
            {
                MessageBox.Show("Berabere Bitti!");

                label16.Text = "0";
                label17.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label10.Text = "0";
                label11.Text = "0";
                toplampc = 0;



            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

    }
}
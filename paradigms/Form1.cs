namespace ForMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            int maxCount = Convert.ToInt32(textBox1.Text);
            int rows = Convert.ToInt32(textBox2.Text);

            byte[] masivi = new byte[rows];
            System.Random rand = new System.Random();
            rand.NextBytes(masivi);

            for (int i = 0; i < masivi.Length; i++)
            {
                label1.Text += masivi[i].ToString() + "\n";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sakitxi_2 obj = new sakitxi_2();
            int row = Convert.ToInt32(textBox3.Text);
            int col = Convert.ToInt32(textBox4.Text);

            label2.Text = obj.randomMatrix(row, col);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sakitxi_3 obj = new sakitxi_3();
            label3.Text = obj.function();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            fileStream4 obj = new fileStream4();
            obj.metodi5();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            exceptions obj = new exceptions();
            string message = label5.Text = "index is out of range";
            obj.gamonaklisi(message);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Memkvidre obj = new Memkvidre();
            int[,] metodi1 = new int[,]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15 },
                {16,17,18,19,20 }
            };
            label6.Text ="shedegi:"+obj.Metodi_1(metodi1);

        }
    }
}
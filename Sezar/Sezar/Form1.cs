using System.Text;

namespace Sezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray();
            StringBuilder sonuc = new StringBuilder();
            foreach (char eleman in karakterler)
            {
                sonuc.Append(Convert.ToChar(eleman + 3));
            }
            textBox2.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String veri = textBox2.Text;
            char[] karakterler = veri.ToCharArray();
            StringBuilder sonuc = new StringBuilder();

            foreach (char eleman in karakterler)
            {
                sonuc.Append(Convert.ToChar(eleman - 3));
            }

            textBox1.Text = sonuc.ToString();
        }
    }
}

namespace cemberpi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBoxr.Text);
                if ( r < 0)
                {
                    MessageBox.Show("Yarýçap negatif olamaz!");
                    return;
                }
                double alan = Math.PI * Math.Pow(r, 2);
                double cevre = Math.PI * 2 * r;

                labelalan.Text = $"Alan : {alan:F4}";
                labelcevre.Text = $"Çevre : {cevre:F4}";
            }
            catch (FormatException )
            {
                MessageBox.Show("Geçerli sayý girin!");
            }
        }
    }
}

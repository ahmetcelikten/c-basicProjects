namespace cember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double real1 = Convert.ToDouble(Real1.Text);
                double img1 = Convert.ToDouble(Img1.Text);
                double real2 = Convert.ToDouble(Real2.Text);
                double img2 = Convert.ToDouble(Img2.Text);

                double resultReal = (real1 * real2) - (img1 * img2);
                double resultImg = (real1 * img2) + (img1 * real2);

                label1.Text = $"Sonuç :   {resultReal} + {resultImg}i ";
            }
            catch (FormatException )
            {
                MessageBox.Show("Geçerli sayý girin! ");
            }
        }
    }
}

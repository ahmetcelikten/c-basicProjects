namespace Palindrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string text = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(text) )
            {
                MessageBox.Show("Kelime giriniz! ");
                return;
            }

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);

            if (reversedText.Equals(text, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Bu kelime Palindrom!");
                return;
            }
            else
            {
                MessageBox.Show("Bu kelime Palindrom deðil!");
                return;
            }

        }
    }
}

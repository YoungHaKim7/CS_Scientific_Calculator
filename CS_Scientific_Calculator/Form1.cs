namespace CS_Scientific_Calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;

                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;

                }
            }
        }
    }
}
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

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                default: break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 360; // 849
            txtResult.Width = 320;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360; // 849
            txtResult.Width = 320;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 715; // 849
            txtResult.Width = 660;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal = default;
            DialogResult = exitCal;

            exitCal = MessageBox.Show("Confirm if you want to exit",
                                      "Scientific Calculator",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
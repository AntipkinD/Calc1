namespace Calc1
{
    public partial class CalculatorBase : Form
    {
        public CalculatorBase()
        {
            InitializeComponent();
        }
        int c = 0;
        string history;
        decimal result;
        char something;
        List<string> histories = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void Kaknibud(char something)
        {
            if (textBox1.Enabled == false)
                textBox1.Text += something;
            if (textBox3.Enabled == false)
                textBox3.Text += something;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox3.Enabled = true;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "–";
            textBox3_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            textBox3_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = "/";
            textBox3_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            textBox3_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "√";
            textBox3.Text = textBox1.Text;
            textBox1.Text = null;
            textBox3_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "^";
            textBox3_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.something = '0';
            Kaknibud(this.something);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.something = '1';
            Kaknibud(this.something);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.something = '2';
            Kaknibud(this.something);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.something = '3';
            Kaknibud(this.something);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.something = '4';
            Kaknibud(this.something);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.something = '5';
            Kaknibud(this.something);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.something = '6';
            Kaknibud(this.something);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.something = '7';
            Kaknibud(this.something);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.something = '8';
            Kaknibud(this.something);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.something = '9';
            Kaknibud(this.something);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "sin";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "tg";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "cos";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            history = $"\n {textBox1.Text} {label1.Text} {textBox3.Text} {label3.Text} {textBox5.Text}";
            histories.Add(history);
            groupBox1.Text += histories[c];
            textBox3.Enabled = true;
            textBox1.Clear();
            label1.Text = " ";
            textBox3.Clear();
            result = 0;
            textBox5.Clear();
            textBox1.Enabled = false;
            textBox5.Enabled = true;
            textBox3.ReadOnly = false;
            c++;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorBase_Load(object sender, EventArgs e)
        {

        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatorBase_Load_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = false;

            switch (label1.Text)
            {
                case ("–"):
                    result = Convert.ToDecimal(double.Parse(textBox1.Text) - double.Parse(textBox3.Text));
                    break;
                case ("+"):
                    result = Convert.ToDecimal(double.Parse(textBox1.Text) + double.Parse(textBox3.Text));
                    break;
                case ("/"):
                    if (double.Parse(textBox3.Text) == 0) textBox5.Text = "Деление на ноль невозможно!";
                    else result = Convert.ToDecimal(double.Parse(textBox1.Text) / double.Parse(textBox3.Text));
                    break;
                case ("*"):
                    result = Convert.ToDecimal(double.Parse(textBox1.Text) * double.Parse(textBox3.Text));
                    break;
                case ("√"):
                    result = Convert.ToDecimal(Math.Sqrt(double.Parse(textBox3.Text)));
                    break;
                case ("^"):
                    result = Convert.ToDecimal(Math.Pow(double.Parse(textBox1.Text), double.Parse(textBox3.Text)));
                    break;
                case ("sin"):
                    result = Convert.ToDecimal(Math.Sin(double.Parse(textBox1.Text)));
                    break;
                case ("cos"):
                    result = Convert.ToDecimal(Math.Cos(double.Parse(textBox1.Text)));
                    break;
                case ("tg"):
                    result = Convert.ToDecimal(Math.Tan(double.Parse(textBox1.Text)));
                    break;
            }
            textBox5.Text = Convert.ToString(result);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == false)
                textBox1.Undo();
            if (textBox3.Enabled == false)
                textBox3.Undo();
        }
    }
}
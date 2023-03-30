namespace Calculadora_Botao_Unico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1 = 0;
        double valor2 = 0;
        string operador = "";

        private void btnunico_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void btnoperador_Click(object sender, EventArgs e)
        {
            Button btnop = (Button)sender;
            valor1 = double.Parse(textBox1.Text);
            operador = btnop.Text;
            textBox1.Text = "";
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            Calculadora calc = new Calculadora();
            switch (operador)
            {
                case "+": { textBox1.Text = calc.somar(valor1, valor2).ToString(); break; }
                case "-": { textBox1.Text = calc.subtrair(valor1, valor2).ToString(); break; }
                case "/": { textBox1.Text = calc.divisao(valor1, valor2).ToString(); break; }
                case "X": { textBox1.Text = calc.multiplicacao(valor1, valor2).ToString(); break; }
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor1 = 0;
            valor2 = 0;
        }
    }
}
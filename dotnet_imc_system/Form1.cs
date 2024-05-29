using System.Security.Cryptography.X509Certificates;
using System;
using System.IO;


namespace Calculo_de_imc
{
    public partial class Form1 : Form
    {
        double altura;
        double peso;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int idade;
            idade = textBox2.Text.GetHashCode();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            peso = float.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            altura = float.Parse(textBox4.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado = (peso / altura)*10;
            label7.Text = Math.Pow(resultado, 2).ToString();
            salvarArquivo();
        }

        public void salvarArquivo()
        {
            string[] dataToSave = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, label7.Text };

       

            // 3. Define the file path (replace with your desired path)
            string filePath = @"C:\Estudos\Calculo_de_imc";  // Replace with desired path

            try
            {
                // 4. Write the data to the file using File.WriteAllLines
                File.WriteAllLines(filePath, dataToSave);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro em salvar dados: " + ex.Message);
            }

        }
    }
}

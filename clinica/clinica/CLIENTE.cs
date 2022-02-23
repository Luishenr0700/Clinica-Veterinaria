using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica
{
    public partial class CLIENTE : Form
    {
        string nome, nome_pet, data, fone, tipo_pet;
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status1 = new Dictionary<string, string>();

            status1.Add("C", "Cachorro");
            status1.Add("G", "Gato");
            status1.Add("P", "Pássaro");
            status1.Add("O", "Outros");

            comboBox1.DataSource = new BindingSource(status1, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo;
            Random num = new Random();
           


            nome = textBox2.Text;
            fone = maskedTextBox1.Text;
            nome_pet = textBox4.Text;
            tipo_pet = comboBox1.Text;
            data = DateTime.Today.ToString("dd/MM/yyyy");

            if (nome == "" || fone == "" || nome_pet == "" || tipo_pet == "")
            {
                MessageBox.Show("Atenção! Preencha todos os campos.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                maskedTextBox2.Text = Convert.ToString(data);
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox4.Clear();


                codigo = num.Next(100, 500);
                textBox1.Text = Convert.ToString(codigo);

                textBox6.Text = Convert.ToString($"Cadastro feito com sucesso Sr(a) {nome}! \r\nSeu código: {codigo} \r\n\r\nConfirme Seus Dados \r\nData do cadastro: {data} \r\nNome do Pet: {nome_pet} / Tipo: {tipo_pet}\r\nContato: {fone}");

                button2.Enabled = true;
                button3.Enabled = true;

                MessageBox.Show($"Seu código é {codigo}. Guarde este código.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (nome == "" || fone == "" || nome_pet == "" || tipo_pet == "")
            {
                MessageBox.Show("Atenção! Preencha todos os campos.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox1.Clear();
            maskedTextBox2.Clear();
        }
    }
}

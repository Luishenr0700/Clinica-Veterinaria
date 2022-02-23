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
    public partial class CONSULTA : Form
    {
        public CONSULTA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker1.Text;
            comboBox1.Enabled = true;
            button3.Enabled = true;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button3.Enabled = false;
            
        }

        private void CONSULTA_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();

            status.Add("R", "Rotina");
            status.Add("V", "Vacinação");
            status.Add("C", "Complicações");
            status.Add("U", "Urgências");

            comboBox1.DataSource = new BindingSource(status, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Rotina")
            {
                textBox2.Text = "Dr. Fabio";
                textBox3.Text = "R$ 100,00";
            }
            else if (comboBox1.Text == "Vacinação")
            {
                textBox2.Text = "Dra. Letícia";
                textBox3.Text = "R$ 70,00 à R$ 150,00";
            }
            else if (comboBox1.Text == "Complicações")
            {
                textBox2.Text = "Dra. Simone";
                textBox3.Text = "R$ 100,00 à R$ 300,00";
            }
            else if (comboBox1.Text == "Urgências")
            {
                textBox2.Text = "Dra. Jessica";
                textBox3.Text = "Á combinar";
            }

            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cadastro Feito com Sucesso! \r\nData: {textBox4.Text} \r\nMédico: {textBox2.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            
        }
    }
}

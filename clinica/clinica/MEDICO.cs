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
    public partial class MEDICO : Form
    {
        public MEDICO()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MEDICO_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();

            status.Add("R", "Rotina");
            status.Add("V", "Vacinação");
            status.Add("C", "Complicações");
            status.Add("U", "Urgência");

            comboBox1.DataSource = new BindingSource(status, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            Dictionary<string, string> status1 = new Dictionary<string, string>();

            status1.Add("C", "Cachorro");
            status1.Add("G", "Gato");
            status1.Add("P", "Pássaro");
            status1.Add("O", "Outros");

            comboBox2.DataSource = new BindingSource(status1, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo_animal, nome_pet, nome_dono, tipo_consulta, nome_vet, data;

            tipo_animal = comboBox2.Text;
            nome_pet = textBox5.Text;
            nome_dono = textBox6.Text;
            tipo_consulta = comboBox1.Text;
            nome_vet = textBox2.Text;
            data = dateTimePicker1.Text;


            if (comboBox1.Text == "Rotina")
            {
                textBox2.Text = "Dr. Fabio";
                               
            }
            else if (comboBox1.Text == "Vacinação")
            {
                textBox2.Text = "Dra. Letícia";
                
            }
            else if (comboBox1.Text == "Complicações")
            {
                textBox2.Text = "Dra. Simone";
               
            }
            else if (comboBox1.Text == "Urgências")
            {
                textBox2.Text = "Dra. Jessica";
                
            }

            if (textBox1.Text == "" || nome_pet == "" || nome_dono == "")
            {
                MessageBox.Show("Atenção! Preencha todos os campos.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cadastro feito com Sucesso! Comfirme os dados.", "Comfirmado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox4.Text = Convert.ToString($"Cadastro feito com sucesso! \r\n\r\nData: {data} \r\nVeterinário: {textBox2.Text} " +
                    $"\r\nTipo de Anilmal: {tipo_animal} \r\nNome do Pet: {nome_pet} / Nome do Dono: {nome_dono} \r\nTipo de Consulta: {tipo_consulta}");
            }
           
        }

        private void Nome(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

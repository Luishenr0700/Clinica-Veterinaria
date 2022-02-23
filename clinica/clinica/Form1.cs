using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace clinica
{
    public partial class Form1 : Form
    {
        Thread nf_c, nf_a, nf_co, nf_m;

        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            nf_c = new Thread(novoform_c);
            nf_c.SetApartmentState(ApartmentState.STA);
            nf_c.Start();

        }

        private void novoform_c()
        {
            Application.Run(new CLIENTE());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nf_a = new Thread(novoform_a);
            nf_a.SetApartmentState(ApartmentState.STA);
            nf_a.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            nf_m = new Thread(novoform_m);
            nf_m.SetApartmentState(ApartmentState.STA);
            nf_m.Start();
        }

        private void novoform_m()
        {
            Application.Run(new MEDICO());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            nf_co = new Thread(novoform_co);
            nf_co.SetApartmentState(ApartmentState.STA);
            nf_co.Start();
        }

        private void novoform_co()
        {
            Application.Run(new CONSULTA());
        }

        private void novoform_a()
        {
            Application.Run(new ATENDENTE());
        }
    }
}

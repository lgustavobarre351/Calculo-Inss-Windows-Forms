using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class pag_login : Form
    {
        private const string EmailValido = "rm99210@fiap.com.br";
        private const string SenhaValida = "123456"; // Substitua pela senha correta

        public pag_login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != EmailValido)
            {
                // E-mail inválido
                textBox1.BackColor = Color.White;
            }
            else
            {
                // E-mail válido
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != SenhaValida)
            {
                // Senha inválida
                textBox2.BackColor = Color.White;
            }
            else
            {
                // Senha válida
                textBox2.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == EmailValido && textBox2.Text == SenhaValida)
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Hide();
                sexo calcularInssForm = new sexo();
                calcularInssForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("E-mail ou senha inválidos. Tente novamente.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
            }
        }

        private void pag_login_Load(object sender, EventArgs e)
        {

        }
    }
}
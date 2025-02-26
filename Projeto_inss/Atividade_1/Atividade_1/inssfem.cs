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
    public partial class InssFem : Form
    {
        public InssFem()
        {
            InitializeComponent();
        }

        private void InssFem_Load(object sender, EventArgs e)
        {

        }

        private void calcularInssFem_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(textBoxIdadeFem.Text);
            int tempoContribuicao = int.Parse(textBoxContribuicaoFem.Text);

            if (idade >= 62 && tempoContribuicao >= 15)
            {
                MessageBox.Show("Você já pode se aposentar!");
            }
            else
            {
                int anosRestantesIdade = 62 - idade;
                int anosRestantesContribuicao = 15 - tempoContribuicao;

                string mensagem = "Você ainda não pode se aposentar. Faltam:\n";

                if (anosRestantesIdade > 0)
                {
                    mensagem += $"{anosRestantesIdade} anos de idade\n";
                }

                if (anosRestantesContribuicao > 0)
                {
                    mensagem += $"{anosRestantesContribuicao} anos de contribuição";
                }

                MessageBox.Show(mensagem);
            }
        }

        private void textBoxContribuicaoFem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
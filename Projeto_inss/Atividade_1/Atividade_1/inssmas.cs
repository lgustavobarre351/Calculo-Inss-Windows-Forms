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
    public partial class InssMas : Form
    {
        public InssMas()
        {
            InitializeComponent();
        }

        private void InssMas_Load(object sender, EventArgs e)
        {

        }

        private void calcularInssMas_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(textBoxIdadeMas.Text);
            int tempoContribuicao = int.Parse(textBoxContribuicaoInssMas.Text);

            if (idade >= 65 && tempoContribuicao >= 15)
            {
                MessageBox.Show("Você já pode se aposentar!");
            }
            else
            {
                int anosRestantesIdade = 65 - idade;
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
    }
}
namespace Atividade_1
{
    partial class InssFem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxIdadeFem;
        private System.Windows.Forms.TextBox textBoxContribuicaoFem;
        private System.Windows.Forms.Button buttonCalcularInssFem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxIdadeFem = new TextBox();
            textBoxContribuicaoFem = new TextBox();
            buttonCalcularInssFem = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxIdadeFem
            // 
            textBoxIdadeFem.Location = new Point(99, 68);
            textBoxIdadeFem.Margin = new Padding(4, 3, 4, 3);
            textBoxIdadeFem.Name = "textBoxIdadeFem";
            textBoxIdadeFem.Size = new Size(130, 23);
            textBoxIdadeFem.TabIndex = 0;
            // 
            // textBoxContribuicaoFem
            // 
            textBoxContribuicaoFem.Location = new Point(99, 122);
            textBoxContribuicaoFem.Margin = new Padding(4, 3, 4, 3);
            textBoxContribuicaoFem.Name = "textBoxContribuicaoFem";
            textBoxContribuicaoFem.Size = new Size(130, 23);
            textBoxContribuicaoFem.TabIndex = 1;
            textBoxContribuicaoFem.TextChanged += textBoxContribuicaoFem_TextChanged;
            // 
            // buttonCalcularInssFem
            // 
            buttonCalcularInssFem.Location = new Point(113, 161);
            buttonCalcularInssFem.Margin = new Padding(4, 3, 4, 3);
            buttonCalcularInssFem.Name = "buttonCalcularInssFem";
            buttonCalcularInssFem.Size = new Size(100, 27);
            buttonCalcularInssFem.TabIndex = 2;
            buttonCalcularInssFem.Text = "Calcular INSS";
            buttonCalcularInssFem.UseVisualStyleBackColor = true;
            buttonCalcularInssFem.Click += calcularInssFem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(99, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "Contruibuição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(99, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Idade:";
            // 
            // InssFem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.black;
            ClientSize = new Size(334, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCalcularInssFem);
            Controls.Add(textBoxContribuicaoFem);
            Controls.Add(textBoxIdadeFem);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InssFem";
            Text = "Calcular INSS - Feminino";
            Load += InssFem_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label2;
        private Label label1;
    }
}
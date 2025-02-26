namespace Atividade_1
{
    partial class InssMas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxIdadeMas;
        private System.Windows.Forms.TextBox textBoxContribuicaoInssMas;
        private System.Windows.Forms.Button buttonCalcularInssMas;

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
            textBoxIdadeMas = new TextBox();
            textBoxContribuicaoInssMas = new TextBox();
            buttonCalcularInssMas = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxIdadeMas
            // 
            textBoxIdadeMas.Location = new Point(99, 68);
            textBoxIdadeMas.Margin = new Padding(4, 3, 4, 3);
            textBoxIdadeMas.Name = "textBoxIdadeMas";
            textBoxIdadeMas.Size = new Size(130, 23);
            textBoxIdadeMas.TabIndex = 0;
            // 
            // textBoxContribuicaoInssMas
            // 
            textBoxContribuicaoInssMas.Location = new Point(99, 122);
            textBoxContribuicaoInssMas.Margin = new Padding(4, 3, 4, 3);
            textBoxContribuicaoInssMas.Name = "textBoxContribuicaoInssMas";
            textBoxContribuicaoInssMas.Size = new Size(130, 23);
            textBoxContribuicaoInssMas.TabIndex = 1;
            // 
            // buttonCalcularInssMas
            // 
            buttonCalcularInssMas.Location = new Point(113, 161);
            buttonCalcularInssMas.Margin = new Padding(4, 3, 4, 3);
            buttonCalcularInssMas.Name = "buttonCalcularInssMas";
            buttonCalcularInssMas.Size = new Size(100, 27);
            buttonCalcularInssMas.TabIndex = 2;
            buttonCalcularInssMas.Text = "Calcular INSS";
            buttonCalcularInssMas.UseVisualStyleBackColor = true;
            buttonCalcularInssMas.Click += calcularInssMas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(99, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Idade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(99, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Contruibuição:";
            // 
            // InssMas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.black;
            ClientSize = new Size(334, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCalcularInssMas);
            Controls.Add(textBoxContribuicaoInssMas);
            Controls.Add(textBoxIdadeMas);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InssMas";
            Text = "Calcular INSS - Masculino";
            Load += InssMas_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
    }
}
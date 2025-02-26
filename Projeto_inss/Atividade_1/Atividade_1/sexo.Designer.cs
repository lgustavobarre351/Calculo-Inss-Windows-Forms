namespace Atividade_1
{
    partial class sexo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonMasculino;
        private System.Windows.Forms.Button buttonFeminino;

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
            buttonMasculino = new Button();
            buttonFeminino = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonMasculino
            // 
            buttonMasculino.Location = new Point(111, 92);
            buttonMasculino.Margin = new Padding(4, 3, 4, 3);
            buttonMasculino.Name = "buttonMasculino";
            buttonMasculino.Size = new Size(159, 27);
            buttonMasculino.TabIndex = 0;
            buttonMasculino.Text = "Masculino";
            buttonMasculino.UseVisualStyleBackColor = true;
            buttonMasculino.Click += buttonMasculino_Click;
            // 
            // buttonFeminino
            // 
            buttonFeminino.Location = new Point(111, 134);
            buttonFeminino.Margin = new Padding(4, 3, 4, 3);
            buttonFeminino.Name = "buttonFeminino";
            buttonFeminino.Size = new Size(159, 27);
            buttonFeminino.TabIndex = 1;
            buttonFeminino.Text = "Feminino";
            buttonFeminino.UseVisualStyleBackColor = true;
            buttonFeminino.Click += buttonFeminino_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(148, 62);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Escolha o sexo:";
            label1.Click += label1_Click;
            // 
            // sexo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.black1;
            ClientSize = new Size(384, 261);
            Controls.Add(label1);
            Controls.Add(buttonFeminino);
            Controls.Add(buttonMasculino);
            Margin = new Padding(4, 3, 4, 3);
            Name = "sexo";
            Text = "Selecione o Sexo";
            Load += sexo_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
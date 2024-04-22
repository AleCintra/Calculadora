namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxdisplay = new System.Windows.Forms.TextBox();
            this.igual = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.sinal = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.porcentagem = new System.Windows.Forms.Button();
            this.copiar = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxdisplay
            // 
            this.textBoxdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxdisplay.Name = "textBoxdisplay";
            this.textBoxdisplay.Size = new System.Drawing.Size(310, 53);
            this.textBoxdisplay.TabIndex = 0;
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(6, 391);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(318, 58);
            this.igual.TabIndex = 1;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.button1_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(249, 327);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 58);
            this.soma.TabIndex = 2;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(249, 263);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(75, 58);
            this.subtracao.TabIndex = 3;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(249, 199);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(75, 58);
            this.multiplicacao.TabIndex = 4;
            this.multiplicacao.Text = "x";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(168, 327);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(75, 58);
            this.virgula.TabIndex = 5;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(87, 327);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(75, 58);
            this.n0.TabIndex = 6;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.button6_Click);
            // 
            // sinal
            // 
            this.sinal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinal.Location = new System.Drawing.Point(6, 327);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(75, 58);
            this.sinal.TabIndex = 7;
            this.sinal.Text = "+/-";
            this.sinal.UseVisualStyleBackColor = false;
            this.sinal.Click += new System.EventHandler(this.sinal_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(6, 263);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 58);
            this.n1.TabIndex = 8;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(87, 263);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 58);
            this.n2.TabIndex = 9;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(168, 263);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(75, 58);
            this.n3.TabIndex = 10;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(6, 199);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(75, 58);
            this.n4.TabIndex = 11;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(87, 199);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(75, 58);
            this.n5.TabIndex = 12;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(168, 199);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(75, 58);
            this.n6.TabIndex = 13;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(168, 135);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(75, 58);
            this.n9.TabIndex = 14;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(87, 135);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(75, 58);
            this.n8.TabIndex = 15;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(6, 135);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(75, 58);
            this.n7.TabIndex = 16;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(249, 135);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(75, 58);
            this.divisao.TabIndex = 20;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // porcentagem
            // 
            this.porcentagem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentagem.Location = new System.Drawing.Point(6, 71);
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.Size = new System.Drawing.Size(75, 58);
            this.porcentagem.TabIndex = 21;
            this.porcentagem.Text = "%";
            this.porcentagem.UseVisualStyleBackColor = false;
            this.porcentagem.Click += new System.EventHandler(this.porcentagem_Click);
            // 
            // copiar
            // 
            this.copiar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.copiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiar.Location = new System.Drawing.Point(87, 71);
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(75, 58);
            this.copiar.TabIndex = 22;
            this.copiar.Text = "Copy";
            this.copiar.UseVisualStyleBackColor = false;
            this.copiar.Click += new System.EventHandler(this.cancelar_registro_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(168, 71);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 58);
            this.clear.TabIndex = 23;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button23_Click);
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.Location = new System.Drawing.Point(249, 71);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 58);
            this.apagar.TabIndex = 24;
            this.apagar.Text = "<-";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 456);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.copiar);
            this.Controls.Add(this.porcentagem);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.sinal);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.textBoxdisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxdisplay;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button sinal;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button porcentagem;
        private System.Windows.Forms.Button copiar;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button apagar;
    }
}


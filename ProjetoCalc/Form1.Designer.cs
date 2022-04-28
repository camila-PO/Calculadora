
namespace ProjetoCalc
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.radiciacao = new System.Windows.Forms.Button();
            this.NumeroUm = new System.Windows.Forms.Label();
            this.NumeroDois = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.AccessibleDescription = "Botão de soma";
            this.soma.AccessibleName = "Soma";
            this.soma.BackColor = System.Drawing.Color.Thistle;
            this.soma.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(48, 202);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(88, 32);
            this.soma.TabIndex = 0;
            this.soma.Text = "Soma";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.AccessibleDescription = "Botão de subtração ";
            this.subtracao.BackColor = System.Drawing.Color.Thistle;
            this.subtracao.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(142, 202);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(82, 32);
            this.subtracao.TabIndex = 1;
            this.subtracao.Text = "Subtração";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.AccessibleDescription = "Botão de multiplicaão";
            this.multiplicacao.AccessibleName = "Multiplicação";
            this.multiplicacao.BackColor = System.Drawing.Color.Thistle;
            this.multiplicacao.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(230, 202);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(82, 34);
            this.multiplicacao.TabIndex = 2;
            this.multiplicacao.Text = "Multiplicação";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.AccessibleDescription = "botão de Divisão";
            this.divisao.AccessibleName = "Divisão";
            this.divisao.BackColor = System.Drawing.Color.Thistle;
            this.divisao.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(48, 242);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(88, 31);
            this.divisao.TabIndex = 3;
            this.divisao.Text = "Divisão";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // potencia
            // 
            this.potencia.AccessibleDescription = "botão de potencia";
            this.potencia.AccessibleName = "Potência";
            this.potencia.BackColor = System.Drawing.Color.Thistle;
            this.potencia.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencia.Location = new System.Drawing.Point(142, 242);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(82, 31);
            this.potencia.TabIndex = 4;
            this.potencia.Text = "Potenciação";
            this.potencia.UseVisualStyleBackColor = false;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // radiciacao
            // 
            this.radiciacao.AccessibleDescription = "botão de radiciação";
            this.radiciacao.AccessibleName = "radiciação";
            this.radiciacao.BackColor = System.Drawing.Color.Thistle;
            this.radiciacao.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiciacao.Location = new System.Drawing.Point(230, 242);
            this.radiciacao.Name = "radiciacao";
            this.radiciacao.Size = new System.Drawing.Size(82, 31);
            this.radiciacao.TabIndex = 5;
            this.radiciacao.Text = "Radiciação";
            this.radiciacao.UseVisualStyleBackColor = false;
            this.radiciacao.Click += new System.EventHandler(this.radiciacao_Click);
            // 
            // NumeroUm
            // 
            this.NumeroUm.AccessibleDescription = "Primeiro numero";
            this.NumeroUm.AccessibleName = "primeiro numero";
            this.NumeroUm.AutoSize = true;
            this.NumeroUm.BackColor = System.Drawing.Color.LavenderBlush;
            this.NumeroUm.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroUm.Location = new System.Drawing.Point(46, 149);
            this.NumeroUm.Name = "NumeroUm";
            this.NumeroUm.Size = new System.Drawing.Size(87, 14);
            this.NumeroUm.TabIndex = 6;
            this.NumeroUm.Text = "Primeiro numero";
            this.NumeroUm.Click += new System.EventHandler(this.NumeroUm_Click);
            // 
            // NumeroDois
            // 
            this.NumeroDois.AccessibleDescription = "numero dois";
            this.NumeroDois.AutoSize = true;
            this.NumeroDois.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDois.Location = new System.Drawing.Point(209, 149);
            this.NumeroDois.Name = "NumeroDois";
            this.NumeroDois.Size = new System.Drawing.Size(88, 14);
            this.NumeroDois.TabIndex = 7;
            this.NumeroDois.Text = "Segundo Numero";
            this.NumeroDois.Click += new System.EventHandler(this.NumeroDois_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // resultado
            // 
            this.resultado.AccessibleDescription = "Resultado";
            this.resultado.AccessibleName = "Resultado";
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Complex", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(97, 317);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(148, 31);
            this.resultado.TabIndex = 10;
            this.resultado.Text = "Resultado";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotxt", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculadora";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(354, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumeroDois);
            this.Controls.Add(this.NumeroUm);
            this.Controls.Add(this.radiciacao);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button radiciacao;
        private System.Windows.Forms.Label NumeroUm;
        private System.Windows.Forms.Label NumeroDois;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label1;
    }
}


namespace ProjetoExtenso
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnEscrever = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtExtenso = new System.Windows.Forms.TextBox();
            this.lblNumeroExtenso = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(23, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(26, 129);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(84, 28);
            this.btnEscrever.TabIndex = 1;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(26, 38);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtExtenso
            // 
            this.txtExtenso.Location = new System.Drawing.Point(26, 88);
            this.txtExtenso.Name = "txtExtenso";
            this.txtExtenso.Size = new System.Drawing.Size(228, 20);
            this.txtExtenso.TabIndex = 4;
            // 
            // lblNumeroExtenso
            // 
            this.lblNumeroExtenso.AutoSize = true;
            this.lblNumeroExtenso.Location = new System.Drawing.Point(23, 72);
            this.lblNumeroExtenso.Name = "lblNumeroExtenso";
            this.lblNumeroExtenso.Size = new System.Drawing.Size(102, 13);
            this.lblNumeroExtenso.TabIndex = 3;
            this.lblNumeroExtenso.Text = "Numero por extenso";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(170, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 28);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtExtenso);
            this.Controls.Add(this.lblNumeroExtenso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnEscrever);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Numero por extenso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtExtenso;
        private System.Windows.Forms.Label lblNumeroExtenso;
        private System.Windows.Forms.Button btnLimpar;
    }
}


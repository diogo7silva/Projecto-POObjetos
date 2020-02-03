namespace Projecto_POObjetos
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.LblValor1 = new System.Windows.Forms.Label();
            this.LblValor2 = new System.Windows.Forms.Label();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnSubtrai = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnMultiplica = new System.Windows.Forms.Button();
            this.LblTextoResultado = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtValor2 = new System.Windows.Forms.TextBox();
            this.TxtValor1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblValor1
            // 
            this.LblValor1.AutoSize = true;
            this.LblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor1.Location = new System.Drawing.Point(63, 64);
            this.LblValor1.Name = "LblValor1";
            this.LblValor1.Size = new System.Drawing.Size(66, 20);
            this.LblValor1.TabIndex = 0;
            this.LblValor1.Text = "Valor 1";
            // 
            // LblValor2
            // 
            this.LblValor2.AutoSize = true;
            this.LblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor2.Location = new System.Drawing.Point(63, 109);
            this.LblValor2.Name = "LblValor2";
            this.LblValor2.Size = new System.Drawing.Size(66, 20);
            this.LblValor2.TabIndex = 2;
            this.LblValor2.Text = "Valor 2";
            // 
            // BtnSoma
            // 
            this.BtnSoma.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoma.Location = new System.Drawing.Point(67, 170);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(60, 57);
            this.BtnSoma.TabIndex = 4;
            this.BtnSoma.Text = "+";
            this.BtnSoma.UseVisualStyleBackColor = true;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // BtnSubtrai
            // 
            this.BtnSubtrai.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtrai.Location = new System.Drawing.Point(145, 170);
            this.BtnSubtrai.Name = "BtnSubtrai";
            this.BtnSubtrai.Size = new System.Drawing.Size(60, 57);
            this.BtnSubtrai.TabIndex = 5;
            this.BtnSubtrai.Text = "-";
            this.BtnSubtrai.UseVisualStyleBackColor = true;
            this.BtnSubtrai.Click += new System.EventHandler(this.BtnSubtrai_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(223, 170);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(60, 57);
            this.BtnDivide.TabIndex = 6;
            this.BtnDivide.Text = ":";
            this.BtnDivide.UseVisualStyleBackColor = true;
            // 
            // BtnMultiplica
            // 
            this.BtnMultiplica.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplica.Location = new System.Drawing.Point(301, 170);
            this.BtnMultiplica.Name = "BtnMultiplica";
            this.BtnMultiplica.Size = new System.Drawing.Size(60, 57);
            this.BtnMultiplica.TabIndex = 7;
            this.BtnMultiplica.Text = "x";
            this.BtnMultiplica.UseVisualStyleBackColor = true;
            // 
            // LblTextoResultado
            // 
            this.LblTextoResultado.AutoSize = true;
            this.LblTextoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoResultado.Location = new System.Drawing.Point(63, 267);
            this.LblTextoResultado.Name = "LblTextoResultado";
            this.LblTextoResultado.Size = new System.Drawing.Size(91, 20);
            this.LblTextoResultado.TabIndex = 8;
            this.LblTextoResultado.Text = "Resultado";
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.Color.White;
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.Location = new System.Drawing.Point(170, 267);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(191, 20);
            this.LblResultado.TabIndex = 9;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtValor2
            // 
            this.TxtValor2.Location = new System.Drawing.Point(170, 109);
            this.TxtValor2.MaxLength = 15;
            this.TxtValor2.Name = "TxtValor2";
            this.TxtValor2.Size = new System.Drawing.Size(191, 20);
            this.TxtValor2.TabIndex = 3;
            // 
            // TxtValor1
            // 
            this.TxtValor1.Location = new System.Drawing.Point(170, 64);
            this.TxtValor1.Name = "TxtValor1";
            this.TxtValor1.Size = new System.Drawing.Size(191, 20);
            this.TxtValor1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 333);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtValor1);
            this.Controls.Add(this.TxtValor2);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblTextoResultado);
            this.Controls.Add(this.BtnMultiplica);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnSubtrai);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.LblValor2);
            this.Controls.Add(this.LblValor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblValor1;
        private System.Windows.Forms.Label LblValor2;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnSubtrai;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnMultiplica;
        private System.Windows.Forms.Label LblTextoResultado;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtValor2;
        private System.Windows.Forms.TextBox TxtValor1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


namespace ConversorDeTemperatura
{
    partial class Conversor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.cmbSaida = new System.Windows.Forms.ComboBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "para";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(12, 38);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(128, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // cmbEntrada
            // 
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Location = new System.Drawing.Point(146, 37);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(69, 21);
            this.cmbEntrada.TabIndex = 3;
            this.cmbEntrada.SelectedIndexChanged += new System.EventHandler(this.cmbEntrada_SelectedIndexChanged);
            // 
            // cmbSaida
            // 
            this.cmbSaida.FormattingEnabled = true;
            this.cmbSaida.Location = new System.Drawing.Point(255, 38);
            this.cmbSaida.Name = "cmbSaida";
            this.cmbSaida.Size = new System.Drawing.Size(88, 21);
            this.cmbSaida.TabIndex = 4;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(354, 38);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(31, 82);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(23, 25);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(12, 22);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(102, 13);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Digite a temperatura";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 144);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cmbSaida);
            this.Controls.Add(this.cmbEntrada);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label1);
            this.Name = "Conversor";
            this.RightToLeftLayout = true;
            this.Text = "Conversor de Temperaturas";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.ComboBox cmbSaida;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTexto;
    }
}


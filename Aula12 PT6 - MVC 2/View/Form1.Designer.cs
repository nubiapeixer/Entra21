
namespace MVC_2
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
            this.cbFuncionario = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.cbFinanceiro = new System.Windows.Forms.CheckBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.AutoSize = true;
            this.cbFuncionario.Location = new System.Drawing.Point(101, 123);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(140, 29);
            this.cbFuncionario.TabIndex = 0;
            this.cbFuncionario.Text = "Funcionário";
            this.cbFuncionario.UseVisualStyleBackColor = true;
            this.cbFuncionario.CheckedChanged += new System.EventHandler(this.cbFuncionario_CheckedChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(101, 178);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(99, 29);
            this.cbCliente.TabIndex = 1;
            this.cbCliente.Text = "Cliente";
            this.cbCliente.UseVisualStyleBackColor = true;
            this.cbCliente.CheckedChanged += new System.EventHandler(this.cbCliente_CheckedChanged);
            // 
            // cbFinanceiro
            // 
            this.cbFinanceiro.AutoSize = true;
            this.cbFinanceiro.Location = new System.Drawing.Point(101, 226);
            this.cbFinanceiro.Name = "cbFinanceiro";
            this.cbFinanceiro.Size = new System.Drawing.Size(129, 29);
            this.cbFinanceiro.TabIndex = 2;
            this.cbFinanceiro.Text = "Financeiro";
            this.cbFinanceiro.UseVisualStyleBackColor = true;
            this.cbFinanceiro.CheckedChanged += new System.EventHandler(this.cbFinanceiro_CheckedChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(362, 132);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(160, 118);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 413);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbFinanceiro);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbFuncionario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFuncionario;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.CheckBox cbFinanceiro;
        private System.Windows.Forms.Button btnEnter;
    }
}


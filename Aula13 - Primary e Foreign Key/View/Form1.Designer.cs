
namespace _18.AulaSQL
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
            this.rbExec01 = new System.Windows.Forms.RadioButton();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rbExec02 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbExec01
            // 
            this.rbExec01.AutoSize = true;
            this.rbExec01.Location = new System.Drawing.Point(60, 69);
            this.rbExec01.Name = "rbExec01";
            this.rbExec01.Size = new System.Drawing.Size(119, 24);
            this.rbExec01.TabIndex = 0;
            this.rbExec01.TabStop = true;
            this.rbExec01.Text = "Exercício 01";
            this.rbExec01.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(218, 131);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(116, 86);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rbExec02
            // 
            this.rbExec02.AutoSize = true;
            this.rbExec02.Location = new System.Drawing.Point(215, 69);
            this.rbExec02.Name = "rbExec02";
            this.rbExec02.Size = new System.Drawing.Size(119, 24);
            this.rbExec02.TabIndex = 2;
            this.rbExec02.TabStop = true;
            this.rbExec02.Text = "Exercício 02";
            this.rbExec02.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(362, 69);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(119, 24);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "Exercício 03";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 398);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rbExec02);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.rbExec01);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbExec01;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rbExec02;
        private System.Windows.Forms.RadioButton rb3;
    }
}


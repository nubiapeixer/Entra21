
namespace _16.Funções_MultiRetorno
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
            this.rbExec02 = new System.Windows.Forms.RadioButton();
            this.rbExec03 = new System.Windows.Forms.RadioButton();
            this.rbExec04 = new System.Windows.Forms.RadioButton();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbExec01
            // 
            this.rbExec01.AutoSize = true;
            this.rbExec01.Location = new System.Drawing.Point(43, 49);
            this.rbExec01.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbExec01.Name = "rbExec01";
            this.rbExec01.Size = new System.Drawing.Size(204, 40);
            this.rbExec01.TabIndex = 0;
            this.rbExec01.TabStop = true;
            this.rbExec01.Text = "Exercício 01";
            this.rbExec01.UseVisualStyleBackColor = true;
            // 
            // rbExec02
            // 
            this.rbExec02.AutoSize = true;
            this.rbExec02.Location = new System.Drawing.Point(315, 49);
            this.rbExec02.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbExec02.Name = "rbExec02";
            this.rbExec02.Size = new System.Drawing.Size(204, 40);
            this.rbExec02.TabIndex = 1;
            this.rbExec02.TabStop = true;
            this.rbExec02.Text = "Exercício 02";
            this.rbExec02.UseVisualStyleBackColor = true;
            // 
            // rbExec03
            // 
            this.rbExec03.AutoSize = true;
            this.rbExec03.Location = new System.Drawing.Point(43, 161);
            this.rbExec03.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbExec03.Name = "rbExec03";
            this.rbExec03.Size = new System.Drawing.Size(204, 40);
            this.rbExec03.TabIndex = 2;
            this.rbExec03.TabStop = true;
            this.rbExec03.Text = "Exercício 03";
            this.rbExec03.UseVisualStyleBackColor = true;
            // 
            // rbExec04
            // 
            this.rbExec04.AutoSize = true;
            this.rbExec04.Location = new System.Drawing.Point(315, 161);
            this.rbExec04.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbExec04.Name = "rbExec04";
            this.rbExec04.Size = new System.Drawing.Size(204, 40);
            this.rbExec04.TabIndex = 3;
            this.rbExec04.TabStop = true;
            this.rbExec04.Text = "Exercício 04";
            this.rbExec04.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(120, 245);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(337, 140);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "EXECUTAR";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 463);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.rbExec04);
            this.Controls.Add(this.rbExec03);
            this.Controls.Add(this.rbExec02);
            this.Controls.Add(this.rbExec01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbExec01;
        private System.Windows.Forms.RadioButton rbExec02;
        private System.Windows.Forms.RadioButton rbExec03;
        private System.Windows.Forms.RadioButton rbExec04;
        private System.Windows.Forms.Button btnExecutar;
    }
}


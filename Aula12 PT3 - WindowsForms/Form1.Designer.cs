
namespace _14.Windows_Form_parte_3
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
            this.btnExec02 = new System.Windows.Forms.Button();
            this.btnExec03 = new System.Windows.Forms.Button();
            this.btnExec04 = new System.Windows.Forms.Button();
            this.btnExec01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec02
            // 
            this.btnExec02.Location = new System.Drawing.Point(243, 100);
            this.btnExec02.Name = "btnExec02";
            this.btnExec02.Size = new System.Drawing.Size(149, 104);
            this.btnExec02.TabIndex = 0;
            this.btnExec02.Text = "Exec02 CORRIGIDO";
            this.btnExec02.UseVisualStyleBackColor = true;
            this.btnExec02.Click += new System.EventHandler(this.btnExec02_Click);
            // 
            // btnExec03
            // 
            this.btnExec03.Location = new System.Drawing.Point(59, 215);
            this.btnExec03.Name = "btnExec03";
            this.btnExec03.Size = new System.Drawing.Size(149, 104);
            this.btnExec03.TabIndex = 1;
            this.btnExec03.Text = "Exec03";
            this.btnExec03.UseVisualStyleBackColor = true;
            this.btnExec03.Click += new System.EventHandler(this.btnExec03_Click);
            // 
            // btnExec04
            // 
            this.btnExec04.Location = new System.Drawing.Point(243, 215);
            this.btnExec04.Name = "btnExec04";
            this.btnExec04.Size = new System.Drawing.Size(149, 104);
            this.btnExec04.TabIndex = 2;
            this.btnExec04.Text = "Exec04";
            this.btnExec04.UseVisualStyleBackColor = true;
            this.btnExec04.Click += new System.EventHandler(this.btnExec04_Click);
            // 
            // btnExec01
            // 
            this.btnExec01.Location = new System.Drawing.Point(59, 100);
            this.btnExec01.Name = "btnExec01";
            this.btnExec01.Size = new System.Drawing.Size(149, 104);
            this.btnExec01.TabIndex = 3;
            this.btnExec01.Text = "Exec01";
            this.btnExec01.UseVisualStyleBackColor = true;
            this.btnExec01.Click += new System.EventHandler(this.btnExec01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.btnExec01);
            this.Controls.Add(this.btnExec04);
            this.Controls.Add(this.btnExec03);
            this.Controls.Add(this.btnExec02);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec02;
        private System.Windows.Forms.Button btnExec03;
        private System.Windows.Forms.Button btnExec04;
        private System.Windows.Forms.Button btnExec01;
    }
}


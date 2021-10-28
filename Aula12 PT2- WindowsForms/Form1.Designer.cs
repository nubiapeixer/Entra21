
namespace WindowsForms___Exec02
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
            this.btnExec01 = new System.Windows.Forms.Button();
            this.btnExec04 = new System.Windows.Forms.Button();
            this.btnExec05 = new System.Windows.Forms.Button();
            this.btnCorrigido1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec02
            // 
            this.btnExec02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec02.Location = new System.Drawing.Point(13, 137);
            this.btnExec02.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExec02.Name = "btnExec02";
            this.btnExec02.Size = new System.Drawing.Size(202, 86);
            this.btnExec02.TabIndex = 0;
            this.btnExec02.Text = "Exercício 02";
            this.btnExec02.UseVisualStyleBackColor = true;
            this.btnExec02.Click += new System.EventHandler(this.btnExec02_Click);
            // 
            // btnExec01
            // 
            this.btnExec01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec01.Location = new System.Drawing.Point(13, 39);
            this.btnExec01.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExec01.Name = "btnExec01";
            this.btnExec01.Size = new System.Drawing.Size(202, 86);
            this.btnExec01.TabIndex = 1;
            this.btnExec01.Text = "Exercício 01";
            this.btnExec01.UseVisualStyleBackColor = true;
            this.btnExec01.Click += new System.EventHandler(this.btnExec01_Click);
            // 
            // btnExec04
            // 
            this.btnExec04.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec04.Location = new System.Drawing.Point(224, 39);
            this.btnExec04.Margin = new System.Windows.Forms.Padding(4);
            this.btnExec04.Name = "btnExec04";
            this.btnExec04.Size = new System.Drawing.Size(202, 86);
            this.btnExec04.TabIndex = 2;
            this.btnExec04.Text = "Exercício 04";
            this.btnExec04.UseVisualStyleBackColor = true;
            this.btnExec04.Click += new System.EventHandler(this.btnExec04_Click);
            // 
            // btnExec05
            // 
            this.btnExec05.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec05.Location = new System.Drawing.Point(224, 137);
            this.btnExec05.Margin = new System.Windows.Forms.Padding(4);
            this.btnExec05.Name = "btnExec05";
            this.btnExec05.Size = new System.Drawing.Size(202, 86);
            this.btnExec05.TabIndex = 3;
            this.btnExec05.Text = "Exercício 05";
            this.btnExec05.UseVisualStyleBackColor = true;
            this.btnExec05.Click += new System.EventHandler(this.btnExec05_Click);
            // 
            // btnCorrigido1
            // 
            this.btnCorrigido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrigido1.Location = new System.Drawing.Point(13, 235);
            this.btnCorrigido1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCorrigido1.Name = "btnCorrigido1";
            this.btnCorrigido1.Size = new System.Drawing.Size(202, 86);
            this.btnCorrigido1.TabIndex = 4;
            this.btnCorrigido1.Text = "Corrigido 01";
            this.btnCorrigido1.UseVisualStyleBackColor = true;
            this.btnCorrigido1.Click += new System.EventHandler(this.btnCorrigido1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.btnCorrigido1);
            this.Controls.Add(this.btnExec05);
            this.Controls.Add(this.btnExec04);
            this.Controls.Add(this.btnExec01);
            this.Controls.Add(this.btnExec02);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec02;
        private System.Windows.Forms.Button btnExec01;
        private System.Windows.Forms.Button btnExec04;
        private System.Windows.Forms.Button btnExec05;
        private System.Windows.Forms.Button btnCorrigido1;
    }
}


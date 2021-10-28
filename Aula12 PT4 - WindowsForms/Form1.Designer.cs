
namespace teste
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbExec01
            // 
            this.rbExec01.AutoSize = true;
            this.rbExec01.Location = new System.Drawing.Point(74, 109);
            this.rbExec01.Name = "rbExec01";
            this.rbExec01.Size = new System.Drawing.Size(87, 24);
            this.rbExec01.TabIndex = 0;
            this.rbExec01.TabStop = true;
            this.rbExec01.Text = "Exec01";
            this.rbExec01.UseVisualStyleBackColor = true;
            // 
            // rbExec02
            // 
            this.rbExec02.AutoSize = true;
            this.rbExec02.Location = new System.Drawing.Point(74, 169);
            this.rbExec02.Name = "rbExec02";
            this.rbExec02.Size = new System.Drawing.Size(87, 24);
            this.rbExec02.TabIndex = 1;
            this.rbExec02.TabStop = true;
            this.rbExec02.Text = "Exec02";
            this.rbExec02.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(74, 236);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(114, 91);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 547);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.rbExec02);
            this.Controls.Add(this.rbExec01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbExec01;
        private System.Windows.Forms.RadioButton rbExec02;
        private System.Windows.Forms.Button btnExecutar;
    }
}


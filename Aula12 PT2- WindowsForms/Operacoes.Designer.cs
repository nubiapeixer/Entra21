
namespace WindowsForms___Exec02
{
    partial class Operacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOperacoes = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOperacoes
            // 
            this.listOperacoes.FormattingEnabled = true;
            this.listOperacoes.ItemHeight = 20;
            this.listOperacoes.Location = new System.Drawing.Point(13, 13);
            this.listOperacoes.Name = "listOperacoes";
            this.listOperacoes.Size = new System.Drawing.Size(690, 304);
            this.listOperacoes.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(13, 354);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(113, 71);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleta.Location = new System.Drawing.Point(132, 354);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(113, 71);
            this.btnDeleta.TabIndex = 2;
            this.btnDeleta.Text = "DELETA";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // Operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listOperacoes);
            this.Name = "Operacoes";
            this.Text = "Operacoes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Operacoes_FormClosed);
            this.Load += new System.EventHandler(this.Operacoes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOperacoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeleta;
    }
}
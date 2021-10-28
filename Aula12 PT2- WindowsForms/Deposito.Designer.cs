
namespace WindowsForms___Exec02
{
    partial class Deposito
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
            this.lblConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(56, 50);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(71, 25);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Conta:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(34, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(93, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor R$:";
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(133, 50);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(254, 30);
            this.txtConta.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(133, 95);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(254, 30);
            this.txtValor.TabIndex = 3;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(133, 186);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(122, 58);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(345, 283);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 58);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.Location = new System.Drawing.Point(303, 186);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(122, 58);
            this.btnExtrato.TabIndex = 6;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 353);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblConta);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Deposito_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExtrato;
    }
}
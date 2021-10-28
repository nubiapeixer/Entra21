
namespace WindowsForms___Exec02
{
    partial class Saque
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
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(59, 55);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(71, 25);
            this.lblConta.TabIndex = 0;
            this.lblConta.Text = "Conta:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(37, 108);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(93, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor R$:";
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(136, 55);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(228, 30);
            this.txtConta.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(136, 108);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(228, 30);
            this.txtValor.TabIndex = 3;
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(54, 213);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(110, 57);
            this.btnSaque.TabIndex = 4;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.Location = new System.Drawing.Point(195, 213);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(110, 57);
            this.btnExtrato.TabIndex = 5;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(351, 340);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 57);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 409);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblConta);
            this.Name = "Saque";
            this.Text = "Saque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Saque_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Button btnSair;
    }
}
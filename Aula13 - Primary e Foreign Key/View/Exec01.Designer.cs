
namespace _18.AulaSQL.View
{
    partial class Exec01
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
            this.checkPessoa = new System.Windows.Forms.CheckBox();
            this.checkCliente = new System.Windows.Forms.CheckBox();
            this.checkFuncionario = new System.Windows.Forms.CheckBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbVip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkPessoa
            // 
            this.checkPessoa.AutoSize = true;
            this.checkPessoa.Location = new System.Drawing.Point(58, 65);
            this.checkPessoa.Name = "checkPessoa";
            this.checkPessoa.Size = new System.Drawing.Size(88, 24);
            this.checkPessoa.TabIndex = 0;
            this.checkPessoa.Text = "Pessoa";
            this.checkPessoa.UseVisualStyleBackColor = true;
            this.checkPessoa.CheckedChanged += new System.EventHandler(this.checkPessoa_CheckedChanged);
            // 
            // checkCliente
            // 
            this.checkCliente.AutoSize = true;
            this.checkCliente.Location = new System.Drawing.Point(58, 109);
            this.checkCliente.Name = "checkCliente";
            this.checkCliente.Size = new System.Drawing.Size(84, 24);
            this.checkCliente.TabIndex = 1;
            this.checkCliente.Text = "Cliente";
            this.checkCliente.UseVisualStyleBackColor = true;
            this.checkCliente.CheckedChanged += new System.EventHandler(this.checkCliente_CheckedChanged);
            // 
            // checkFuncionario
            // 
            this.checkFuncionario.AutoSize = true;
            this.checkFuncionario.Location = new System.Drawing.Point(58, 160);
            this.checkFuncionario.Name = "checkFuncionario";
            this.checkFuncionario.Size = new System.Drawing.Size(118, 24);
            this.checkFuncionario.TabIndex = 2;
            this.checkFuncionario.Text = "Funcionário";
            this.checkFuncionario.UseVisualStyleBackColor = true;
            this.checkFuncionario.CheckedChanged += new System.EventHandler(this.checkFuncionario_CheckedChanged);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(30, 317);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(112, 82);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(170, 317);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(112, 82);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(326, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(326, 72);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(224, 26);
            this.txtCpf.TabIndex = 6;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(326, 128);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(224, 26);
            this.txtRg.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "RG";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(248, 182);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 11;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(326, 175);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(224, 26);
            this.txtSalario.TabIndex = 12;
            // 
            // cbVip
            // 
            this.cbVip.AutoSize = true;
            this.cbVip.Location = new System.Drawing.Point(341, 236);
            this.cbVip.Name = "cbVip";
            this.cbVip.Size = new System.Drawing.Size(61, 24);
            this.cbVip.TabIndex = 13;
            this.cbVip.Text = "VIP";
            this.cbVip.UseVisualStyleBackColor = true;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 420);
            this.Controls.Add(this.cbVip);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.checkFuncionario);
            this.Controls.Add(this.checkCliente);
            this.Controls.Add(this.checkPessoa);
            this.Name = "Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec01_FormClosed);
            this.Load += new System.EventHandler(this.Exec01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkPessoa;
        private System.Windows.Forms.CheckBox checkCliente;
        private System.Windows.Forms.CheckBox checkFuncionario;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox cbVip;
    }
}
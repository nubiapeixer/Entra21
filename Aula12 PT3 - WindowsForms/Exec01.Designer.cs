
namespace _14.Windows_Form_parte_3
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
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(39, 71);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(35, 21);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(39, 98);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(35, 21);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "2";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(39, 125);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(35, 21);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "3";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(39, 152);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(35, 21);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "4";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(39, 179);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(35, 21);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "5";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(146, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(272, 23);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(146, 125);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(272, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(234, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 57);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSair.Location = new System.Drawing.Point(471, 275);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 46);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 333);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec01_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSair;
    }
}
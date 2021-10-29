
namespace _18.AulaSQL.View
{
    partial class Exec03Atualiza
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
            this.dgCachorros = new System.Windows.Forms.DataGridView();
            this.btnComer = new System.Windows.Forms.Button();
            this.btnDescansar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nomecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idadecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dopaminacol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confortocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCachorros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCachorros
            // 
            this.dgCachorros.AllowUserToAddRows = false;
            this.dgCachorros.AllowUserToDeleteRows = false;
            this.dgCachorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCachorros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomecol,
            this.Idadecol,
            this.Dopaminacol,
            this.Confortocol});
            this.dgCachorros.Location = new System.Drawing.Point(12, 21);
            this.dgCachorros.Name = "dgCachorros";
            this.dgCachorros.ReadOnly = true;
            this.dgCachorros.RowHeadersWidth = 62;
            this.dgCachorros.RowTemplate.Height = 28;
            this.dgCachorros.Size = new System.Drawing.Size(618, 168);
            this.dgCachorros.TabIndex = 0;
            // 
            // btnComer
            // 
            this.btnComer.Location = new System.Drawing.Point(43, 354);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(138, 84);
            this.btnComer.TabIndex = 1;
            this.btnComer.Text = "Comer";
            this.btnComer.UseVisualStyleBackColor = true;
            this.btnComer.Click += new System.EventHandler(this.btnComer_Click);
            // 
            // btnDescansar
            // 
            this.btnDescansar.Location = new System.Drawing.Point(218, 354);
            this.btnDescansar.Name = "btnDescansar";
            this.btnDescansar.Size = new System.Drawing.Size(136, 84);
            this.btnDescansar.TabIndex = 2;
            this.btnDescansar.Text = "Descansar";
            this.btnDescansar.UseVisualStyleBackColor = true;
            this.btnDescansar.Click += new System.EventHandler(this.btnDescansar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(591, 379);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 59);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Cachorro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(160, 249);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(160, 294);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(194, 26);
            this.txtQtd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // Nomecol
            // 
            this.Nomecol.HeaderText = "Nome";
            this.Nomecol.MinimumWidth = 8;
            this.Nomecol.Name = "Nomecol";
            this.Nomecol.ReadOnly = true;
            // 
            // Idadecol
            // 
            this.Idadecol.HeaderText = "Idade";
            this.Idadecol.MinimumWidth = 8;
            this.Idadecol.Name = "Idadecol";
            this.Idadecol.ReadOnly = true;
            this.Idadecol.Width = 75;
            // 
            // Dopaminacol
            // 
            this.Dopaminacol.HeaderText = "Dopamina";
            this.Dopaminacol.MinimumWidth = 8;
            this.Dopaminacol.Name = "Dopaminacol";
            this.Dopaminacol.ReadOnly = true;
            this.Dopaminacol.Width = 150;
            // 
            // Confortocol
            // 
            this.Confortocol.HeaderText = "Conforto";
            this.Confortocol.MinimumWidth = 8;
            this.Confortocol.Name = "Confortocol";
            this.Confortocol.ReadOnly = true;
            this.Confortocol.Width = 150;
            // 
            // Exec03Atualiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDescansar);
            this.Controls.Add(this.btnComer);
            this.Controls.Add(this.dgCachorros);
            this.Name = "Exec03Atualiza";
            this.Text = "Exec03Atualiza";
            this.Load += new System.EventHandler(this.Exec03Atualiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCachorros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCachorros;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.Button btnDescansar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idadecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dopaminacol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confortocol;
    }
}
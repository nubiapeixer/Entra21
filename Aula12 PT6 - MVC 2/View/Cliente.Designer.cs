
namespace MVC_2.View
{
    partial class Cliente
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
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbRemover = new System.Windows.Forms.RadioButton();
            this.rbAtualizar = new System.Windows.Forms.RadioButton();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnpjCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCompraMensal = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblNomeAtualizar = new System.Windows.Forms.Label();
            this.txtNomeAtualizar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(66, 281);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(100, 24);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Adicionar";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbRemover
            // 
            this.rbRemover.AutoSize = true;
            this.rbRemover.Location = new System.Drawing.Point(66, 311);
            this.rbRemover.Name = "rbRemover";
            this.rbRemover.Size = new System.Drawing.Size(98, 24);
            this.rbRemover.TabIndex = 1;
            this.rbRemover.TabStop = true;
            this.rbRemover.Text = "Remover";
            this.rbRemover.UseVisualStyleBackColor = true;
            this.rbRemover.CheckedChanged += new System.EventHandler(this.rbRemover_CheckedChanged);
            // 
            // rbAtualizar
            // 
            this.rbAtualizar.AutoSize = true;
            this.rbAtualizar.Location = new System.Drawing.Point(66, 341);
            this.rbAtualizar.Name = "rbAtualizar";
            this.rbAtualizar.Size = new System.Drawing.Size(96, 24);
            this.rbAtualizar.TabIndex = 2;
            this.rbAtualizar.TabStop = true;
            this.rbAtualizar.Text = "Atualizar";
            this.rbAtualizar.UseVisualStyleBackColor = true;
            this.rbAtualizar.CheckedChanged += new System.EventHandler(this.rbAtualizar_CheckedChanged);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCol,
            this.CnpjCol,
            this.CompraCol});
            this.dgLista.Location = new System.Drawing.Point(47, 31);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersWidth = 62;
            this.dgLista.RowTemplate.Height = 28;
            this.dgLista.Size = new System.Drawing.Size(594, 219);
            this.dgLista.TabIndex = 3;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.MinimumWidth = 8;
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 150;
            // 
            // CnpjCol
            // 
            this.CnpjCol.HeaderText = "CNPJ";
            this.CnpjCol.MinimumWidth = 8;
            this.CnpjCol.Name = "CnpjCol";
            this.CnpjCol.ReadOnly = true;
            this.CnpjCol.Width = 150;
            // 
            // CompraCol
            // 
            this.CompraCol.HeaderText = "Compra Mensal";
            this.CompraCol.MinimumWidth = 8;
            this.CompraCol.Name = "CompraCol";
            this.CompraCol.ReadOnly = true;
            this.CompraCol.Width = 150;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(406, 279);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(406, 311);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(235, 26);
            this.txtCnpj.TabIndex = 5;
            // 
            // txtCompraMensal
            // 
            this.txtCompraMensal.Location = new System.Drawing.Point(406, 343);
            this.txtCompraMensal.Name = "txtCompraMensal";
            this.txtCompraMensal.Size = new System.Drawing.Size(235, 26);
            this.txtCompraMensal.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(334, 281);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(334, 313);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(49, 20);
            this.lblCnpj.TabIndex = 8;
            this.lblCnpj.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(265, 345);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(120, 20);
            this.lblCompra.TabIndex = 9;
            this.lblCompra.Text = "Compra Mensal";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(66, 393);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(152, 45);
            this.btnExecutar.TabIndex = 10;
            this.btnExecutar.Text = "EXECUTAR";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblNomeAtualizar
            // 
            this.lblNomeAtualizar.AutoSize = true;
            this.lblNomeAtualizar.Location = new System.Drawing.Point(268, 396);
            this.lblNomeAtualizar.Name = "lblNomeAtualizar";
            this.lblNomeAtualizar.Size = new System.Drawing.Size(117, 20);
            this.lblNomeAtualizar.TabIndex = 11;
            this.lblNomeAtualizar.Text = "Nome Atualizar";
            // 
            // txtNomeAtualizar
            // 
            this.txtNomeAtualizar.Location = new System.Drawing.Point(406, 393);
            this.txtNomeAtualizar.Name = "txtNomeAtualizar";
            this.txtNomeAtualizar.Size = new System.Drawing.Size(235, 26);
            this.txtNomeAtualizar.TabIndex = 12;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.txtNomeAtualizar);
            this.Controls.Add(this.lblNomeAtualizar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCompraMensal);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.rbAtualizar);
            this.Controls.Add(this.rbRemover);
            this.Controls.Add(this.rbAdd);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cliente_FormClosed);
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbRemover;
        private System.Windows.Forms.RadioButton rbAtualizar;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCompraMensal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnpjCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraCol;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblNomeAtualizar;
        private System.Windows.Forms.TextBox txtNomeAtualizar;
    }
}
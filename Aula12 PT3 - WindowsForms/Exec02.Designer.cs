
namespace _14.Windows_Form_parte_3
{
    partial class Exec02
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
            this.btnSair = new System.Windows.Forms.Button();
            this.dgMercado = new System.Windows.Forms.DataGridView();
            this.checkAdd = new System.Windows.Forms.CheckBox();
            this.checkRemover = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.IDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(459, 567);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 63);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgMercado
            // 
            this.dgMercado.AllowUserToAddRows = false;
            this.dgMercado.AllowUserToDeleteRows = false;
            this.dgMercado.AllowUserToOrderColumns = true;
            this.dgMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcol,
            this.NomeCol,
            this.PrecoCol,
            this.FornecedorCol});
            this.dgMercado.Location = new System.Drawing.Point(12, 12);
            this.dgMercado.Name = "dgMercado";
            this.dgMercado.ReadOnly = true;
            this.dgMercado.RowHeadersWidth = 62;
            this.dgMercado.RowTemplate.Height = 28;
            this.dgMercado.Size = new System.Drawing.Size(544, 315);
            this.dgMercado.TabIndex = 1;
            // 
            // checkAdd
            // 
            this.checkAdd.AutoSize = true;
            this.checkAdd.Location = new System.Drawing.Point(27, 485);
            this.checkAdd.Name = "checkAdd";
            this.checkAdd.Size = new System.Drawing.Size(120, 29);
            this.checkAdd.TabIndex = 2;
            this.checkAdd.Text = "Adicionar";
            this.checkAdd.UseVisualStyleBackColor = true;
            this.checkAdd.CheckedChanged += new System.EventHandler(this.checkAdd_CheckedChanged);
            // 
            // checkRemover
            // 
            this.checkRemover.AutoSize = true;
            this.checkRemover.Location = new System.Drawing.Point(27, 531);
            this.checkRemover.Name = "checkRemover";
            this.checkRemover.Size = new System.Drawing.Size(116, 29);
            this.checkRemover.TabIndex = 3;
            this.checkRemover.Text = "Remover";
            this.checkRemover.UseVisualStyleBackColor = true;
            this.checkRemover.CheckedChanged += new System.EventHandler(this.checkRemover_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(209, 341);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(210, 382);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(63, 25);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preco";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(161, 421);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(112, 25);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(292, 341);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 30);
            this.txtNome.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(292, 382);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(274, 30);
            this.txtPreco.TabIndex = 8;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(292, 418);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(274, 30);
            this.txtFornecedor.TabIndex = 9;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(201, 485);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(181, 87);
            this.btnExecutar.TabIndex = 10;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // IDcol
            // 
            this.IDcol.HeaderText = "ID";
            this.IDcol.MinimumWidth = 8;
            this.IDcol.Name = "IDcol";
            this.IDcol.ReadOnly = true;
            this.IDcol.Width = 60;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.MinimumWidth = 8;
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 125;
            // 
            // PrecoCol
            // 
            this.PrecoCol.HeaderText = "Preco";
            this.PrecoCol.MinimumWidth = 8;
            this.PrecoCol.Name = "PrecoCol";
            this.PrecoCol.ReadOnly = true;
            this.PrecoCol.Width = 110;
            // 
            // FornecedorCol
            // 
            this.FornecedorCol.HeaderText = "Fornecedor";
            this.FornecedorCol.MinimumWidth = 8;
            this.FornecedorCol.Name = "FornecedorCol";
            this.FornecedorCol.ReadOnly = true;
            this.FornecedorCol.Width = 150;
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.checkRemover);
            this.Controls.Add(this.checkAdd);
            this.Controls.Add(this.dgMercado);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgMercado;
        private System.Windows.Forms.CheckBox checkAdd;
        private System.Windows.Forms.CheckBox checkRemover;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCol;
    }
}
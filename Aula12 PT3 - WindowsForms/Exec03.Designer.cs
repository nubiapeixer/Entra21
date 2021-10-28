
namespace _14.Windows_Form_parte_3
{
    partial class Exec03
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
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.IDprodutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomeprodutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precoprodutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.IDcarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomecarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precocarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.checkADD = new System.Windows.Forms.CheckBox();
            this.checkRemove = new System.Windows.Forms.CheckBox();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.AllowUserToOrderColumns = true;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDprodutos,
            this.Nomeprodutos,
            this.Precoprodutos});
            this.dgProduto.Location = new System.Drawing.Point(21, 32);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.RowHeadersWidth = 62;
            this.dgProduto.RowTemplate.Height = 28;
            this.dgProduto.Size = new System.Drawing.Size(586, 262);
            this.dgProduto.TabIndex = 0;
            // 
            // IDprodutos
            // 
            this.IDprodutos.HeaderText = "ID";
            this.IDprodutos.MinimumWidth = 8;
            this.IDprodutos.Name = "IDprodutos";
            this.IDprodutos.ReadOnly = true;
            this.IDprodutos.Width = 75;
            // 
            // Nomeprodutos
            // 
            this.Nomeprodutos.HeaderText = "Nome";
            this.Nomeprodutos.MinimumWidth = 8;
            this.Nomeprodutos.Name = "Nomeprodutos";
            this.Nomeprodutos.ReadOnly = true;
            this.Nomeprodutos.Width = 125;
            // 
            // Precoprodutos
            // 
            this.Precoprodutos.HeaderText = "Preco";
            this.Precoprodutos.MinimumWidth = 8;
            this.Precoprodutos.Name = "Precoprodutos";
            this.Precoprodutos.ReadOnly = true;
            this.Precoprodutos.Width = 110;
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.AllowUserToAddRows = false;
            this.dgCarrinho.AllowUserToDeleteRows = false;
            this.dgCarrinho.AllowUserToOrderColumns = true;
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcarr,
            this.Nomecarr,
            this.Precocarr});
            this.dgCarrinho.Location = new System.Drawing.Point(21, 335);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.ReadOnly = true;
            this.dgCarrinho.RowHeadersWidth = 62;
            this.dgCarrinho.RowTemplate.Height = 28;
            this.dgCarrinho.Size = new System.Drawing.Size(586, 296);
            this.dgCarrinho.TabIndex = 1;
            // 
            // IDcarr
            // 
            this.IDcarr.HeaderText = "ID";
            this.IDcarr.MinimumWidth = 8;
            this.IDcarr.Name = "IDcarr";
            this.IDcarr.ReadOnly = true;
            this.IDcarr.Width = 75;
            // 
            // Nomecarr
            // 
            this.Nomecarr.HeaderText = "Nome";
            this.Nomecarr.MinimumWidth = 8;
            this.Nomecarr.Name = "Nomecarr";
            this.Nomecarr.ReadOnly = true;
            this.Nomecarr.Width = 125;
            // 
            // Precocarr
            // 
            this.Precocarr.HeaderText = "Preco";
            this.Precocarr.MinimumWidth = 8;
            this.Precocarr.Name = "Precocarr";
            this.Precocarr.ReadOnly = true;
            this.Precocarr.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MERCADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CARRINHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(673, 335);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(287, 26);
            this.txtID.TabIndex = 5;
            // 
            // checkADD
            // 
            this.checkADD.AutoSize = true;
            this.checkADD.Location = new System.Drawing.Point(632, 380);
            this.checkADD.Name = "checkADD";
            this.checkADD.Size = new System.Drawing.Size(101, 24);
            this.checkADD.TabIndex = 6;
            this.checkADD.Text = "Adicionar";
            this.checkADD.UseVisualStyleBackColor = true;
            this.checkADD.CheckedChanged += new System.EventHandler(this.checkADD_CheckedChanged);
            // 
            // checkRemove
            // 
            this.checkRemove.AutoSize = true;
            this.checkRemove.Location = new System.Drawing.Point(632, 426);
            this.checkRemove.Name = "checkRemove";
            this.checkRemove.Size = new System.Drawing.Size(99, 24);
            this.checkRemove.TabIndex = 7;
            this.checkRemove.Text = "Remover";
            this.checkRemove.UseVisualStyleBackColor = true;
            this.checkRemove.CheckedChanged += new System.EventHandler(this.checkRemove_CheckedChanged);
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(739, 380);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(221, 66);
            this.btnExecuta.TabIndex = 8;
            this.btnExecuta.Text = "Executar";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(877, 555);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 77);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_14.Windows_Form_parte_3.Properties.Resources.pngtree_shopstoremarketbuildingshopping_flat_color_icon_vector_png_image_14905071;
            this.pictureBox1.Location = new System.Drawing.Point(673, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(632, 492);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(127, 125);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 644);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.checkRemove);
            this.Controls.Add(this.checkADD);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCarrinho);
            this.Controls.Add(this.dgProduto);
            this.Name = "Exec03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomeprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precoprodutos;
        private System.Windows.Forms.DataGridView dgCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precocarr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox checkADD;
        private System.Windows.Forms.CheckBox checkRemove;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

namespace teste
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
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgNomes = new System.Windows.Forms.DataGridView();
            this.idcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgNomes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(113, 26);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(304, 28);
            this.cbNome.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 60);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgNomes
            // 
            this.dgNomes.AllowUserToAddRows = false;
            this.dgNomes.AllowUserToDeleteRows = false;
            this.dgNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcol,
            this.NomeCol,
            this.CpfCol,
            this.IdadeCol});
            this.dgNomes.Location = new System.Drawing.Point(12, 138);
            this.dgNomes.Name = "dgNomes";
            this.dgNomes.ReadOnly = true;
            this.dgNomes.RowHeadersWidth = 62;
            this.dgNomes.RowTemplate.Height = 28;
            this.dgNomes.Size = new System.Drawing.Size(508, 285);
            this.dgNomes.TabIndex = 2;
            // 
            // idcol
            // 
            this.idcol.HeaderText = "ID";
            this.idcol.MinimumWidth = 8;
            this.idcol.Name = "idcol";
            this.idcol.ReadOnly = true;
            this.idcol.Width = 50;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.MinimumWidth = 8;
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 150;
            // 
            // CpfCol
            // 
            this.CpfCol.HeaderText = "CPF";
            this.CpfCol.MinimumWidth = 8;
            this.CpfCol.Name = "CpfCol";
            this.CpfCol.ReadOnly = true;
            this.CpfCol.Width = 150;
            // 
            // IdadeCol
            // 
            this.IdadeCol.HeaderText = "Idade";
            this.IdadeCol.MinimumWidth = 8;
            this.IdadeCol.Name = "IdadeCol";
            this.IdadeCol.ReadOnly = true;
            this.IdadeCol.Width = 75;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.dgNomes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbNome);
            this.Name = "Exec01";
            this.Text = "Exec01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec01_FormClosed);
            this.Load += new System.EventHandler(this.Exec01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgNomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeCol;
    }
}
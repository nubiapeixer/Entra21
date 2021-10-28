
namespace teste
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
            this.cbVaga = new System.Windows.Forms.ComboBox();
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.rbEntrando = new System.Windows.Forms.RadioButton();
            this.rbSaindo = new System.Windows.Forms.RadioButton();
            this.lblVagas = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.VagasCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcupadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVaga
            // 
            this.cbVaga.FormattingEnabled = true;
            this.cbVaga.Location = new System.Drawing.Point(157, 381);
            this.cbVaga.Name = "cbVaga";
            this.cbVaga.Size = new System.Drawing.Size(225, 28);
            this.cbVaga.TabIndex = 0;
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VagasCol,
            this.PlacaCol,
            this.OcupadoCol});
            this.dgVagas.Location = new System.Drawing.Point(21, 12);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowHeadersWidth = 62;
            this.dgVagas.RowTemplate.Height = 28;
            this.dgVagas.Size = new System.Drawing.Size(611, 316);
            this.dgVagas.TabIndex = 1;
            // 
            // rbEntrando
            // 
            this.rbEntrando.AutoSize = true;
            this.rbEntrando.Location = new System.Drawing.Point(12, 381);
            this.rbEntrando.Name = "rbEntrando";
            this.rbEntrando.Size = new System.Drawing.Size(100, 24);
            this.rbEntrando.TabIndex = 2;
            this.rbEntrando.TabStop = true;
            this.rbEntrando.Text = "Entrando";
            this.rbEntrando.UseVisualStyleBackColor = true;
            this.rbEntrando.CheckedChanged += new System.EventHandler(this.rbEntrando_CheckedChanged);
            // 
            // rbSaindo
            // 
            this.rbSaindo.AutoSize = true;
            this.rbSaindo.Location = new System.Drawing.Point(12, 433);
            this.rbSaindo.Name = "rbSaindo";
            this.rbSaindo.Size = new System.Drawing.Size(84, 24);
            this.rbSaindo.TabIndex = 3;
            this.rbSaindo.TabStop = true;
            this.rbSaindo.Text = "Saindo";
            this.rbSaindo.UseVisualStyleBackColor = true;
            this.rbSaindo.CheckedChanged += new System.EventHandler(this.rbSaindo_CheckedChanged);
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Location = new System.Drawing.Point(197, 343);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(139, 20);
            this.lblVagas.TabIndex = 4;
            this.lblVagas.Text = "Vagas Disponíveis";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(230, 451);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(151, 474);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(231, 26);
            this.txtPlaca.TabIndex = 6;
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(435, 377);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(116, 123);
            this.btnExecuta.TabIndex = 7;
            this.btnExecuta.Text = "Executa";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(658, 483);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 121);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // VagasCol
            // 
            this.VagasCol.HeaderText = "Vagas";
            this.VagasCol.MinimumWidth = 8;
            this.VagasCol.Name = "VagasCol";
            this.VagasCol.ReadOnly = true;
            // 
            // PlacaCol
            // 
            this.PlacaCol.HeaderText = "Placas";
            this.PlacaCol.MinimumWidth = 8;
            this.PlacaCol.Name = "PlacaCol";
            this.PlacaCol.ReadOnly = true;
            // 
            // OcupadoCol
            // 
            this.OcupadoCol.HeaderText = "Ocupado";
            this.OcupadoCol.MinimumWidth = 8;
            this.OcupadoCol.Name = "OcupadoCol";
            this.OcupadoCol.ReadOnly = true;
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 616);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.rbSaindo);
            this.Controls.Add(this.rbEntrando);
            this.Controls.Add(this.dgVagas);
            this.Controls.Add(this.cbVaga);
            this.Name = "Exec02";
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVaga;
        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.RadioButton rbEntrando;
        private System.Windows.Forms.RadioButton rbSaindo;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn VagasCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcupadoCol;
    }
}
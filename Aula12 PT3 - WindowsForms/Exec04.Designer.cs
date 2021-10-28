
namespace _14.Windows_Form_parte_3
{
    partial class Exec04
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
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtGanho = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.txtMesAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.IDhistorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(137, 57);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(261, 23);
            this.txtCusto.TabIndex = 0;
            // 
            // txtGanho
            // 
            this.txtGanho.Location = new System.Drawing.Point(137, 86);
            this.txtGanho.Name = "txtGanho";
            this.txtGanho.Size = new System.Drawing.Size(261, 23);
            this.txtGanho.TabIndex = 1;
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(137, 115);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(261, 23);
            this.txtLucro.TabIndex = 2;
            // 
            // txtMesAno
            // 
            this.txtMesAno.Location = new System.Drawing.Point(137, 144);
            this.txtMesAno.Name = "txtMesAno";
            this.txtMesAno.Size = new System.Drawing.Size(261, 23);
            this.txtMesAno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ganho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lucro";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mês/Ano";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(234, 187);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 46);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.AllowUserToOrderColumns = true;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDhistorico,
            this.CustosCol,
            this.GanhosCol,
            this.LucroCol,
            this.DataCol});
            this.dgHistorico.Location = new System.Drawing.Point(23, 331);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.Size = new System.Drawing.Size(516, 263);
            this.dgHistorico.TabIndex = 9;
            // 
            // IDhistorico
            // 
            this.IDhistorico.HeaderText = "ID";
            this.IDhistorico.Name = "IDhistorico";
            this.IDhistorico.ReadOnly = true;
            this.IDhistorico.Width = 65;
            // 
            // CustosCol
            // 
            this.CustosCol.HeaderText = "Custos";
            this.CustosCol.Name = "CustosCol";
            this.CustosCol.ReadOnly = true;
            // 
            // GanhosCol
            // 
            this.GanhosCol.HeaderText = "Ganhos";
            this.GanhosCol.Name = "GanhosCol";
            this.GanhosCol.ReadOnly = true;
            // 
            // LucroCol
            // 
            this.LucroCol.HeaderText = "Lucro";
            this.LucroCol.Name = "LucroCol";
            this.LucroCol.ReadOnly = true;
            // 
            // DataCol
            // 
            this.DataCol.HeaderText = "Mês/Ano";
            this.DataCol.Name = "DataCol";
            this.DataCol.ReadOnly = true;
            // 
            // Exec04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.dgHistorico);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesAno);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtGanho);
            this.Controls.Add(this.txtCusto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exec04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec04";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec04_FormClosed);
            this.Load += new System.EventHandler(this.Exec04_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtGanho;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.TextBox txtMesAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDhistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCol;
    }
}
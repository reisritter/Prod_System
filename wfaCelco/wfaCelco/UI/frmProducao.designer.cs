namespace wfaCelco.UI
{
    partial class frmProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncerrarOP = new System.Windows.Forms.Button();
            this.btnEmitirOP = new System.Windows.Forms.Button();
            this.btnCancelarOP = new System.Windows.Forms.Button();
            this.btnAlterarOP = new System.Windows.Forms.Button();
            this.btnNovaOP = new System.Windows.Forms.Button();
            this.dgProdOP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorPesq = new System.Windows.Forms.TextBox();
            this.cbbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbEncerrado = new System.Windows.Forms.RadioButton();
            this.rdbCancelado = new System.Windows.Forms.RadioButton();
            this.rdbAberto = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.printDocumentProd = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogProd = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdOP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnEncerrarOP);
            this.panel1.Controls.Add(this.btnEmitirOP);
            this.panel1.Controls.Add(this.btnCancelarOP);
            this.panel1.Controls.Add(this.btnAlterarOP);
            this.panel1.Controls.Add(this.btnNovaOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnEncerrarOP
            // 
            this.btnEncerrarOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnEncerrarOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnEncerrarOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnEncerrarOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarOP.ForeColor = System.Drawing.Color.White;
            this.btnEncerrarOP.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrarOP.Image")));
            this.btnEncerrarOP.Location = new System.Drawing.Point(259, 0);
            this.btnEncerrarOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncerrarOP.Name = "btnEncerrarOP";
            this.btnEncerrarOP.Size = new System.Drawing.Size(86, 86);
            this.btnEncerrarOP.TabIndex = 6;
            this.btnEncerrarOP.Text = "&Encerrar OP";
            this.btnEncerrarOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEncerrarOP.UseVisualStyleBackColor = true;
            this.btnEncerrarOP.Click += new System.EventHandler(this.btnEncerrarOP_Click);
            // 
            // btnEmitirOP
            // 
            this.btnEmitirOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnEmitirOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnEmitirOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnEmitirOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirOP.ForeColor = System.Drawing.Color.White;
            this.btnEmitirOP.Image = ((System.Drawing.Image)(resources.GetObject("btnEmitirOP.Image")));
            this.btnEmitirOP.Location = new System.Drawing.Point(345, -1);
            this.btnEmitirOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmitirOP.Name = "btnEmitirOP";
            this.btnEmitirOP.Size = new System.Drawing.Size(86, 86);
            this.btnEmitirOP.TabIndex = 4;
            this.btnEmitirOP.Text = "&Imprimir";
            this.btnEmitirOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmitirOP.UseVisualStyleBackColor = true;
            this.btnEmitirOP.Click += new System.EventHandler(this.btnEmitirOP_Click);
            // 
            // btnCancelarOP
            // 
            this.btnCancelarOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCancelarOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnCancelarOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnCancelarOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOP.ForeColor = System.Drawing.Color.White;
            this.btnCancelarOP.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOP.Image")));
            this.btnCancelarOP.Location = new System.Drawing.Point(173, 0);
            this.btnCancelarOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarOP.Name = "btnCancelarOP";
            this.btnCancelarOP.Size = new System.Drawing.Size(86, 86);
            this.btnCancelarOP.TabIndex = 2;
            this.btnCancelarOP.Text = "&Cancelar OP";
            this.btnCancelarOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarOP.UseVisualStyleBackColor = true;
            this.btnCancelarOP.Click += new System.EventHandler(this.btnCancelarOP_Click);
            // 
            // btnAlterarOP
            // 
            this.btnAlterarOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAlterarOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAlterarOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAlterarOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarOP.ForeColor = System.Drawing.Color.White;
            this.btnAlterarOP.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarOP.Image")));
            this.btnAlterarOP.Location = new System.Drawing.Point(87, 0);
            this.btnAlterarOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarOP.Name = "btnAlterarOP";
            this.btnAlterarOP.Size = new System.Drawing.Size(86, 86);
            this.btnAlterarOP.TabIndex = 1;
            this.btnAlterarOP.Text = "&Alterar";
            this.btnAlterarOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarOP.UseVisualStyleBackColor = true;
            this.btnAlterarOP.Click += new System.EventHandler(this.btnAlterarOP_Click);
            // 
            // btnNovaOP
            // 
            this.btnNovaOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnNovaOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnNovaOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnNovaOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOP.ForeColor = System.Drawing.Color.White;
            this.btnNovaOP.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaOP.Image")));
            this.btnNovaOP.Location = new System.Drawing.Point(0, 0);
            this.btnNovaOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaOP.Name = "btnNovaOP";
            this.btnNovaOP.Size = new System.Drawing.Size(86, 86);
            this.btnNovaOP.TabIndex = 0;
            this.btnNovaOP.Text = "&Novo";
            this.btnNovaOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovaOP.UseVisualStyleBackColor = true;
            this.btnNovaOP.Click += new System.EventHandler(this.btnNovaOP_Click);
            // 
            // dgProdOP
            // 
            this.dgProdOP.AllowUserToAddRows = false;
            this.dgProdOP.AllowUserToDeleteRows = false;
            this.dgProdOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProdOP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgProdOP.Location = new System.Drawing.Point(11, 25);
            this.dgProdOP.Margin = new System.Windows.Forms.Padding(4);
            this.dgProdOP.MultiSelect = false;
            this.dgProdOP.Name = "dgProdOP";
            this.dgProdOP.ReadOnly = true;
            this.dgProdOP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgProdOP.RowHeadersVisible = false;
            this.dgProdOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdOP.Size = new System.Drawing.Size(903, 389);
            this.dgProdOP.TabIndex = 1;
            this.dgProdOP.Click += new System.EventHandler(this.dgProdOP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgProdOP);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(934, 445);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista das OP\'s (Ordem de Produção)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encontrado(s) ";
            // 
            // txtValorPesq
            // 
            this.txtValorPesq.Location = new System.Drawing.Point(383, 34);
            this.txtValorPesq.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPesq.Name = "txtValorPesq";
            this.txtValorPesq.Size = new System.Drawing.Size(368, 22);
            this.txtValorPesq.TabIndex = 4;
            this.txtValorPesq.Visible = false;
            this.txtValorPesq.TextChanged += new System.EventHandler(this.txtValorPesq_TextChanged);
            this.txtValorPesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPesq_KeyPress);
            // 
            // cbbTipoFiltro
            // 
            this.cbbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoFiltro.FormattingEnabled = true;
            this.cbbTipoFiltro.Items.AddRange(new object[] {
            "STATUS",
            "PRODUTO"});
            this.cbbTipoFiltro.Location = new System.Drawing.Point(199, 34);
            this.cbbTipoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipoFiltro.Name = "cbbTipoFiltro";
            this.cbbTipoFiltro.Size = new System.Drawing.Size(173, 24);
            this.cbbTipoFiltro.TabIndex = 5;
            this.cbbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbbTipoFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de pesquisa por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbEncerrado);
            this.groupBox2.Controls.Add(this.rdbCancelado);
            this.groupBox2.Controls.Add(this.rdbAberto);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtValorPesq);
            this.groupBox2.Controls.Add(this.cbbTipoFiltro);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(934, 82);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de Pesquisa";
            // 
            // rdbEncerrado
            // 
            this.rdbEncerrado.AutoSize = true;
            this.rdbEncerrado.Location = new System.Drawing.Point(616, 35);
            this.rdbEncerrado.Name = "rdbEncerrado";
            this.rdbEncerrado.Size = new System.Drawing.Size(112, 20);
            this.rdbEncerrado.TabIndex = 11;
            this.rdbEncerrado.TabStop = true;
            this.rdbEncerrado.Text = "ENCERRADO";
            this.rdbEncerrado.UseVisualStyleBackColor = true;
            this.rdbEncerrado.Visible = false;
            this.rdbEncerrado.CheckedChanged += new System.EventHandler(this.rdbEncerrado_CheckedChanged);
            // 
            // rdbCancelado
            // 
            this.rdbCancelado.AutoSize = true;
            this.rdbCancelado.Location = new System.Drawing.Point(502, 35);
            this.rdbCancelado.Name = "rdbCancelado";
            this.rdbCancelado.Size = new System.Drawing.Size(108, 20);
            this.rdbCancelado.TabIndex = 10;
            this.rdbCancelado.TabStop = true;
            this.rdbCancelado.Text = "CANCELADO";
            this.rdbCancelado.UseVisualStyleBackColor = true;
            this.rdbCancelado.Visible = false;
            this.rdbCancelado.CheckedChanged += new System.EventHandler(this.rdbCancelado_CheckedChanged);
            // 
            // rdbAberto
            // 
            this.rdbAberto.AutoSize = true;
            this.rdbAberto.Checked = true;
            this.rdbAberto.Location = new System.Drawing.Point(414, 35);
            this.rdbAberto.Name = "rdbAberto";
            this.rdbAberto.Size = new System.Drawing.Size(82, 20);
            this.rdbAberto.TabIndex = 9;
            this.rdbAberto.TabStop = true;
            this.rdbAberto.Text = "ABERTO";
            this.rdbAberto.UseVisualStyleBackColor = true;
            this.rdbAberto.Visible = false;
            this.rdbAberto.CheckedChanged += new System.EventHandler(this.rdbAberto_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(778, 29);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 32);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // printDocumentProd
            // 
            this.printDocumentProd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProd_PrintPage);
            // 
            // printPreviewDialogProd
            // 
            this.printPreviewDialogProd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProd.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogProd.Document = this.printDocumentProd;
            this.printPreviewDialogProd.Enabled = true;
            this.printPreviewDialogProd.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogProd.Icon")));
            this.printPreviewDialogProd.Name = "printPreviewDialogProd";
            this.printPreviewDialogProd.Visible = false;
            // 
            // frmProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProducao_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdOP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovaOP;
        private System.Windows.Forms.Button btnAlterarOP;
        private System.Windows.Forms.DataGridView dgProdOP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorPesq;
        private System.Windows.Forms.ComboBox cbbTipoFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmitirOP;
        private System.Windows.Forms.Button btnEncerrarOP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rdbEncerrado;
        private System.Windows.Forms.RadioButton rdbCancelado;
        private System.Windows.Forms.RadioButton rdbAberto;
        private System.Drawing.Printing.PrintDocument printDocumentProd;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProd;
    }
}
namespace wfaCelco.UI
{
    partial class frmRecursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimirRec = new System.Windows.Forms.Button();
            this.btnDesativaRec = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAddRecurso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.printPreviewDialogRec = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentRec = new System.Drawing.Printing.PrintDocument();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDestivados = new System.Windows.Forms.RadioButton();
            this.rbAtivos = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPesq = new System.Windows.Forms.TextBox();
            this.cbbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnImprimirRec);
            this.panel1.Controls.Add(this.btnDesativaRec);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnAddRecurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 86);
            this.panel1.TabIndex = 2;
            // 
            // btnImprimirRec
            // 
            this.btnImprimirRec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImprimirRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnImprimirRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnImprimirRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRec.ForeColor = System.Drawing.Color.White;
            this.btnImprimirRec.Image = global::wfaCelco.Properties.Resources.Printer_New;
            this.btnImprimirRec.Location = new System.Drawing.Point(258, 0);
            this.btnImprimirRec.Name = "btnImprimirRec";
            this.btnImprimirRec.Size = new System.Drawing.Size(86, 86);
            this.btnImprimirRec.TabIndex = 3;
            this.btnImprimirRec.Text = "Imprimir";
            this.btnImprimirRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirRec.UseVisualStyleBackColor = true;
            this.btnImprimirRec.Click += new System.EventHandler(this.btnImprimirRec_Click);
            // 
            // btnDesativaRec
            // 
            this.btnDesativaRec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnDesativaRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnDesativaRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnDesativaRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativaRec.ForeColor = System.Drawing.Color.White;
            this.btnDesativaRec.Image = global::wfaCelco.Properties.Resources.Cancel;
            this.btnDesativaRec.Location = new System.Drawing.Point(172, 0);
            this.btnDesativaRec.Name = "btnDesativaRec";
            this.btnDesativaRec.Size = new System.Drawing.Size(86, 86);
            this.btnDesativaRec.TabIndex = 2;
            this.btnDesativaRec.Text = "Desativar Recurso";
            this.btnDesativaRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesativaRec.UseVisualStyleBackColor = true;
            this.btnDesativaRec.Click += new System.EventHandler(this.btnDesativaRec_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(86, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(86, 86);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Recurso";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAddRecurso
            // 
            this.btnAddRecurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAddRecurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAddRecurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAddRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecurso.ForeColor = System.Drawing.Color.White;
            this.btnAddRecurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRecurso.Image")));
            this.btnAddRecurso.Location = new System.Drawing.Point(0, 0);
            this.btnAddRecurso.Name = "btnAddRecurso";
            this.btnAddRecurso.Size = new System.Drawing.Size(86, 86);
            this.btnAddRecurso.TabIndex = 0;
            this.btnAddRecurso.Text = "Novo Recurso";
            this.btnAddRecurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddRecurso.UseVisualStyleBackColor = true;
            this.btnAddRecurso.Click += new System.EventHandler(this.btnAddRecurso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvRecursos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Recursos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecursos.Location = new System.Drawing.Point(15, 23);
            this.dgvRecursos.MultiSelect = false;
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRecursos.RowHeadersVisible = false;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(904, 336);
            this.dgvRecursos.TabIndex = 0;
            // 
            // printPreviewDialogRec
            // 
            this.printPreviewDialogRec.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogRec.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogRec.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogRec.Document = this.printDocumentRec;
            this.printPreviewDialogRec.Enabled = true;
            this.printPreviewDialogRec.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogRec.Icon")));
            this.printPreviewDialogRec.Name = "printPreviewDialogRec";
            this.printPreviewDialogRec.Visible = false;
            // 
            // printDocumentRec
            // 
            this.printDocumentRec.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentRec_PrintPage);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDestivados);
            this.groupBox2.Controls.Add(this.rbAtivos);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtValorPesq);
            this.groupBox2.Controls.Add(this.cbbTipoFiltro);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(14, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(934, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de Pesquisa";
            // 
            // rbDestivados
            // 
            this.rbDestivados.AutoSize = true;
            this.rbDestivados.Location = new System.Drawing.Point(612, 32);
            this.rbDestivados.Name = "rbDestivados";
            this.rbDestivados.Size = new System.Drawing.Size(123, 21);
            this.rbDestivados.TabIndex = 11;
            this.rbDestivados.TabStop = true;
            this.rbDestivados.Text = "DESATIVADOS";
            this.rbDestivados.UseVisualStyleBackColor = true;
            this.rbDestivados.Visible = false;
            this.rbDestivados.CheckedChanged += new System.EventHandler(this.rbDestivados_CheckedChanged);
            // 
            // rbAtivos
            // 
            this.rbAtivos.AutoSize = true;
            this.rbAtivos.Checked = true;
            this.rbAtivos.Location = new System.Drawing.Point(456, 32);
            this.rbAtivos.Name = "rbAtivos";
            this.rbAtivos.Size = new System.Drawing.Size(95, 21);
            this.rbAtivos.TabIndex = 9;
            this.rbAtivos.TabStop = true;
            this.rbAtivos.Text = "ATIVADOS";
            this.rbAtivos.UseVisualStyleBackColor = true;
            this.rbAtivos.Visible = false;
            this.rbAtivos.CheckedChanged += new System.EventHandler(this.rbAtivos_CheckedChanged);
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
            this.btnRefresh.Location = new System.Drawing.Point(778, 26);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 32);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de pesquisa por:";
            // 
            // txtValorPesq
            // 
            this.txtValorPesq.Location = new System.Drawing.Point(388, 31);
            this.txtValorPesq.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPesq.Name = "txtValorPesq";
            this.txtValorPesq.Size = new System.Drawing.Size(368, 23);
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
            "NOME DO RECURSO"});
            this.cbbTipoFiltro.Location = new System.Drawing.Point(202, 31);
            this.cbbTipoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipoFiltro.Name = "cbbTipoFiltro";
            this.cbbTipoFiltro.Size = new System.Drawing.Size(173, 24);
            this.cbbTipoFiltro.TabIndex = 5;
            this.cbbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbbTipoFiltro_SelectedIndexChanged);
            // 
            // frmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmRecursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecursos";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRecurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnImprimirRec;
        private System.Windows.Forms.Button btnDesativaRec;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogRec;
        private System.Drawing.Printing.PrintDocument printDocumentRec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDestivados;
        private System.Windows.Forms.RadioButton rbAtivos;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorPesq;
        private System.Windows.Forms.ComboBox cbbTipoFiltro;
    }
}
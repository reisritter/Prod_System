namespace wfaCelco.UI
{
    partial class frmFormulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirFormula = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAlterarFormula = new System.Windows.Forms.Button();
            this.btnNovaFormula = new System.Windows.Forms.Button();
            this.dgvRelaForm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRelaComp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudConteudo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.PPD = new System.Windows.Forms.PrintPreviewDialog();
            this.PD = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaComp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConteudo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnExcluirFormula);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnAlterarFormula);
            this.panel1.Controls.Add(this.btnNovaFormula);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluirFormula
            // 
            this.btnExcluirFormula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnExcluirFormula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnExcluirFormula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnExcluirFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExcluirFormula.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFormula.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFormula.Image")));
            this.btnExcluirFormula.Location = new System.Drawing.Point(172, 0);
            this.btnExcluirFormula.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirFormula.Name = "btnExcluirFormula";
            this.btnExcluirFormula.Size = new System.Drawing.Size(86, 86);
            this.btnExcluirFormula.TabIndex = 9;
            this.btnExcluirFormula.Text = "&Excluir";
            this.btnExcluirFormula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirFormula.UseVisualStyleBackColor = true;
            this.btnExcluirFormula.Click += new System.EventHandler(this.btnExcluirFormula_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(258, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 86);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAlterarFormula
            // 
            this.btnAlterarFormula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAlterarFormula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAlterarFormula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAlterarFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAlterarFormula.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFormula.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarFormula.Image")));
            this.btnAlterarFormula.Location = new System.Drawing.Point(86, 0);
            this.btnAlterarFormula.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarFormula.Name = "btnAlterarFormula";
            this.btnAlterarFormula.Size = new System.Drawing.Size(86, 86);
            this.btnAlterarFormula.TabIndex = 7;
            this.btnAlterarFormula.Text = "&Alterar";
            this.btnAlterarFormula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarFormula.UseVisualStyleBackColor = true;
            this.btnAlterarFormula.Click += new System.EventHandler(this.btnAlterarFormula_Click);
            // 
            // btnNovaFormula
            // 
            this.btnNovaFormula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnNovaFormula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnNovaFormula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnNovaFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNovaFormula.ForeColor = System.Drawing.Color.White;
            this.btnNovaFormula.Image = global::wfaCelco.Properties.Resources.Add_New;
            this.btnNovaFormula.Location = new System.Drawing.Point(3, 0);
            this.btnNovaFormula.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaFormula.Name = "btnNovaFormula";
            this.btnNovaFormula.Size = new System.Drawing.Size(86, 86);
            this.btnNovaFormula.TabIndex = 6;
            this.btnNovaFormula.Text = "&Nova formula";
            this.btnNovaFormula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovaFormula.UseVisualStyleBackColor = true;
            this.btnNovaFormula.Click += new System.EventHandler(this.btnNovaFormula_Click);
            // 
            // dgvRelaForm
            // 
            this.dgvRelaForm.AllowUserToAddRows = false;
            this.dgvRelaForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelaForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelaForm.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelaForm.Location = new System.Drawing.Point(12, 233);
            this.dgvRelaForm.Name = "dgvRelaForm";
            this.dgvRelaForm.RowHeadersVisible = false;
            this.dgvRelaForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelaForm.Size = new System.Drawing.Size(933, 190);
            this.dgvRelaForm.TabIndex = 1;
            this.dgvRelaForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelaForm_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RELAÇÃO DE FÓRMULAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "COMPOSIÇÃO DA FÓRMULA";
            // 
            // dgvRelaComp
            // 
            this.dgvRelaComp.AllowUserToAddRows = false;
            this.dgvRelaComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelaComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelaComp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelaComp.Location = new System.Drawing.Point(12, 460);
            this.dgvRelaComp.Name = "dgvRelaComp";
            this.dgvRelaComp.ReadOnly = true;
            this.dgvRelaComp.RowHeadersVisible = false;
            this.dgvRelaComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelaComp.Size = new System.Drawing.Size(936, 192);
            this.dgvRelaComp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(936, 2);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(15, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(936, 2);
            this.label4.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudConteudo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.lblBuscar);
            this.groupBox2.Controls.Add(this.txtConteudo);
            this.groupBox2.Controls.Add(this.cbTipoFiltro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(910, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÁREA DE PESQUISA";
            // 
            // nudConteudo
            // 
            this.nudConteudo.Location = new System.Drawing.Point(490, 32);
            this.nudConteudo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConteudo.Name = "nudConteudo";
            this.nudConteudo.Size = new System.Drawing.Size(307, 23);
            this.nudConteudo.TabIndex = 8;
            this.nudConteudo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConteudo.ValueChanged += new System.EventHandler(this.nudConteudo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "TIPO DE FILTRO POR";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::wfaCelco.Properties.Resources.Search;
            this.btnPesquisar.Location = new System.Drawing.Point(808, 25);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 32);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(424, 35);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(64, 17);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "BUSCAR";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(490, 31);
            this.txtConteudo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(307, 23);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFiltro.FormattingEnabled = true;
            this.cbTipoFiltro.Items.AddRange(new object[] {
            "Todas as fórmulas",
            "Código",
            "Descrição"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(159, 31);
            this.cbTipoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(251, 24);
            this.cbTipoFiltro.TabIndex = 5;
            this.cbTipoFiltro.SelectedValueChanged += new System.EventHandler(this.cbTipoFiltro_SelectedValueChanged);
            // 
            // PPD
            // 
            this.PPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD.Document = this.PD;
            this.PPD.Enabled = true;
            this.PPD.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD.Icon")));
            this.PPD.Name = "PPD";
            this.PPD.Visible = false;
            // 
            // PD
            // 
            this.PD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD_PrintPage);
            // 
            // frmFormulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRelaComp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRelaForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormulas";
            this.Load += new System.EventHandler(this.frmFormulas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaComp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConteudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRelaForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRelaComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAlterarFormula;
        private System.Windows.Forms.Button btnNovaFormula;
        private System.Windows.Forms.Button btnExcluirFormula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private System.Windows.Forms.NumericUpDown nudConteudo;
        private System.Windows.Forms.PrintPreviewDialog PPD;
        private System.Drawing.Printing.PrintDocument PD;
    }
}
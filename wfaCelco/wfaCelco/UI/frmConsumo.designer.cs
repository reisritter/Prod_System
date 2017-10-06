namespace wfaCelco.UI
{
    partial class frmConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsumo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimirRec = new System.Windows.Forms.Button();
            this.btnAlterarConsumo = new System.Windows.Forms.Button();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.gbConsumo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvConsumo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDataReg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDadosItens = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDataIn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQtdeOP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.btnImpDet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodOP = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialogCon = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentCon = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogDet = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentDet = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.gbConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosItens)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodOP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnImprimirRec);
            this.panel1.Controls.Add(this.btnAlterarConsumo);
            this.panel1.Controls.Add(this.btnConsumir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 86);
            this.panel1.TabIndex = 3;
            // 
            // btnImprimirRec
            // 
            this.btnImprimirRec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImprimirRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnImprimirRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnImprimirRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRec.ForeColor = System.Drawing.Color.White;
            this.btnImprimirRec.Image = global::wfaCelco.Properties.Resources.Printer_New;
            this.btnImprimirRec.Location = new System.Drawing.Point(172, 0);
            this.btnImprimirRec.Name = "btnImprimirRec";
            this.btnImprimirRec.Size = new System.Drawing.Size(86, 86);
            this.btnImprimirRec.TabIndex = 3;
            this.btnImprimirRec.Text = "&Imprimir Consumo";
            this.btnImprimirRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirRec.UseVisualStyleBackColor = true;
            this.btnImprimirRec.Click += new System.EventHandler(this.btnImprimirRec_Click);
            // 
            // btnAlterarConsumo
            // 
            this.btnAlterarConsumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAlterarConsumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAlterarConsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAlterarConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarConsumo.ForeColor = System.Drawing.Color.White;
            this.btnAlterarConsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarConsumo.Image")));
            this.btnAlterarConsumo.Location = new System.Drawing.Point(86, 0);
            this.btnAlterarConsumo.Name = "btnAlterarConsumo";
            this.btnAlterarConsumo.Size = new System.Drawing.Size(86, 86);
            this.btnAlterarConsumo.TabIndex = 1;
            this.btnAlterarConsumo.Text = "Alterar Consumo";
            this.btnAlterarConsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarConsumo.UseVisualStyleBackColor = true;
            this.btnAlterarConsumo.Click += new System.EventHandler(this.btnAlterarConsumo_Click);
            // 
            // btnConsumir
            // 
            this.btnConsumir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnConsumir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnConsumir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnConsumir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumir.ForeColor = System.Drawing.Color.White;
            this.btnConsumir.Image = ((System.Drawing.Image)(resources.GetObject("btnConsumir.Image")));
            this.btnConsumir.Location = new System.Drawing.Point(0, 0);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(86, 86);
            this.btnConsumir.TabIndex = 0;
            this.btnConsumir.Text = "Vincular Consumo";
            this.btnConsumir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // gbConsumo
            // 
            this.gbConsumo.Controls.Add(this.label10);
            this.gbConsumo.Controls.Add(this.dgvConsumo);
            this.gbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbConsumo.Location = new System.Drawing.Point(12, 175);
            this.gbConsumo.Name = "gbConsumo";
            this.gbConsumo.Size = new System.Drawing.Size(467, 475);
            this.gbConsumo.TabIndex = 4;
            this.gbConsumo.TabStop = false;
            this.gbConsumo.Text = "Consumo Vinculado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "(Selecione uma linha para visualizar seu detalhe ao lado)";
            // 
            // dgvConsumo
            // 
            this.dgvConsumo.AllowUserToAddRows = false;
            this.dgvConsumo.AllowUserToDeleteRows = false;
            this.dgvConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsumo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsumo.Location = new System.Drawing.Point(15, 41);
            this.dgvConsumo.MultiSelect = false;
            this.dgvConsumo.Name = "dgvConsumo";
            this.dgvConsumo.ReadOnly = true;
            this.dgvConsumo.RowHeadersVisible = false;
            this.dgvConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumo.Size = new System.Drawing.Size(435, 410);
            this.dgvConsumo.TabIndex = 0;
            this.dgvConsumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumo_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblDataReg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvDadosItens);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblDataFim);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblDataIn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblQtdeOP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(485, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 421);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes de consumo / OP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "(un. milheiro)";
            // 
            // lblDataReg
            // 
            this.lblDataReg.AutoSize = true;
            this.lblDataReg.Location = new System.Drawing.Point(305, 41);
            this.lblDataReg.Name = "lblDataReg";
            this.lblDataReg.Size = new System.Drawing.Size(20, 17);
            this.lblDataReg.TabIndex = 16;
            this.lblDataReg.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data de Registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código do Item";
            // 
            // dgvDadosItens
            // 
            this.dgvDadosItens.AllowDrop = true;
            this.dgvDadosItens.AllowUserToAddRows = false;
            this.dgvDadosItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosItens.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosItens.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDadosItens.Enabled = false;
            this.dgvDadosItens.Location = new System.Drawing.Point(19, 255);
            this.dgvDadosItens.Name = "dgvDadosItens";
            this.dgvDadosItens.RowHeadersVisible = false;
            this.dgvDadosItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosItens.Size = new System.Drawing.Size(430, 150);
            this.dgvDadosItens.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Quantidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Nome do Insumo";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(268, 174);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(20, 17);
            this.lblDataFim.TabIndex = 9;
            this.lblDataFim.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Término:";
            // 
            // lblDataIn
            // 
            this.lblDataIn.AutoSize = true;
            this.lblDataIn.Location = new System.Drawing.Point(58, 174);
            this.lblDataIn.Name = "lblDataIn";
            this.lblDataIn.Size = new System.Drawing.Size(20, 17);
            this.lblDataIn.TabIndex = 7;
            this.lblDataIn.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Inicio:";
            // 
            // lblQtdeOP
            // 
            this.lblQtdeOP.AutoSize = true;
            this.lblQtdeOP.Location = new System.Drawing.Point(190, 132);
            this.lblQtdeOP.Name = "lblQtdeOP";
            this.lblQtdeOP.Size = new System.Drawing.Size(20, 17);
            this.lblQtdeOP.TabIndex = 5;
            this.lblQtdeOP.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade Programada:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(84, 85);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(20, 17);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "...";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 17);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "O.P. Nro:";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(89, 41);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(20, 17);
            this.lblOp.TabIndex = 0;
            this.lblOp.Text = "...";
            // 
            // btnImpDet
            // 
            this.btnImpDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImpDet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImpDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnImpDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnImpDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImpDet.ForeColor = System.Drawing.Color.White;
            this.btnImpDet.Location = new System.Drawing.Point(807, 602);
            this.btnImpDet.Name = "btnImpDet";
            this.btnImpDet.Size = new System.Drawing.Size(141, 34);
            this.btnImpDet.TabIndex = 4;
            this.btnImpDet.Text = "Imprimir Detalhe";
            this.btnImpDet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImpDet.UseVisualStyleBackColor = false;
            this.btnImpDet.Click += new System.EventHandler(this.btnImpDet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCodOP);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.cbbTipoFiltro);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Área de Pesquisa";
            // 
            // txtCodOP
            // 
            this.txtCodOP.Location = new System.Drawing.Point(428, 31);
            this.txtCodOP.Name = "txtCodOP";
            this.txtCodOP.Size = new System.Drawing.Size(120, 23);
            this.txtCodOP.TabIndex = 6;
            this.txtCodOP.ValueChanged += new System.EventHandler(this.txtCodOP_ValueChanged);
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
            this.btnRefresh.Location = new System.Drawing.Point(582, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbbTipoFiltro
            // 
            this.cbbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoFiltro.FormattingEnabled = true;
            this.cbbTipoFiltro.Items.AddRange(new object[] {
            "CÓDIGO DA OP"});
            this.cbbTipoFiltro.Location = new System.Drawing.Point(95, 30);
            this.cbbTipoFiltro.Name = "cbbTipoFiltro";
            this.cbbTipoFiltro.Size = new System.Drawing.Size(188, 24);
            this.cbbTipoFiltro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados da busca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca Por:";
            // 
            // printPreviewDialogCon
            // 
            this.printPreviewDialogCon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCon.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogCon.Document = this.printDocumentCon;
            this.printPreviewDialogCon.Enabled = true;
            this.printPreviewDialogCon.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogCon.Icon")));
            this.printPreviewDialogCon.Name = "printPreviewDialogCon";
            this.printPreviewDialogCon.Visible = false;
            // 
            // printDocumentCon
            // 
            this.printDocumentCon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCon_PrintPage);
            // 
            // printPreviewDialogDet
            // 
            this.printPreviewDialogDet.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogDet.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogDet.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogDet.Document = this.printDocumentDet;
            this.printPreviewDialogDet.Enabled = true;
            this.printPreviewDialogDet.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogDet.Icon")));
            this.printPreviewDialogDet.Name = "printPreviewDialogDet";
            this.printPreviewDialogDet.Visible = false;
            // 
            // printDocumentDet
            // 
            this.printDocumentDet.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDet_PrintPage);
            // 
            // frmConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.btnImpDet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbConsumo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsumo";
            this.panel1.ResumeLayout(false);
            this.gbConsumo.ResumeLayout(false);
            this.gbConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosItens)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimirRec;
        private System.Windows.Forms.Button btnAlterarConsumo;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.GroupBox gbConsumo;
        private System.Windows.Forms.DataGridView dgvConsumo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbbTipoFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogCon;
        private System.Drawing.Printing.PrintDocument printDocumentCon;
        private System.Windows.Forms.DataGridView dgvDadosItens;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDataIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQtdeOP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImpDet;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogDet;
        private System.Drawing.Printing.PrintDocument printDocumentDet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtCodOP;
        private System.Windows.Forms.Label label10;
    }
}
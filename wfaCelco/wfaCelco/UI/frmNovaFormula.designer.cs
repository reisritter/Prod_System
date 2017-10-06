namespace wfaCelco.UI
{
    partial class frmPedidoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoNovo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblProdAssoc = new System.Windows.Forms.Label();
            this.cbProdFormula = new System.Windows.Forms.ComboBox();
            this.txtDescFormula = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvComposicao = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarFormula = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudCodForm = new System.Windows.Forms.NumericUpDown();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicao)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(6, 95);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 15);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "DESCRIÇÃO:";
            // 
            // lblProdAssoc
            // 
            this.lblProdAssoc.AutoSize = true;
            this.lblProdAssoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdAssoc.Location = new System.Drawing.Point(6, 65);
            this.lblProdAssoc.Name = "lblProdAssoc";
            this.lblProdAssoc.Size = new System.Drawing.Size(141, 15);
            this.lblProdAssoc.TabIndex = 2;
            this.lblProdAssoc.Text = "PRODUTO ASSOCIADO:";
            // 
            // cbProdFormula
            // 
            this.cbProdFormula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdFormula.FormattingEnabled = true;
            this.cbProdFormula.Location = new System.Drawing.Point(153, 62);
            this.cbProdFormula.Name = "cbProdFormula";
            this.cbProdFormula.Size = new System.Drawing.Size(140, 23);
            this.cbProdFormula.TabIndex = 5;
            this.cbProdFormula.SelectedIndexChanged += new System.EventHandler(this.cbProdFormula_SelectedIndexChanged);
            // 
            // txtDescFormula
            // 
            this.txtDescFormula.Location = new System.Drawing.Point(153, 95);
            this.txtDescFormula.MaxLength = 50;
            this.txtDescFormula.Multiline = true;
            this.txtDescFormula.Name = "txtDescFormula";
            this.txtDescFormula.Size = new System.Drawing.Size(477, 104);
            this.txtDescFormula.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudQtd);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.lblQtd);
            this.groupBox1.Controls.Add(this.cbNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.dgvComposicao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 268);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPOSIÇÃO DA FÓRMULA";
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(367, 36);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(120, 21);
            this.nudQtd.TabIndex = 17;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = global::wfaCelco.Properties.Resources.Delete1;
            this.btnExcluir.Location = new System.Drawing.Point(587, 22);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(53, 35);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(526, 23);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(53, 35);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(274, 38);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(87, 15);
            this.lblQtd.TabIndex = 13;
            this.lblQtd.Text = "QUANTIDADE:";
            // 
            // cbNome
            // 
            this.cbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(59, 35);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(209, 23);
            this.cbNome.TabIndex = 12;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 15);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "NOME:";
            // 
            // dgvComposicao
            // 
            this.dgvComposicao.AllowUserToAddRows = false;
            this.dgvComposicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComposicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComposicao.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComposicao.Location = new System.Drawing.Point(14, 64);
            this.dgvComposicao.Name = "dgvComposicao";
            this.dgvComposicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComposicao.Size = new System.Drawing.Size(626, 191);
            this.dgvComposicao.TabIndex = 0;
            this.dgvComposicao.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvComposicao_EditingControlShowing);
            this.dgvComposicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvComposicao_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnSalvarFormula);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 86);
            this.panel1.TabIndex = 12;
            // 
            // btnSalvarFormula
            // 
            this.btnSalvarFormula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnSalvarFormula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnSalvarFormula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnSalvarFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFormula.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFormula.Image = global::wfaCelco.Properties.Resources.Salvar;
            this.btnSalvarFormula.Location = new System.Drawing.Point(86, 0);
            this.btnSalvarFormula.Name = "btnSalvarFormula";
            this.btnSalvarFormula.Size = new System.Drawing.Size(86, 86);
            this.btnSalvarFormula.TabIndex = 4;
            this.btnSalvarFormula.Text = "&Salvar";
            this.btnSalvarFormula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvarFormula.UseVisualStyleBackColor = true;
            this.btnSalvarFormula.Click += new System.EventHandler(this.btnSalvarFormula_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 86);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudCodForm);
            this.groupBox2.Controls.Add(this.txtCodProd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.lblProdAssoc);
            this.groupBox2.Controls.Add(this.txtDescFormula);
            this.groupBox2.Controls.Add(this.cbProdFormula);
            this.groupBox2.Controls.Add(this.lblDesc);
            this.groupBox2.Location = new System.Drawing.Point(22, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 230);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DA FÓRMULA";
            // 
            // nudCodForm
            // 
            this.nudCodForm.Enabled = false;
            this.nudCodForm.Location = new System.Drawing.Point(153, 35);
            this.nudCodForm.Name = "nudCodForm";
            this.nudCodForm.ReadOnly = true;
            this.nudCodForm.Size = new System.Drawing.Size(120, 21);
            this.nudCodForm.TabIndex = 9;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Location = new System.Drawing.Point(466, 64);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(164, 21);
            this.txtCodProd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "CÓDIGO DO PRODUTO:";
            // 
            // frmPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPedidoNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fórmula >> Nova Fórmula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblProdAssoc;
        private System.Windows.Forms.ComboBox cbProdFormula;
        private System.Windows.Forms.TextBox txtDescFormula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvComposicao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvarFormula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.NumericUpDown nudCodForm;
    }
}
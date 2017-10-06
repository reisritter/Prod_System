namespace wfaCelco.UI
{
    partial class frmAlterarFormula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarFormula));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvarFormula = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCadForm = new System.Windows.Forms.GroupBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.nudCodForm = new System.Windows.Forms.NumericUpDown();
            this.lblCodForm = new System.Windows.Forms.Label();
            this.lblProdAssoc = new System.Windows.Forms.Label();
            this.txtDescFormula = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.gbcomposicao = new System.Windows.Forms.GroupBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.btnExcluirComp = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvComposicao = new System.Windows.Forms.DataGridView();
            this.dgvAux = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbCadForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodForm)).BeginInit();
            this.gbcomposicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarFormula
            // 
            this.btnSalvarFormula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnSalvarFormula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnSalvarFormula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnSalvarFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFormula.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFormula.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFormula.Image")));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvarFormula);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 86);
            this.panel1.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(172, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 86);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbCadForm
            // 
            this.gbCadForm.Controls.Add(this.txtNomeProd);
            this.gbCadForm.Controls.Add(this.txtCodProd);
            this.gbCadForm.Controls.Add(this.lblCodProd);
            this.gbCadForm.Controls.Add(this.nudCodForm);
            this.gbCadForm.Controls.Add(this.lblCodForm);
            this.gbCadForm.Controls.Add(this.lblProdAssoc);
            this.gbCadForm.Controls.Add(this.txtDescFormula);
            this.gbCadForm.Controls.Add(this.lblDesc);
            this.gbCadForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadForm.Location = new System.Drawing.Point(22, 121);
            this.gbCadForm.Name = "gbCadForm";
            this.gbCadForm.Size = new System.Drawing.Size(651, 230);
            this.gbCadForm.TabIndex = 15;
            this.gbCadForm.TabStop = false;
            this.gbCadForm.Text = "DADOS DA FÓRMULA";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Enabled = false;
            this.txtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.Location = new System.Drawing.Point(164, 65);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(150, 22);
            this.txtNomeProd.TabIndex = 18;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.Location = new System.Drawing.Point(477, 64);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(164, 22);
            this.txtCodProd.TabIndex = 17;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(319, 65);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(157, 16);
            this.lblCodProd.TabIndex = 16;
            this.lblCodProd.Text = "CÓDIGO DO PRODUTO:";
            // 
            // nudCodForm
            // 
            this.nudCodForm.Enabled = false;
            this.nudCodForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCodForm.Location = new System.Drawing.Point(164, 35);
            this.nudCodForm.Name = "nudCodForm";
            this.nudCodForm.Size = new System.Drawing.Size(120, 22);
            this.nudCodForm.TabIndex = 15;
            // 
            // lblCodForm
            // 
            this.lblCodForm.AutoSize = true;
            this.lblCodForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodForm.Location = new System.Drawing.Point(6, 37);
            this.lblCodForm.Name = "lblCodForm";
            this.lblCodForm.Size = new System.Drawing.Size(63, 16);
            this.lblCodForm.TabIndex = 0;
            this.lblCodForm.Text = "CÓDIGO:";
            // 
            // lblProdAssoc
            // 
            this.lblProdAssoc.AutoSize = true;
            this.lblProdAssoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdAssoc.Location = new System.Drawing.Point(6, 65);
            this.lblProdAssoc.Name = "lblProdAssoc";
            this.lblProdAssoc.Size = new System.Drawing.Size(160, 16);
            this.lblProdAssoc.TabIndex = 2;
            this.lblProdAssoc.Text = "PRODUTO ASSOCIADO:";
            // 
            // txtDescFormula
            // 
            this.txtDescFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescFormula.Location = new System.Drawing.Point(164, 95);
            this.txtDescFormula.MaxLength = 50;
            this.txtDescFormula.Multiline = true;
            this.txtDescFormula.Name = "txtDescFormula";
            this.txtDescFormula.Size = new System.Drawing.Size(477, 104);
            this.txtDescFormula.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(6, 95);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 16);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "DESCRIÇÃO:";
            // 
            // gbcomposicao
            // 
            this.gbcomposicao.Controls.Add(this.nudQtd);
            this.gbcomposicao.Controls.Add(this.btnExcluirComp);
            this.gbcomposicao.Controls.Add(this.btnAdicionar);
            this.gbcomposicao.Controls.Add(this.lblQtd);
            this.gbcomposicao.Controls.Add(this.cbNome);
            this.gbcomposicao.Controls.Add(this.lblNome);
            this.gbcomposicao.Controls.Add(this.dgvComposicao);
            this.gbcomposicao.Controls.Add(this.dgvAux);
            this.gbcomposicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbcomposicao.Location = new System.Drawing.Point(22, 357);
            this.gbcomposicao.Name = "gbcomposicao";
            this.gbcomposicao.Size = new System.Drawing.Size(651, 268);
            this.gbcomposicao.TabIndex = 14;
            this.gbcomposicao.TabStop = false;
            this.gbcomposicao.Text = "COMPOSIÇÃO DA FÓRMULA";
            // 
            // nudQtd
            // 
            this.nudQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudQtd.Location = new System.Drawing.Point(399, 30);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(120, 23);
            this.nudQtd.TabIndex = 7;
            // 
            // btnExcluirComp
            // 
            this.btnExcluirComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnExcluirComp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnExcluirComp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnExcluirComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnExcluirComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirComp.ForeColor = System.Drawing.Color.White;
            this.btnExcluirComp.Image = global::wfaCelco.Properties.Resources.Delete;
            this.btnExcluirComp.Location = new System.Drawing.Point(587, 22);
            this.btnExcluirComp.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirComp.Name = "btnExcluirComp";
            this.btnExcluirComp.Size = new System.Drawing.Size(53, 35);
            this.btnExcluirComp.TabIndex = 14;
            this.btnExcluirComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirComp.UseVisualStyleBackColor = false;
            this.btnExcluirComp.Click += new System.EventHandler(this.btnExcluirComp_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::wfaCelco.Properties.Resources.Add_New;
            this.btnAdicionar.Location = new System.Drawing.Point(526, 23);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(53, 34);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQtd.Location = new System.Drawing.Point(291, 32);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(102, 17);
            this.lblQtd.TabIndex = 13;
            this.lblQtd.Text = "QUANTIDADE:";
            // 
            // cbNome
            // 
            this.cbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(76, 28);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(209, 24);
            this.cbNome.TabIndex = 12;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNome.Location = new System.Drawing.Point(17, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            // dgvAux
            // 
            this.dgvAux.AllowUserToAddRows = false;
            this.dgvAux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAux.Location = new System.Drawing.Point(14, 64);
            this.dgvAux.Name = "dgvAux";
            this.dgvAux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAux.Size = new System.Drawing.Size(626, 191);
            this.dgvAux.TabIndex = 15;
            // 
            // frmAlterarFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 637);
            this.Controls.Add(this.gbCadForm);
            this.Controls.Add(this.gbcomposicao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlterarFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altera Formula";
            this.panel1.ResumeLayout(false);
            this.gbCadForm.ResumeLayout(false);
            this.gbCadForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodForm)).EndInit();
            this.gbcomposicao.ResumeLayout(false);
            this.gbcomposicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarFormula;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbCadForm;
        private System.Windows.Forms.Label lblCodForm;
        private System.Windows.Forms.Label lblProdAssoc;
        private System.Windows.Forms.TextBox txtDescFormula;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.GroupBox gbcomposicao;
        private System.Windows.Forms.Button btnExcluirComp;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvComposicao;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.NumericUpDown nudCodForm;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.DataGridView dgvAux;
    }
}
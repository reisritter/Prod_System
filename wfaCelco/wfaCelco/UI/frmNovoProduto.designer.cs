namespace wfaCelco.UI
{
    partial class frmNovoProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoProduto));
            this.btnIncluiProd = new System.Windows.Forms.Button();
            this.EPProdutos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelaProd = new System.Windows.Forms.Button();
            this.gbEstoqueAtual = new System.Windows.Forms.GroupBox();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbProdutoEstoque = new System.Windows.Forms.CheckBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EPProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbEstoqueAtual.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncluiProd
            // 
            this.btnIncluiProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnIncluiProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnIncluiProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnIncluiProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnIncluiProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluiProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIncluiProd.Image = global::wfaCelco.Properties.Resources.Save_01_WF;
            this.btnIncluiProd.Location = new System.Drawing.Point(0, 0);
            this.btnIncluiProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncluiProd.Name = "btnIncluiProd";
            this.btnIncluiProd.Size = new System.Drawing.Size(86, 86);
            this.btnIncluiProd.TabIndex = 9;
            this.btnIncluiProd.Text = "Salvar";
            this.btnIncluiProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncluiProd.UseVisualStyleBackColor = false;
            this.btnIncluiProd.Click += new System.EventHandler(this.btnIncluiProd_Click);
            // 
            // EPProdutos
            // 
            this.EPProdutos.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnCancelaProd);
            this.panel1.Controls.Add(this.btnIncluiProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 86);
            this.panel1.TabIndex = 9;
            // 
            // btnCancelaProd
            // 
            this.btnCancelaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCancelaProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCancelaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnCancelaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnCancelaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelaProd.Image = global::wfaCelco.Properties.Resources.Cancel;
            this.btnCancelaProd.Location = new System.Drawing.Point(86, 0);
            this.btnCancelaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelaProd.Name = "btnCancelaProd";
            this.btnCancelaProd.Size = new System.Drawing.Size(86, 86);
            this.btnCancelaProd.TabIndex = 10;
            this.btnCancelaProd.Text = "Cancelar";
            this.btnCancelaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelaProd.UseVisualStyleBackColor = false;
            this.btnCancelaProd.Click += new System.EventHandler(this.btnCancelaProd_Click_1);
            // 
            // gbEstoqueAtual
            // 
            this.gbEstoqueAtual.Controls.Add(this.txtEstoqueAtual);
            this.gbEstoqueAtual.Controls.Add(this.label6);
            this.gbEstoqueAtual.Controls.Add(this.chbProdutoEstoque);
            this.gbEstoqueAtual.Location = new System.Drawing.Point(559, 313);
            this.gbEstoqueAtual.Name = "gbEstoqueAtual";
            this.gbEstoqueAtual.Size = new System.Drawing.Size(215, 88);
            this.gbEstoqueAtual.TabIndex = 26;
            this.gbEstoqueAtual.TabStop = false;
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Enabled = false;
            this.txtEstoqueAtual.Location = new System.Drawing.Point(105, 50);
            this.txtEstoqueAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoqueAtual.MaxLength = 8;
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(87, 22);
            this.txtEstoqueAtual.TabIndex = 14;
            this.txtEstoqueAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEstoqueAtual.EnabledChanged += new System.EventHandler(this.txtEstoqueAtual_EnabledChanged);
            this.txtEstoqueAtual.TextChanged += new System.EventHandler(this.txtEstoqueAtual_TextChanged);
            this.txtEstoqueAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueAtual_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estoque atual:";
            // 
            // chbProdutoEstoque
            // 
            this.chbProdutoEstoque.AutoSize = true;
            this.chbProdutoEstoque.Location = new System.Drawing.Point(9, 18);
            this.chbProdutoEstoque.Name = "chbProdutoEstoque";
            this.chbProdutoEstoque.Size = new System.Drawing.Size(146, 20);
            this.chbProdutoEstoque.TabIndex = 0;
            this.chbProdutoEstoque.Text = "Produto de Estoque";
            this.chbProdutoEstoque.UseVisualStyleBackColor = true;
            this.chbProdutoEstoque.CheckedChanged += new System.EventHandler(this.chbProdutoEstoque_CheckedChanged);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(104, 149);
            this.txtNomeProd.MaxLength = 60;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(670, 22);
            this.txtNomeProd.TabIndex = 16;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(50, 149);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(48, 16);
            this.lblnome.TabIndex = 25;
            this.lblnome.Text = "Nome:";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(6, 49);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(65, 20);
            this.rdbInativo.TabIndex = 8;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.CheckedChanged += new System.EventHandler(this.rdbInativo_CheckedChanged);
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.rdbInativo);
            this.gpbStatus.Controls.Add(this.rdbAtivo);
            this.gpbStatus.Location = new System.Drawing.Point(444, 313);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(109, 88);
            this.gpbStatus.TabIndex = 23;
            this.gpbStatus.TabStop = false;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(6, 17);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(56, 20);
            this.rdbAtivo.TabIndex = 7;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "MATERIA-PRIMA",
            "PRODUTO ACABADO "});
            this.cbxTipo.Location = new System.Drawing.Point(104, 351);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(274, 24);
            this.cbxTipo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(104, 122);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodProduto.MaxLength = 10;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(110, 22);
            this.txtCodProduto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            // 
            // txtCategProd
            // 
            this.txtCategProd.Location = new System.Drawing.Point(104, 318);
            this.txtCategProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategProd.MaxLength = 30;
            this.txtCategProd.Name = "txtCategProd";
            this.txtCategProd.Size = new System.Drawing.Size(274, 22);
            this.txtCategProd.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Categoria:";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(104, 176);
            this.txtDescProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescProd.MaxLength = 50;
            this.txtDescProd.Multiline = true;
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(670, 132);
            this.txtDescProd.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status:";
            // 
            // frmNovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 428);
            this.Controls.Add(this.gbEstoqueAtual);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNovoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.EPProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbEstoqueAtual.ResumeLayout(false);
            this.gbEstoqueAtual.PerformLayout();
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluiProd;
        private System.Windows.Forms.ErrorProvider EPProdutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelaProd;
        private System.Windows.Forms.GroupBox gbEstoqueAtual;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbProdutoEstoque;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.Label label4;
    }
}
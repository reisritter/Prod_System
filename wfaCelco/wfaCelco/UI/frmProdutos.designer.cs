namespace wfaCelco.UI
{
    partial class frmProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnAtualProd = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaProd = new System.Windows.Forms.TextBox();
            this.btnBuscaProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocumentProduto = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogProd = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.gpbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.btnImprime);
            this.panel1.Controls.Add(this.btnAtualProd);
            this.panel1.Controls.Add(this.btnCadProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 86);
            this.panel1.TabIndex = 3;
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::wfaCelco.Properties.Resources.BASKET_2;
            this.btnEstoque.Location = new System.Drawing.Point(172, 0);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(86, 86);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "&Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnImprime
            // 
            this.btnImprime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImprime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnImprime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprime.ForeColor = System.Drawing.Color.White;
            this.btnImprime.Image = global::wfaCelco.Properties.Resources.Printer_New;
            this.btnImprime.Location = new System.Drawing.Point(258, 0);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(86, 86);
            this.btnImprime.TabIndex = 6;
            this.btnImprime.Text = "&Imprimir";
            this.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // btnAtualProd
            // 
            this.btnAtualProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAtualProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAtualProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAtualProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualProd.ForeColor = System.Drawing.Color.White;
            this.btnAtualProd.Image = global::wfaCelco.Properties.Resources.Document_Exchange_01;
            this.btnAtualProd.Location = new System.Drawing.Point(86, 0);
            this.btnAtualProd.Name = "btnAtualProd";
            this.btnAtualProd.Size = new System.Drawing.Size(86, 86);
            this.btnAtualProd.TabIndex = 5;
            this.btnAtualProd.Text = "&Atualizar";
            this.btnAtualProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtualProd.UseVisualStyleBackColor = true;
            this.btnAtualProd.Click += new System.EventHandler(this.btnAtualProd_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCadProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnCadProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadProduto.Image = global::wfaCelco.Properties.Resources.Add_New;
            this.btnCadProduto.Location = new System.Drawing.Point(0, 0);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(86, 86);
            this.btnCadProduto.TabIndex = 4;
            this.btnCadProduto.Text = "&Novo";
            this.btnCadProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.dgvProd);
            this.gpbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduto.Location = new System.Drawing.Point(25, 241);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(906, 409);
            this.gpbProduto.TabIndex = 4;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Lista de Produtos";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProd.Location = new System.Drawing.Point(29, 40);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(861, 346);
            this.dgvProd.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaProd);
            this.groupBox1.Controls.Add(this.btnBuscaProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Produto";
            // 
            // txtBuscaProd
            // 
            this.txtBuscaProd.Location = new System.Drawing.Point(80, 47);
            this.txtBuscaProd.Name = "txtBuscaProd";
            this.txtBuscaProd.Size = new System.Drawing.Size(682, 22);
            this.txtBuscaProd.TabIndex = 1;
            // 
            // btnBuscaProd
            // 
            this.btnBuscaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnBuscaProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnBuscaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnBuscaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnBuscaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProd.Image = global::wfaCelco.Properties.Resources.Search;
            this.btnBuscaProd.Location = new System.Drawing.Point(797, 39);
            this.btnBuscaProd.Name = "btnBuscaProd";
            this.btnBuscaProd.Size = new System.Drawing.Size(75, 39);
            this.btnBuscaProd.TabIndex = 2;
            this.btnBuscaProd.UseVisualStyleBackColor = false;
            this.btnBuscaProd.Click += new System.EventHandler(this.btnBuscaProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // printDocumentProduto
            // 
            this.printDocumentProduto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProduto_PrintPage);
            // 
            // printPreviewDialogProd
            // 
            this.printPreviewDialogProd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProd.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogProd.Document = this.printDocumentProduto;
            this.printPreviewDialogProd.Enabled = true;
            this.printPreviewDialogProd.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogProd.Icon")));
            this.printPreviewDialogProd.Name = "printPreviewDialogProd";
            this.printPreviewDialogProd.Visible = false;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbProduto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.gpbProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnAtualProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaProd;
        private System.Windows.Forms.Button btnBuscaProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprime;
        private System.Drawing.Printing.PrintDocument printDocumentProduto;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogProd;
        public System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button btnEstoque;
    }
}
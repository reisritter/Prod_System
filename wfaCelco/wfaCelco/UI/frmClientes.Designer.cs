namespace wfaCelco.UI
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.Cliente = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAtuaCli = new System.Windows.Forms.Button();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaCli = new System.Windows.Forms.TextBox();
            this.btnBuscaCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocumentCliente = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogCli = new System.Windows.Forms.PrintPreviewDialog();
            this.Cliente.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.Cliente.Controls.Add(this.btnImprimir);
            this.Cliente.Controls.Add(this.btnAtuaCli);
            this.Cliente.Controls.Add(this.btnNovoCli);
            this.Cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cliente.Location = new System.Drawing.Point(0, 0);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(960, 86);
            this.Cliente.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::wfaCelco.Properties.Resources.Printer_New;
            this.btnImprimir.Location = new System.Drawing.Point(172, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 86);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAtuaCli
            // 
            this.btnAtuaCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnAtuaCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnAtuaCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnAtuaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtuaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtuaCli.ForeColor = System.Drawing.Color.White;
            this.btnAtuaCli.Image = global::wfaCelco.Properties.Resources.Document_Exchange_01;
            this.btnAtuaCli.Location = new System.Drawing.Point(86, 0);
            this.btnAtuaCli.Name = "btnAtuaCli";
            this.btnAtuaCli.Size = new System.Drawing.Size(86, 86);
            this.btnAtuaCli.TabIndex = 5;
            this.btnAtuaCli.Text = "&Atualizar";
            this.btnAtuaCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtuaCli.UseVisualStyleBackColor = true;
            this.btnAtuaCli.Click += new System.EventHandler(this.btnAtuaCli_Click);
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnNovoCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnNovoCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnNovoCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCli.ForeColor = System.Drawing.Color.White;
            this.btnNovoCli.Image = global::wfaCelco.Properties.Resources.Add_New;
            this.btnNovoCli.Location = new System.Drawing.Point(0, 0);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(86, 86);
            this.btnNovoCli.TabIndex = 4;
            this.btnNovoCli.Text = "&Novo";
            this.btnNovoCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovoCli.UseVisualStyleBackColor = true;
            this.btnNovoCli.Click += new System.EventHandler(this.btnNovoCli_Click);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.dgvCliente);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(21, 241);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(906, 409);
            this.gpbCliente.TabIndex = 4;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Lista de Clientes";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.Location = new System.Drawing.Point(29, 35);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(861, 346);
            this.dgvCliente.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaCli);
            this.groupBox1.Controls.Add(this.btnBuscaCli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Cliente";
            // 
            // txtBuscaCli
            // 
            this.txtBuscaCli.Location = new System.Drawing.Point(124, 47);
            this.txtBuscaCli.Name = "txtBuscaCli";
            this.txtBuscaCli.Size = new System.Drawing.Size(638, 22);
            this.txtBuscaCli.TabIndex = 1;
            // 
            // btnBuscaCli
            // 
            this.btnBuscaCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnBuscaCli.Image = global::wfaCelco.Properties.Resources.Search;
            this.btnBuscaCli.Location = new System.Drawing.Point(797, 39);
            this.btnBuscaCli.Name = "btnBuscaCli";
            this.btnBuscaCli.Size = new System.Drawing.Size(75, 39);
            this.btnBuscaCli.TabIndex = 2;
            this.btnBuscaCli.UseVisualStyleBackColor = false;
            this.btnBuscaCli.Click += new System.EventHandler(this.btnBuscaCli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAZÃO SOCIAL";
            // 
            // printDocumentCliente
            // 
            this.printDocumentCliente.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCliente_PrintPage);
            // 
            // printPreviewDialogCli
            // 
            this.printPreviewDialogCli.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCli.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCli.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogCli.Document = this.printDocumentCliente;
            this.printPreviewDialogCli.Enabled = true;
            this.printPreviewDialogCli.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogCli.Icon")));
            this.printPreviewDialogCli.Name = "printPreviewDialogCli";
            this.printPreviewDialogCli.Visible = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.Cliente);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.Cliente.ResumeLayout(false);
            this.gpbCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cliente;
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button btnAtuaCli;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaCli;
        private System.Windows.Forms.Button btnBuscaCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocumentCliente;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogCli;
    }
}
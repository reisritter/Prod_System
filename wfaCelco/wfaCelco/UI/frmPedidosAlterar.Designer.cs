﻿namespace wfaCelco.UI
{
    partial class frmPedidosAlterar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosAlterar));
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComposicao = new System.Windows.Forms.DataGridView();
            this.dgvAux = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbProdNome = new System.Windows.Forms.ComboBox();
            this.lblProdAssoc = new System.Windows.Forms.Label();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.dtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCodPed = new System.Windows.Forms.NumericUpDown();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodPed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(458, 31);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(63, 21);
            this.nudQtd.TabIndex = 17;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(377, 35);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(81, 13);
            this.lblQtd.TabIndex = 13;
            this.lblQtd.Text = "QUANTIDADE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SELECIONE O PRODUTO:";
            // 
            // dgvComposicao
            // 
            this.dgvComposicao.AllowUserToAddRows = false;
            this.dgvComposicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComposicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComposicao.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvAux.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudQtd);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.lblQtd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvComposicao);
            this.groupBox1.Controls.Add(this.cbProdNome);
            this.groupBox1.Controls.Add(this.dgvAux);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 268);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ITENS DO PEDIDO";
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
            this.btnAdicionar.Location = new System.Drawing.Point(529, 23);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(53, 35);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbProdNome
            // 
            this.cbProdNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdNome.FormattingEnabled = true;
            this.cbProdNome.Location = new System.Drawing.Point(151, 32);
            this.cbProdNome.Name = "cbProdNome";
            this.cbProdNome.Size = new System.Drawing.Size(220, 21);
            this.cbProdNome.TabIndex = 11;
            // 
            // lblProdAssoc
            // 
            this.lblProdAssoc.AutoSize = true;
            this.lblProdAssoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdAssoc.Location = new System.Drawing.Point(6, 76);
            this.lblProdAssoc.Name = "lblProdAssoc";
            this.lblProdAssoc.Size = new System.Drawing.Size(143, 15);
            this.lblProdAssoc.TabIndex = 2;
            this.lblProdAssoc.Text = "SELECIONE O CLIENTE:";
            // 
            // txtCliNome
            // 
            this.txtCliNome.Enabled = false;
            this.txtCliNome.Location = new System.Drawing.Point(165, 75);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.Size = new System.Drawing.Size(246, 20);
            this.txtCliNome.TabIndex = 16;
            // 
            // dtDataEntrega
            // 
            this.dtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntrega.Location = new System.Drawing.Point(370, 32);
            this.dtDataEntrega.Name = "dtDataEntrega";
            this.dtDataEntrega.Size = new System.Drawing.Size(97, 20);
            this.dtDataEntrega.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "DATA DE ENTREGA:";
            // 
            // nudCodPed
            // 
            this.nudCodPed.Enabled = false;
            this.nudCodPed.Location = new System.Drawing.Point(165, 35);
            this.nudCodPed.Name = "nudCodPed";
            this.nudCodPed.ReadOnly = true;
            this.nudCodPed.Size = new System.Drawing.Size(73, 20);
            this.nudCodPed.TabIndex = 9;
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(554, 73);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(73, 20);
            this.txtCliCod.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "CÓDIGO DO CLIENTE:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCliNome);
            this.groupBox2.Controls.Add(this.dtDataEntrega);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudCodPed);
            this.groupBox2.Controls.Add(this.txtCliCod);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.lblProdAssoc);
            this.groupBox2.Location = new System.Drawing.Point(21, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 116);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO PEDIDO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnSalvarPedido);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 86);
            this.panel1.TabIndex = 21;
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnSalvarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnSalvarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnSalvarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPedido.ForeColor = System.Drawing.Color.White;
            this.btnSalvarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarPedido.Image")));
            this.btnSalvarPedido.Location = new System.Drawing.Point(86, 0);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(86, 86);
            this.btnSalvarPedido.TabIndex = 4;
            this.btnSalvarPedido.Text = "&Salvar";
            this.btnSalvarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvarPedido.UseVisualStyleBackColor = true;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
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
            // frmPedidosAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPedidosAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodPed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvComposicao;
        private System.Windows.Forms.DataGridView dgvAux;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProdNome;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Label lblProdAssoc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.DateTimePicker dtDataEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCodPed;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
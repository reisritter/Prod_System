namespace wfaCelco.UI
{
    partial class frmEstoqueProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueProd));
            this.btnSalvaEstoque = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelaCli = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbCorrecao = new System.Windows.Forms.RadioButton();
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.lblNovaQtde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvaEstoque
            // 
            this.btnSalvaEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnSalvaEstoque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnSalvaEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnSalvaEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnSalvaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvaEstoque.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvaEstoque.Image = global::wfaCelco.Properties.Resources.Save_01_WF;
            this.btnSalvaEstoque.Location = new System.Drawing.Point(331, 0);
            this.btnSalvaEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvaEstoque.Name = "btnSalvaEstoque";
            this.btnSalvaEstoque.Size = new System.Drawing.Size(86, 86);
            this.btnSalvaEstoque.TabIndex = 2;
            this.btnSalvaEstoque.Text = "Salvar";
            this.btnSalvaEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvaEstoque.UseVisualStyleBackColor = false;
            this.btnSalvaEstoque.Click += new System.EventHandler(this.btnSalvaEstoque_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btnCancelaCli);
            this.panel1.Controls.Add(this.btnSalvaEstoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 86);
            this.panel1.TabIndex = 15;
            // 
            // btnCancelaCli
            // 
            this.btnCancelaCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCancelaCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.btnCancelaCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnCancelaCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnCancelaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaCli.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelaCli.Image = global::wfaCelco.Properties.Resources.Cancel;
            this.btnCancelaCli.Location = new System.Drawing.Point(0, 0);
            this.btnCancelaCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelaCli.Name = "btnCancelaCli";
            this.btnCancelaCli.Size = new System.Drawing.Size(86, 86);
            this.btnCancelaCli.TabIndex = 1;
            this.btnCancelaCli.Text = "Cancelar";
            this.btnCancelaCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelaCli.UseVisualStyleBackColor = false;
            this.btnCancelaCli.Click += new System.EventHandler(this.btnCancelaCli_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblQtde.Location = new System.Drawing.Point(148, 133);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(15, 15);
            this.lblQtde.TabIndex = 23;
            this.lblQtde.Text = "--";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(148, 106);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(15, 15);
            this.lblNomeProduto.TabIndex = 22;
            this.lblNomeProduto.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(61, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome do Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lançar como:";
            // 
            // rdbCorrecao
            // 
            this.rdbCorrecao.AutoSize = true;
            this.rdbCorrecao.Checked = true;
            this.rdbCorrecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorrecao.Location = new System.Drawing.Point(131, 22);
            this.rdbCorrecao.Name = "rdbCorrecao";
            this.rdbCorrecao.Size = new System.Drawing.Size(139, 19);
            this.rdbCorrecao.TabIndex = 3;
            this.rdbCorrecao.TabStop = true;
            this.rdbCorrecao.Text = "Correção de estoque";
            this.rdbCorrecao.UseVisualStyleBackColor = true;
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompra.Location = new System.Drawing.Point(131, 45);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(133, 19);
            this.rdbCompra.TabIndex = 20;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Compra novos itens";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // lblNovaQtde
            // 
            this.lblNovaQtde.AutoSize = true;
            this.lblNovaQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaQtde.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNovaQtde.Location = new System.Drawing.Point(135, 116);
            this.lblNovaQtde.Name = "lblNovaQtde";
            this.lblNovaQtde.Size = new System.Drawing.Size(15, 15);
            this.lblNovaQtde.TabIndex = 19;
            this.lblNovaQtde.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nova Quantidade:";
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(229, 79);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(26, 24);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(205, 79);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(26, 24);
            this.btnMais.TabIndex = 5;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(131, 82);
            this.txtAdd.MaxLength = 5;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdd.Size = new System.Drawing.Size(69, 20);
            this.txtAdd.TabIndex = 4;
            this.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdd.WordWrap = false;
            this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
            this.txtAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adicionar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdbCorrecao);
            this.groupBox1.Controls.Add(this.rdbCompra);
            this.groupBox1.Controls.Add(this.lblNovaQtde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnMenos);
            this.groupBox1.Controls.Add(this.btnMais);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(51, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 165);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // frmEstoqueProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 346);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstoqueProd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque dos Produtos";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvaEstoque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelaCli;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbCorrecao;
        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.Label lblNovaQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
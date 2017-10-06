using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCelco.UI
{
    public partial class frmTelaPrincipal : Form
    {

        private Form form = new Form(); //  estanciei esta variavel para chamar os forms, ok? 


        public frmTelaPrincipal()
        {
            InitializeComponent();
            form.Close();
            form = new frmInicial();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
            //form?.Close();
            form.Close();
            form = new frmClientes();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
            //form?.Close();
            form.Close();
            form = new frmProdutos();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
            //form?.Close();
            form.Close();
            form = new frmPedidos();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
           // form?.Close();
            form.Close();
            form = new frmProducao();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }


        private void btnRecursos_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
            //form?.Close();
            form.Close();
            form = new frmRecursos();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnFormulas_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
            //form?.Close();
            form.Close();
            form = new frmFormulas();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Sistema ?", "M E N S A G E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            // código para chamar um form dentro do Panel -> pnlForms
            //form?.Close();
            form.Close();
            form = new frmConsumo();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            form.Close();
            form = new frmSuporte();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form.Close();
            form = new frmInicial();
            form.TopLevel = false;
            pnlForms.Controls.Add(form);
            form.Show();
        }
    }
}

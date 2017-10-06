using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaCelco.BLL;

namespace wfaCelco.UI
{
    public partial class frmCadastroCli : Form
    {
        private readonly ClienteBLL cliBll = new ClienteBLL();

        private Cliente cliente;

        public class Cliente
        {
            public int id;
            public string razao;
            public string nome;
            public string rua;
            public string telefone;
            public string tipo;
            public string numero;
            public string cep;
            public string bairro;
            public string cidade;
            public string uf;
            public string comp;
            public string cnpj;
            public string email;

            public Cliente()
            {

            }

            public Cliente(int id)
            {
                this.id = id;
            }
        }

        public frmCadastroCli()
        {
            InitializeComponent();
            txtRazao.Focus(); 
        }

        public frmCadastroCli(string id)
        {

            cliente = cliBll.buscaCliById(int.Parse(id));

            InitializeComponent();
            carregarDadosDoUpdate();
            txtRazao.Focus();
        }

       private void txtRazao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
                 e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à' 
                 && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è' 
                 && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó' 
                 && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç' 
                 && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
                e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à'
                && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è'
                && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó'
                && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç'
                && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
            {
                MessageBox.Show("Digite apenas números!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à'
               && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è'
               && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó'
               && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç'
               && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à'
               && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è'
               && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó'
               && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç'
               && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à'
               && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è'
               && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó'
               && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç'
               && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a') || (e.KeyChar > 'z'))
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void carregarDadosDoUpdate()
        {
            txtBairro.Text = cliente.bairro;
            txtCep.Text = cliente.cep;
            txtCidade.Text = cliente.cidade;
            txtCnpj.Text = cliente.cnpj;
            txtComp.Text = cliente.comp;
            txtEmail.Text = cliente.email;
            txtNome.Text = cliente.nome;
            txtNum.Text = cliente.numero;
            txtRazao.Text = cliente.razao;
            txtRua.Text = cliente.rua;
            txtTel.Text = cliente.telefone;
            txtTipo.Text = cliente.tipo;
            txtUf.Text = cliente.uf;
        }

        private bool valida()
        {
            bool bStatus = false;

            if (txtRazao.Text == "")
            {
                EPCliente.SetError(txtRazao, "Preencha este campo!");
                txtRazao.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtRazao, "");

            if (txtBairro.Text == "")
            {
                EPCliente.SetError(txtBairro, "Preencha este campo!");
                txtBairro.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtBairro, "");

            if (txtCep.Text == "")
            {
                EPCliente.SetError(txtCep, "Preencha este campo!");
                txtCep.Focus();
                bStatus = true;
            }
            else
                EPCliente.SetError(txtCep, "");

            if (txtCidade.Text == "")
            {
                EPCliente.SetError(txtCidade, "Preencha este campo!");
                txtCidade.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtCidade, "");

            if (txtCnpj.Text == "")
            {
                EPCliente.SetError(txtCnpj, "Preencha este campo!");
                txtCnpj.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtCnpj, "");

            if (txtComp.Text == "")
            {
                EPCliente.SetError(txtComp, "Preencha este campo!");
                txtComp.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtComp, "");

            if (txtEmail.Text == "")
            {
                EPCliente.SetError(txtEmail, "Preencha este campo!");
                txtEmail.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtEmail, "");

            if (txtNome.Text == "")
            {
                EPCliente.SetError(txtNome, "Preencha este campo!");
                txtNome.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtNome, "");

            if (txtNum.Text == "")
            {
                EPCliente.SetError(txtNum, "Preencha este campo!");
                txtNum.Focus();
                bStatus = true;
            }
            else
                EPCliente.SetError(txtNum, "");

            if (txtRua.Text == "")
            {
                EPCliente.SetError(txtRua, "Preencha este campo!");
                txtRua.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtRua, "");

            if (txtTel.Text ==  "")
            {
                EPCliente.SetError(txtTel, "Preencha este campo!");
                txtTel.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtTel, "");

            if (txtTipo.Text == "")
            {
                EPCliente.SetError(txtTipo, "Preencha este campo!");
                txtTipo.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtTipo, "");

            if (txtUf.Text == "")
            {
                EPCliente.SetError(txtUf, "Preencha todos os campos");
                txtUf.Focus(); 
                bStatus = true;
            }
            else
                EPCliente.SetError(txtUf, ""); 

            return bStatus; 
        }

        private void btnIncluiCli_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (cliente == null)
            {
                //INSERT
                DialogResult answer1 = MessageBox.Show("Deseja inserir este cliente?", "", MessageBoxButtons.YesNo);

                if (answer1 == DialogResult.Yes)
                {
                    cliBll.inserirCli(txtRazao.Text, txtCnpj.Text, txtNome.Text, txtEmail.Text, txtTel.Text, txtCep.Text, txtRua.Text, txtTipo.Text, txtCidade.Text, txtBairro.Text, txtComp.Text, txtNum.Text, txtUf.Text);
                    MessageBox.Show("Cliente inserido com sucesso!");
                    DialogResult answer2 = MessageBox.Show("Deseja inserir outro cliente?", "", MessageBoxButtons.YesNo);

                    if (answer2 == DialogResult.Yes)
                    {
                        txtBairro.Text = "";
                        txtCep.Text = "";
                        txtCidade.Text = "";
                        txtCnpj.Text = "";
                        txtComp.Text = "";
                        txtEmail.Text = "";
                        txtNome.Text = "";
                        txtNum.Text = "";
                        txtRazao.Text = "";
                        txtRua.Text = "";
                        txtTel.Text = "";
                        txtTipo.Text = "";
                        txtUf.Text = "";
                        txtRazao.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    txtRazao.Focus();
                }
            }
            else
            {
                //UPDATE
                DialogResult answer1 = MessageBox.Show("Deseja atualizar este cliente?", "", MessageBoxButtons.YesNo);

                if (answer1 == DialogResult.Yes)
                {
                    cliBll.atualizarCli(cliente.id, txtRazao.Text, txtCnpj.Text, txtNome.Text, txtEmail.Text, txtTel.Text, txtCep.Text, txtRua.Text, txtTipo.Text, txtCidade.Text, txtBairro.Text, txtComp.Text, txtNum.Text, txtUf.Text);
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    txtRazao.Focus();
                }
            }
        }

        private void btnCancelaCli_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}

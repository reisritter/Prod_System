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
using wfaCelco.DTO;

namespace wfaCelco.UI
{
    public partial class frmRecursoNovo : Form
    {
        RecursosBLL bll = new RecursosBLL();
        RecursosDTO dto;

        private Recursos recurso;

        public class Recursos
        {
            public int id;
            public string tipo_recurso;
            public string nome_recurso;
            public int qtde_recurso ;

            public Recursos(){}

            public Recursos(int id){this.id = id;}
        }

        private bool validaCampos()
        {
            bool bstatus = false;
            if(txtNomeRec.Text == "")
            {
                errorProvider.SetError(txtNomeRec, "Preencha o campo [NOME DO RECURSO]");
                txtNomeRec.Focus();
                bstatus = true;
            }
            if(txtQtde.Value == 0)
            {
                errorProvider.SetError(txtQtde, "Preencha o campo [QUANTIDADE DE RECURSO]/ndiferente de 0 (zero)");
                txtQtde.Focus();
                bstatus = true;
            }
            return bstatus;
        }

        private void carregarDados()
        {
            txtNomeRec.Text = recurso.nome_recurso;
            txtQtde.Value = recurso.qtde_recurso;
            cbbTipoRec.SelectedItem = recurso.tipo_recurso;
        }

        public void LimpaCampos()
        {
            txtNomeRec.Text = "";
            cbbTipoRec.SelectedIndex = 0;
            txtQtde.ResetText();
        }

        public frmRecursoNovo()
        {
            InitializeComponent();
            cbbTipoRec.SelectedIndex = 0;
        }

        public frmRecursoNovo(string id)
        {
            recurso = bll.buscaRecById(int.Parse(id));
            InitializeComponent();            
            carregarDados();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarRec_Click(object sender, EventArgs e)
        {
            dto = new RecursosDTO();
            //VALIDA CAMPOS
            if(validaCampos())
            {
                MessageBox.Show("Preencha os campos corretamente", "ATENÇÃO [MENSAGEM]");
                return;
            }
            if (recurso == null)
            {
                //INSERÇÃO DE NOVO RECURSO
                dto.Recurso_nome = txtNomeRec.Text.Trim();
                dto.Recurso_tipo = cbbTipoRec.SelectedItem.ToString();
                dto.Recurso_qtde = Int32.Parse(txtQtde.Text);
                bll.InsereRecurso(dto);
                MessageBox.Show("Cadastro de Recurso realizado com sucesso!!");
                if (MessageBox.Show("Deseja Cadastrar mais outro Recurso?", "ATENÇÃO [MENSAGEM]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpaCampos();
                    cbbTipoRec.Focus();
                }
                else
                    this.Close();
            }
            else
            {
                //ALTERAÇÃO DE NOVO RECURSO
                //frmRecursoNovo frm = new frmRecursoNovo();
                
                this.Text = "Recursos >> Alterar Recursos";
                dto.Recurso_id = recurso.id;
                dto.Recurso_nome = txtNomeRec.Text;
                dto.Recurso_tipo = cbbTipoRec.SelectedItem.ToString();
                dto.Recurso_qtde = Int32.Parse(txtQtde.Value.ToString());
                bll.AlteraRecurso(dto);
                MessageBox.Show("Cadastro de Recurso alterado com sucesso!!");
                this.Close();
            }
        }
    }
}

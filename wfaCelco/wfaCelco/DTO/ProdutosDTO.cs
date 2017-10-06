using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class ProdutosDTO
    {
        private int    PRODUTO_ID;
        private string PRODUTO_DESCRICAO;
        private string PRODUTO_CATEGORIA;
        private string PRODUTO_TIPO;
        private string PRODUTO_STATUS;

        public int codigo
        {
            get
            {
                return PRODUTO_ID;
            }
            set
            {
                PRODUTO_ID = value;
            }
        }

        public string descricao
        {
            get
            {
                return PRODUTO_DESCRICAO;
            }
            set
            {
                PRODUTO_DESCRICAO = value;
            }
        }

        public string categoria
        {
            get
            {
                return PRODUTO_CATEGORIA;
            }
            set
            {
                PRODUTO_CATEGORIA = value;
            }
        }

        public string tipo
        {
            get
            {
                return PRODUTO_TIPO;
            }
            set
            {
                PRODUTO_TIPO= value;
            }
        }

        public string status
        {
            get
            {
                return PRODUTO_STATUS;
            }
            set
            {
                PRODUTO_STATUS= value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class ProducaoDTO
    {
        private int producao_id;
        private string producao_data_inicio;
        private string producao_data_fim;
        private int producao_qtd;
        private string producao_status;
        private string producao_data_reg;
        private string producao_obs;
        private int produto_id;
        private int formula_id;
        private int pedido_id;

        public int FORM
        {
            get
            {
                return formula_id;
            }
            set
            {
                formula_id = value;
            }
        }

        public int Producao_id
        {
            get
            {
                return producao_id;
            }

            set
            {
                producao_id = value;
            }
        }

        public string Producao_data_inicio
        {
            get
            {
                return producao_data_inicio;
            }

            set
            {
                producao_data_inicio = value;
            }
        }

        public string Producao_data_fim
        {
            get
            {
                return producao_data_fim;
            }

            set
            {
                producao_data_fim = value;
            }
        }

        public int Producao_qtd
        {
            get
            {
                return producao_qtd;
            }

            set
            {
                producao_qtd = value;
            }
        }

        public string Producao_data_reg
        {
            get
            {
                return producao_data_reg;
            }

            set
            {
                producao_data_reg = value;
            }
        }

        public string Producao_status
        {
            get
            {
                return producao_status;
            }

            set
            {
                producao_status = value;
            }
        }

        public int Produto_id
        {
            get
            {
                return produto_id;
            }

            set
            {
                produto_id = value;
            }
        }

        public string Producao_obs
        {
            get
            {
                return producao_obs;
            }

            set
            {
                producao_obs = value;
            }
        }

        public int Pedido_id
        {
            get
            {
                return pedido_id;
            }

            set
            {
                pedido_id = value;
            }
        }
    }
}

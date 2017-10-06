using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class ConsumoDTO
    {
        private int consumo_id;
        private string consumo_data;
        private int consumo_qtde;
        private int local_id;
        private int produto_id;
        private int producao_id;

        public int Consumo_id
        {
            get
            {
                return consumo_id;
            }

            set
            {
                consumo_id = value;
            }
        }

        public string Consumo_data
        {
            get
            {
                return consumo_data;
            }

            set
            {
                consumo_data = value;
            }
        }

        public int Consumo_qtde
        {
            get
            {
                return consumo_qtde;
            }

            set
            {
                consumo_qtde = value;
            }
        }

        public int Local_id
        {
            get
            {
                return local_id;
            }

            set
            {
                local_id = value;
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
    }
}

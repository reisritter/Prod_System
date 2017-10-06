using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class ItemPedidoDTO
    {

        private int PEDIDO_ID;
        private int PRODUTO_ID;
        private int ITEM_QTD;

        public int codigo_pedido
        {
            get
            {
                return PEDIDO_ID;
            }

            set
            {
                PEDIDO_ID = value;
            }
        }

        public int codigo_prod
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

        public int quantidade
        {
            get
            {
                return ITEM_QTD;
            }
            set
            {
                ITEM_QTD = value;
            }
        }
    }
}

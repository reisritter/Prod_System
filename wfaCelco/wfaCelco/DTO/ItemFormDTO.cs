using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class ItemFormDTO
    {

        private int FORMULA_ID;
        private int PRODUTO_ID;
        private int FORMULA_ITEM_QTD;

        public int codigo_form
        {
            get
            {
                return FORMULA_ID;
            }

            set
            {
                FORMULA_ID = value;
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
                return FORMULA_ITEM_QTD;
            }
            set
            {
                FORMULA_ITEM_QTD = value;
            }
        }
    }
}

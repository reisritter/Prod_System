using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class ItemRecDTO
    {
        private int quantidade;
        private int Recurso_ID;
        private int Producao_ID;

        public int REC_ID
        {
            get
            {
                return Recurso_ID;
            }
            set
            {
                Recurso_ID = value;
            }
        }

        public int PROD_ID
        {
            get
            {
                return Producao_ID;
            }
            set
            {
                Producao_ID = value;
            }
        }

        public int QTD
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
            }
        }
    }
}

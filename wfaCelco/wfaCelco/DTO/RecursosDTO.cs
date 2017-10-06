using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class RecursosDTO
    {
        private int recurso_id;
        private string recurso_tipo;
        private string recurso_nome;
        private int recurso_qtde;

        public int Recurso_id
        {
            get
            {
                return recurso_id;
            }

            set
            {
                recurso_id = value;
            }
        }

        public string Recurso_tipo
        {
            get
            {
                return recurso_tipo;
            }

            set
            {
                recurso_tipo = value;
            }
        }

        public string Recurso_nome
        {
            get
            {
                return recurso_nome;
            }

            set
            {
                recurso_nome = value;
            }
        }

        public int Recurso_qtde
        {
            get
            {
                return recurso_qtde;
            }

            set
            {
                recurso_qtde = value;
            }
        }
    }
}

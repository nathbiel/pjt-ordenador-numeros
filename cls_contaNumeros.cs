using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_ordenador_numeros
{
    class cls_contaNumeros
    {
        public int numero;
        public cls_contaNumeros(int n)
        {
            numero = n;
        }
        public bool quantNumeros()
        {
            if(numero<0||numero>10)
                return true;
            else
                return false;
        }

    }
}

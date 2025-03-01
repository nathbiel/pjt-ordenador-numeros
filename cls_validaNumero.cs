using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_ordenador_numeros
{
    class cls_validaNumero
    {
        public string numero;

        public bool validaInteiro()
        {
            if (int.TryParse(numero, out int num))
                return true;
            else
                return false;
        }
        
    }
}

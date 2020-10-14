using Calcular__Notas.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular__Notas.Negocio
{
    class clsSuma
    {
        public Boolean entrar(Suma l)
        {
            if (l.User.Equals("william") && l.Pass.Equals("123"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Double suma(Suma s)
        {
            Double total = s.Dato1 + s.Dato2 ;

            return total;
        }
       // esto es un comentario


        }

}

using Calcular__Notas.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular__Notas.Negocio
{
    class clsLoguin
    {
        public Double cal1(Loguin log1)
        {
            Double total1 = (log1.Lab1 * 0.4) + (log1.Par1 * 0.6);

            return total1;
        }

        public Double cal2(Loguin log2)
        {
            Double total2 = (log2.Lab2 * 0.4) + (log2.Par2 * 0.6);

            return total2;

        }
        public Double cal3(Loguin log3)
        {
            Double total3 = (log3.Lab3 * 0.4) + (log3.Par3 * 0.6);

            return total3;
        }
        public Double calF(Loguin logF)
        {
            Double totalF = (logF.Nota1 + logF.Nota2 + logF.Nota3) /3 ;

            return totalF;
        }

        public Boolean apro(Loguin logA)
        {
            Double result = (logA.Nota1 + logA.Nota2 + logA.Nota3) / 3;

            return result > 6.0 ;
        }
      

    }
}

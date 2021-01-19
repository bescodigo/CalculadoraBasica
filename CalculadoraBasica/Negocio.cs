using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraBasica
{
    /**
     *  Manejo de los valores introducidos por el usuario. 
     */
    public class Negocio
    {
        public Operacion operacion = new Operacion();

        public void ValoresIntroducidos(string numIn)
        {
            if (operacion.OpActivado == false)
            {
                operacion.Num1 += numIn;

            }
            else
            {
                operacion.Num2 += numIn;

            }

        }


    }
}

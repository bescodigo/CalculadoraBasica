using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    /**
     *  Esta clase trata de proporcionar las caracteristicas basicas de una operación,
     *  siendo ésta compuesta por dos valores y un operador, 
     *  ademas de un resultado y un booleano para saber si el operador a sido ingresado.
     */
    public class Operacion
    {
        //  Valores que ingresa el usuario.
        private string num1;
        private string num2;

        //  Esos valores luego se convertiran en double.
        private double Dnum1;
        private double Dnum2;

        //  El operador.
        private string op;
        private bool opActivado;

        
        private string resultado;


        public string Num1 { get => num1; set => num1 = value; }
        public string Num2 { get => num2; set => num2 = value; }
        public string Op { get => op; set => op = value; }
        public bool OpActivado { get => opActivado; set => opActivado = value; }
        public string Result { get => resultado; set => resultado = value; }


        //  El estado inicial de un objeto operación.
        public Operacion()
        {
            num1 = "0";
            num2 = "0";
            op = "";
            opActivado = false;
            Result = "0";
        }

        private void ConvertirADouble()
        {
            Dnum1 = Convert.ToDouble(Num1);
            Dnum2 = Convert.ToDouble(Num2);
        }

        /** 
         * Metodos que componen las diferentes operaciones que se 
         * podran realizar con esta clase.
         */
        public Double Suma() 
        {
            ConvertirADouble();
            return (Dnum1 + Dnum2);
        }

        public Double Resta()
        {
            ConvertirADouble();
            return (Dnum1 - Dnum2);
        }

        public Double Division()
        {
            ConvertirADouble();
            if (Dnum2 != 0)
            {
                return (Dnum1 / Dnum2);
            }
            return Dnum1;
        }

        public Double Multiplicar()
        {
            ConvertirADouble();
            if (Dnum2 != 0)
            {
                return (Dnum1 * Dnum2);
            }
            return Dnum1;
        }

        public Double Porciento()
        {
            ConvertirADouble();
            if (Dnum2 != 0)
            {
                return (Dnum1 * Dnum2) / 100;
            }
            return Dnum1;
        }

    }
}

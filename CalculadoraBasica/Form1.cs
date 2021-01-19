using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Negocio negocio = new Negocio();


        //  Guarda los valores y operadores ingresados 
        //  para mostrarlos en la pantalla de la calculadora.
        string acumulaValoresIntroducidos;

        
        /** 
         *   Guarda el operador y verifica si es el primera operador ingreasado.
         *   Si ya se a ingresado un operador, realiza la operacion en base a el primero
         *   y guarda este segundo que se acaba de ingreasar.
         */
        public void AgregarOperador(string oper)
        {
            negocio.operacion.OpActivado = true;

            if (negocio.operacion.Op != "")
            {
                Calcular();
            }

            negocio.operacion.Op = oper;

            acumulaValoresIntroducidos += oper;

            Calcular();
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            AgregarOperador(btnSuma.Text);
            
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            AgregarOperador(btnResta.Text);
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            AgregarOperador(btnDivicion.Text);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            AgregarOperador(btnMultiplicar.Text);
        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            AgregarOperador(btnPorciento.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calcular();

        }


        //  Realiza la operación en base al operador.
        public void Calcular()
        {
            //  Limpia la Pantalla.
            Calculadora.Items.Clear();

            // Limpia el acumulador de caracteres.
            acumulaValoresIntroducidos = string.Empty;


            switch (negocio.operacion.Op)
            {
                case "+":
                    negocio.operacion.Result = negocio.operacion.Suma().ToString();
                    MostrarResultado(negocio.operacion.Op);
                    break;
                case "-":
                    negocio.operacion.Result = negocio.operacion.Resta().ToString();
                    MostrarResultado(negocio.operacion.Op);
                    break;
                case "/":
                    negocio.operacion.Result = negocio.operacion.Division().ToString();
                    MostrarResultado(negocio.operacion.Op);
                    break;
                case "*":
                    negocio.operacion.Result = negocio.operacion.Multiplicar().ToString();
                    MostrarResultado(negocio.operacion.Op);
                    break;

                case "%":
                    negocio.operacion.Result = negocio.operacion.Porciento().ToString();
                    MostrarResultado(negocio.operacion.Op);
                    break;


                default:
                    break;
            }

            negocio.operacion.Num2 = "0";
        }


        /**
         * Toma el valor del resultado de la operación y lo muestra en pantalla.
         * Y continua guardando los caracteres ingresados para mostrar en la siguiente operación.
         */
        public void MostrarResultado(string op)
        {
            negocio.operacion.Num1 = negocio.operacion.Result;
            Calculadora.Items.Insert(0, negocio.operacion.Result);
            acumulaValoresIntroducidos = negocio.operacion.Result.ToString() + op;
        }

        //  Muestra la operación asta antes de apretar el boton "=" Igual.
        public void MostrarProcedimiento(string valor)
        {
            Calculadora.Items.Clear();

            acumulaValoresIntroducidos += valor;

            Calculadora.Items.Insert(0, acumulaValoresIntroducidos);
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnCero.Text);
            MostrarProcedimiento(btnCero.Text);
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnUno.Text);
            MostrarProcedimiento(btnUno.Text);
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnDos.Text);
            MostrarProcedimiento(btnDos.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnTres.Text);
            MostrarProcedimiento(btnTres.Text);
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnCuatro.Text);
            MostrarProcedimiento(btnCuatro.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnCinco.Text);
            MostrarProcedimiento(btnCinco.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnSeis.Text);
            MostrarProcedimiento(btnSeis.Text);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnSiete.Text);
            MostrarProcedimiento(btnSiete.Text);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnOcho.Text);
            MostrarProcedimiento(btnOcho.Text);
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnNueve.Text);
            MostrarProcedimiento(btnNueve.Text);
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            negocio.ValoresIntroducidos(btnPunto.Text);
            MostrarProcedimiento(btnPunto.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            negocio.operacion.Num1 = "0";
            negocio.operacion.Num2 = "0";
            negocio.operacion.Op = string.Empty;
            negocio.operacion.OpActivado = false;
            Calculadora.Items.Clear();
            acumulaValoresIntroducidos = string.Empty;
        }

        
    }
}

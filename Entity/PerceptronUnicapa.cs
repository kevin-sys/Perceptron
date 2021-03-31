using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class PerceptronUnicapa
    {
        public double NumeroIteraciones { get; set; }
        public double RataAprendizaje { get; set; }
        public double ErrorRMS { get; set; }
        public double NumeroMaximoIteraciones { get; set; }
        public double Patrones { get; set; }
        public double Entrada { get; set; }
        
        public double W1 { get; set; }
        public double W2 { get; set; }
        public double U { get; set; }
        public double  X1 { get; set; }
        public double X2 { get; set; }
        public double YD1{ get; set; }
        public double Ep;
        public string Respuesta;
        public double W11;
        public double W21;
        public double U1;
        public double Salida { get; set; }


        public double CalcularSalidaFuncion()
        {

            return (((X1 * W11) + (X2 * W21)) - (U1));

        }

        public decimal CalcularSalidadRed()
        {

            if (Salida >= 0)
            {

                return 1;
            }

            else
            {

                return 0;

            }
        }

        public decimal CalcularErrorLineal(decimal YD1, decimal YR1)
        {

            return YD1 - YR1;
        }

        public decimal CalcularErrorPatron(decimal Eli, decimal N)
        {
            return (Math.Abs(Eli)) / N;

        }

        public decimal ModificarPesos(decimal W, decimal RataDeAprendizaje, decimal Eli, decimal X)
        {

            return W + RataDeAprendizaje * Eli * X;

        }

        public decimal ModificarUmbrales(decimal U1, decimal RataDeAprendizaje, decimal Eli, decimal Xo)
        {

            return U1 + RataDeAprendizaje * Eli * Xo;

        }

        public decimal CalcularErrorRMS(IList<decimal> Erm)
        {
            decimal sum = 0;
            foreach (var item in Erm)
            {
                sum = sum + item;
            }

            return sum / Erm.Count();
        }

        public Boolean EstadoRNA(decimal ERMS, decimal ErrorPatron)
        {
            Boolean estado;

            if (ERMS <= ErrorPatron)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            return estado;
        }

        public string RespuestaRNA(decimal ERMS, decimal ErrorPatron)
        {
            if (ERMS <= ErrorPatron)
            {
                Respuesta = "Felicitaciones pesos y umbrales localizados";
            }
            else
            {
                Respuesta = "Como no se cumple la condición, vuelva a presentar las iteraciones de los valores actuales de W y U.";
            }
            return Respuesta;
        }




    }
}

    


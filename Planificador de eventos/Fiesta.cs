using System;
using System.Collections.Generic;
using System.Text;

namespace Planificador_de_eventos
{
    class Fiesta
    {
        protected int numPersonas;
        protected double costeDecoracion = 7.5;
        protected Boolean decoracionLujo = false;
        protected int costeFijoPersona = 55;

        public void setNumPersonas(int numPersonas)
        {
            this.numPersonas = numPersonas;
        }

        public int getNumPersonas()
        {
            return numPersonas;
        }

        public void calcularCosteDecoracion(Boolean IsLujo) { 

            if (IsLujo)
            {
                costeDecoracion = 15;
                costeFijoPersona = 75;
            }
            else
            {
                costeDecoracion = 7.5;
                costeFijoPersona = 55;
            }
        }

        public double calcularCoste()
        {
            
            double costeTotal = costeDecoracion + (numPersonas * (costeDecoracion + costeFijoPersona));

            return costeTotal;
        }
    }
}

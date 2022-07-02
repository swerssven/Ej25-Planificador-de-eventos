using System;
using System.Collections.Generic;
using System.Text;

namespace Planificador_de_eventos
{
    class Cumpleanyos : Fiesta
    {
        protected int tamanyoTarta = 0;
        protected String textoTarta = "";

        public void setTamanyoTarta()
        {
            if (numPersonas <= 8 && numPersonas > 0)
            {
                tamanyoTarta = 40;
            }
            else if(numPersonas > 8)
            {
                tamanyoTarta = 75;
            }
            else if(numPersonas == 0)
            {
                tamanyoTarta = 0;
            }

        }

        public void setTextTarta(String textoTarta)
        {
            this.textoTarta = textoTarta;
        }

        public new double calcularCoste()
        {
            double costeTotal = numPersonas * (costeDecoracion + costeFijoPersona) + (this.textoTarta.Length * 0.25) + this.tamanyoTarta;
            return costeTotal;
        }
    }
}

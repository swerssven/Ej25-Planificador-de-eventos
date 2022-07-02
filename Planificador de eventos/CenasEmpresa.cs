using System;
using System.Collections.Generic;
using System.Text;

namespace Planificador_de_eventos
{
    class CenasEmpresa : Fiesta
    {
        protected Boolean opcionSaludable = false;
        protected double costeBebidaPorPersona = 20;

        public CenasEmpresa(): base()
        {
            base.calcularCoste();
        }

        public new double calcularCoste()
        {
            double costeTotal = 0;

            if (opcionSaludable)
            {
                double totalSinDescuento = costeDecoracion + numPersonas * (costeFijoPersona + costeBebidaPorPersona);
                costeTotal = (Math.Round((totalSinDescuento - (totalSinDescuento * 0.05))*100)/100);
            }
            else
            {
                costeTotal = costeDecoracion + numPersonas * (costeFijoPersona + costeBebidaPorPersona);
            }

            return costeTotal;
        }

        public void estableceOpcionSaludable(Boolean IsSaludable)
        {
            if (IsSaludable)
            {
                opcionSaludable = IsSaludable;
                costeBebidaPorPersona = 5;
            }
            else
            {
                opcionSaludable = IsSaludable;
                costeBebidaPorPersona = 20;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorDeEventos
{
    interface separarFechas
    {
        void separarFechaDeEventos(string fecha);
    }
    internal class SepararFechaDeEventos : separarFechas
    {
        string fechaEvento1;
        CompararFechas fecha1 = new CompararFechas();
        public void separarFechaDeEventos(string fecha)
        {
            //Metodo para separar la fecha del evento
            char[] delimitador = { ',' };
            string[] fechaArray = fecha.Split(delimitador);

            //Nombre y fecha del evento separados
            //string nombreEvento = fechaArray[0];
            fechaEvento1 = fechaArray[1];

            DateTime ahora = DateTime.Now;
            DateTime fechaTipoDate = DateTime.Parse(fechaEvento1);

            fecha1.compararFechas(fechaTipoDate, ahora);
        }
    }
}

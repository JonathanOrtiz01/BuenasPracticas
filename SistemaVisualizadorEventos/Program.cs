using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VisualizadorDeEventos
{
    internal class ClasePrincipal
    {
        //Principio solid single responsability
        //Princio open/closed
        //No se aplica el principio de herencia
        //
        static void Main(string[] args)
        {
            LeerArchivo archivo1 = new LeerArchivo();
            archivo1.leerArchivos();
            Console.ReadKey();
        }
    }
}

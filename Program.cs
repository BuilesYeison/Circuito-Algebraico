using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuito_AlgebraicoEXE
{
    class Program //clase principal del programa donde se llama todas las clases necesaria para que se ejecute correctamente todo
    {
        static void Main(string[] args)
        {
            Presentacion presentacion = new Presentacion();
            presentacion.presentacion();

            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Paginaprincipal();


            Console.ReadKey();
            Console.Clear();
        }
    }
}

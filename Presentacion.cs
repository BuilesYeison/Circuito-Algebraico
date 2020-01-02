using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Circuito_AlgebraicoEXE
{
    class Presentacion
    {
        public string sExplicacion = "En este juego mediremos tu velocidad de analisis y resolucion de operaciones conmatrices. Recomendamos jugarlo con amigos para que sea mas divertido, evitar calculadora y demas utencilios que te faciliten las operaciones. Al dar en 'Nuevo Juego' tendras que estar preparado para resolver lo que se te proponga en pantalla. Al final de cada circuito se mostrara tu resultado final para que lo comparescon el de tus contrincantes. Son libres de poner cualquier regla por fuera del juego; como tiempo limite por cada problema,sin ninguna ayuda etc. Y así competirpor quien lo hace mejor.", sBienvenido = "***HOLA BIENVENIDO AL JUEGO CIRCUITO ALGEBRAICO***";
        public string sPuntaje = "El sistema de puntos es así: un problema resuelto correctamente equivale a 10 puntos y uno incorrecto equivale a 1 punto.";
        public void presentacion()
        {
            int i = 0, x = 0, y = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (char letra in sBienvenido)
            {
                Console.SetCursorPosition(25 + i, 3);
                Console.Write(letra);
                Thread.Sleep(50);
                i++;
            }
            i = 0;
            x = 20;
            y = 5;
            foreach (char letra in sExplicacion)
            {
                if (x + i >= 100)
                {
                    y++;
                    x = 20;
                    i = 0;
                }
                Console.SetCursorPosition(x + i, y);
                Console.Write(letra);
                Thread.Sleep(10);
                i++;
            }

            i = 0;
            x = 20;
            y = 15;

            foreach (char letra in sPuntaje)
            {
                if (x + i >= 100)
                {
                    y++;
                    x = 20;
                    i = 0;
                }
                Console.SetCursorPosition(x + i, y);
                Console.Write(letra);
                Thread.Sleep(10);
                i++;
            }

            Console.SetCursorPosition(20, 19);
            Console.WriteLine("Esperamos y disfrutes este juego. Si entendistes presiona cualquier ");
            Console.SetCursorPosition(20, 20);
            Console.WriteLine("tecla sino vuelve a leer :3");
            Console.SetCursorPosition(20, 21);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

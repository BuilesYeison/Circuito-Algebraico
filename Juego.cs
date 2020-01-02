using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//libreria para crear archivos e ingresar y leer datos de este

namespace Circuito_AlgebraicoEXE
{
    class Juego
    {
        #region variables, vectores y matrices
        StreamWriter Archivo;//variable de la clase para escrir en el archivo
        public string sCadena, sNickname;//variables necesarias
        public int iPuntajeTotal, iRandom, iResultadoFinal = 0, iSeg = 0, iResultadoUsuario = 0, iPuntaje = 0, iResultado1 = 0, iResultado2 = 0;
        Random Random = new Random();//objeto para llenar las matrices con numeros al azar
        public int[,] mDeterminante2x2 = new int[2, 2];//matriz de orden 2x2
        public int[,] mDeterminante3x3 = new int[3, 3];//matriz de orden 3x3
        public int[,] iMatriz1 = new int[1, 3];//matriz de orden 1x3
        public int[,] iMatriz2 = new int[3, 1];//matriz de orden 3x1
        public int[] iPuntajes = new int[6];//vector que guardara los puntajes de cada operacion es de 6 porque el circuito es de 6 operaciones
        #endregion
        public void Determinante2x2()
        {                     
            Console.ForegroundColor = ConsoleColor.Gray;//color gris para determinante 2x2
            for (int i = 0; i < 2; i++)//ciclo for que recorre las filas
            {
                for (int j = 0; j < 2; j++)//ciclo for anidado para recorrer columnas 
                {
                    iRandom = Random.Next(1, 9);//creamos una clase random que escoja numeros al azar del 1 al 9
                    mDeterminante2x2[i, j] = iRandom;//llenamos la matriz
                }
            }

            #region grafico
            //grafica de la matriz 2x2
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("╬");
            Console.SetCursorPosition(49, 10);
            Console.WriteLine("═");
            Console.SetCursorPosition(48, 10);
            Console.WriteLine("═");
            Console.SetCursorPosition(51, 10);
            Console.WriteLine("═");
            Console.SetCursorPosition(52, 10);
            Console.WriteLine("═");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("║");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("║");
            #endregion
            #region orden de matriz
            //ordenar matriz dentro de la grafica 
            Console.SetCursorPosition(49, 9);
            Console.WriteLine(mDeterminante2x2[0, 0]);
            Console.SetCursorPosition(51, 9);
            Console.WriteLine(mDeterminante2x2[0, 1]);
            Console.SetCursorPosition(49, 11);
            Console.WriteLine(mDeterminante2x2[1, 0]);
            Console.SetCursorPosition(51, 11);
            Console.WriteLine(mDeterminante2x2[1, 1]);
            #endregion

            #region operacion
            //logica para hallar determinantes 2x2
            iResultado1 = mDeterminante2x2[0, 0] * mDeterminante2x2[1, 1];//el resultado 1 es igual a la multiplicacion de la diagonal principal 
            iResultado2 = mDeterminante2x2[0, 1] * mDeterminante2x2[1, 0];//el resultado 2 es igual a la multiplicacion de la otra diagonal

            iResultadoFinal = iResultado1 - iResultado2;//el determinante se halla restando el resultado 1 con el resultado 2
            Console.SetCursorPosition(55, 10);
            Console.Write("Escribe el resultado: ");//se le solicita el resultado al usuario
            iResultadoUsuario = int.Parse(Console.ReadLine());//se guarda el resultado del usuario
            #endregion            

            if (iResultadoUsuario == iResultadoFinal)//si el resultado del usuario es igual al resultadofinal
                iPuntaje = 10;//entonces el puntaje del usuario es 10
            else//sino
                iPuntaje = 1;//es 1

            for (int i = 0; i < 6; i++)//ciclo for hasta 6 para recorrer vector de puntajes
            {
                if (iPuntajes[i] == 0)//si en la posicion actual es = 0
                {
                    iPuntajes[i] = iPuntaje;//agrega el puntaje del usuario
                    break;//y deja de recorrer la matriz, esto es para que no llene toda la matriz indiscriminadamente de el mismo puntaje
                }
            }
            Console.Clear();//limpiamos pantalla
        }

        public void Determinante3x3()
        {
            Console.ForegroundColor = ConsoleColor.Green;//determinante 3x3 letras verdes
            for (int i = 0; i < 3; i++)//ciclo for para recorrer filas 
            {
                for (int j = 0; j < 3; j++)//ciclo for anidado para recorrer columans
                {
                    iRandom = Random.Next(1, 9);//metodo random para hallar un numero al azar del 1 al 9 y lo metemos en una variable
                    mDeterminante3x3[i, j] = iRandom;//agregamos el dato random a la matriz
                }
            }

            #region grafico
            Console.SetCursorPosition(49, 13);
            Console.WriteLine("╬");
            Console.SetCursorPosition(51, 13);
            Console.WriteLine("╬");
            Console.SetCursorPosition(49, 15);
            Console.WriteLine("╬");
            Console.SetCursorPosition(51, 15);
            Console.WriteLine("╬");
            Console.SetCursorPosition(48, 13);
            Console.WriteLine("═");
            Console.SetCursorPosition(52, 13);
            Console.WriteLine("═");
            Console.SetCursorPosition(48, 15);
            Console.WriteLine("═");
            Console.SetCursorPosition(52, 15);
            Console.WriteLine("═");

            Console.SetCursorPosition(49, 14);
            Console.WriteLine("║");
            Console.SetCursorPosition(51, 14);
            Console.WriteLine("║");

            Console.SetCursorPosition(49, 12);
            Console.WriteLine("║");
            Console.SetCursorPosition(51, 12);
            Console.WriteLine("║");
            Console.SetCursorPosition(49, 16);
            Console.WriteLine("║");
            Console.SetCursorPosition(51, 16);
            Console.WriteLine("║");

            Console.SetCursorPosition(50, 13);
            Console.WriteLine("═");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("═");
            #endregion
            #region orden de matriz
            //primera fila
            Console.SetCursorPosition(50, 12);
            Console.WriteLine(mDeterminante3x3[0, 1]);
            Console.SetCursorPosition(48, 12);
            Console.WriteLine(mDeterminante3x3[0, 0]);
            Console.SetCursorPosition(52, 12);
            Console.WriteLine(mDeterminante3x3[0, 2]);
            //segunda fila
            Console.SetCursorPosition(50, 14);
            Console.WriteLine(mDeterminante3x3[1, 1]);
            Console.SetCursorPosition(48, 14);
            Console.WriteLine(mDeterminante3x3[1, 0]);
            Console.SetCursorPosition(52, 14);
            Console.WriteLine(mDeterminante3x3[1, 2]);
            //tercera fila
            Console.SetCursorPosition(50, 16);
            Console.WriteLine(mDeterminante3x3[2, 1]);
            Console.SetCursorPosition(48, 16);
            Console.WriteLine(mDeterminante3x3[2, 0]);
            Console.SetCursorPosition(52, 16);
            Console.WriteLine(mDeterminante3x3[2, 2]);
            #endregion
            #region operacion
            //logica
            Console.SetCursorPosition(57, 14);
            Console.Write("Resultado: ");//pedimos el resultado del usuario
            iResultadoUsuario = int.Parse(Console.ReadLine());//y lo guardamos

            //operacion determinante 3x3
            iResultado1 = ((mDeterminante3x3[0, 0] * mDeterminante3x3[1, 1] * mDeterminante3x3[2, 2]) + (mDeterminante3x3[0, 1] * mDeterminante3x3[1, 2] * mDeterminante3x3[2, 0]) + (mDeterminante3x3[0, 2] * mDeterminante3x3[1, 0] * mDeterminante3x3[2, 1]));//hacemos multiplicacion de diagonales
            iResultado2 = ((mDeterminante3x3[0, 1] * mDeterminante3x3[1, 0] * mDeterminante3x3[2, 2]) + (mDeterminante3x3[0, 0] * mDeterminante3x3[1, 2] * mDeterminante3x3[2, 1]) + (mDeterminante3x3[0, 2] * mDeterminante3x3[1, 1] * mDeterminante3x3[2, 0]));
            iResultadoFinal = iResultado1 - iResultado2;//se restan los dos resultados para hallar el determinante

            if (iResultadoUsuario == iResultadoFinal)//si el resultado del usuario es igual al resultadofinal
                iPuntaje = 10;//entonces el puntaje del usuario es 10
            else//sino
                iPuntaje = 1; //el puntaje es 1

            for (int i = 0; i < 6; i++)//ciclo for hasta 6 para recorrer vector de puntajes
            {
                if (iPuntajes[i] == 0)//si en la posicion actual es = 0
                {
                    iPuntajes[i] = iPuntaje;//agrega el puntaje del usuario
                    break;//y deja de recorrer la matriz, esto es para que no llene toda la matriz indiscriminadamente de el mismo puntaje
                }
            }
            Console.Clear();//limpiar pantalla
            #endregion
        }

        public void MultiplicacionMatrices()
        {
            #region color y llenar matrices
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    iRandom = Random.Next(1, 9);
                    iMatriz1[i, j] = iRandom;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    iRandom = Random.Next(1, 9);
                    iMatriz2[i, j] = iRandom;
                }
            }
            #endregion
            #region grafico
            //matriz1
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("╔");
            Console.SetCursorPosition(45, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("╚");

            Console.SetCursorPosition(46, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(47, 12);
            Console.WriteLine("╦");
            Console.SetCursorPosition(47, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(47, 14);
            Console.WriteLine("╩");
            Console.SetCursorPosition(46, 14);
            Console.WriteLine("═");

            Console.SetCursorPosition(48, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(49, 12);
            Console.WriteLine("╦");
            Console.SetCursorPosition(49, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(49, 14);
            Console.WriteLine("╩");
            Console.SetCursorPosition(48, 14);
            Console.WriteLine("═");

            Console.SetCursorPosition(50, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(51, 12);
            Console.WriteLine("╗");
            Console.SetCursorPosition(51, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(51, 14);
            Console.WriteLine("╝");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("═");

            Console.SetCursorPosition(52, 13);
            Console.WriteLine("*");
            //matriz2
            Console.SetCursorPosition(53, 12);
            Console.WriteLine("╠");
            Console.SetCursorPosition(53, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(53, 14);
            Console.WriteLine("╚");
            Console.SetCursorPosition(54, 14);
            Console.WriteLine("═");
            Console.SetCursorPosition(54, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(55, 14);
            Console.WriteLine("╝");
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("╣");
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("║");

            Console.SetCursorPosition(53, 10);
            Console.WriteLine("╠");
            Console.SetCursorPosition(53, 11);
            Console.WriteLine("║");
            Console.SetCursorPosition(55, 10);
            Console.WriteLine("╣");
            Console.SetCursorPosition(55, 11);
            Console.WriteLine("║");
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("═");

            Console.SetCursorPosition(55, 8);
            Console.WriteLine("╗");
            Console.SetCursorPosition(55, 9);
            Console.WriteLine("║");
            Console.SetCursorPosition(53, 8);
            Console.WriteLine("╔");
            Console.SetCursorPosition(53, 9);
            Console.WriteLine("║");
            Console.SetCursorPosition(54, 8);
            Console.WriteLine("═");
            #endregion
            #region ordenamiento matrices
            int x = 46;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x, 13);
                    x = x + 2;
                    Console.WriteLine(iMatriz1[i, j]);
                }
            }
            x = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.SetCursorPosition(54, x);
                    x = x + 2;
                    Console.WriteLine(iMatriz2[i, j]);
                }
            }
            #endregion
            #region operacion
            //logica
            Console.SetCursorPosition(57, 13);
            Console.Write("Resultado: ");//solicitud de resultado
            iResultadoUsuario = int.Parse(Console.ReadLine());

            //multiplicacion
            iResultadoFinal = ((iMatriz1[0, 0] * iMatriz2[0, 0]) + (iMatriz1[0, 1] * iMatriz2[1, 0]) + (iMatriz1[0, 2] * iMatriz2[2, 0]));//propiedad de multiplicacion de matrices

            if (iResultadoUsuario == iResultadoFinal)
                iPuntaje = 10;
            else
                iPuntaje = 1;

            for (int i = 0; i < 6; i++)
            {
                if (iPuntajes[i] == 0)
                {
                    iPuntajes[i] = iPuntaje;
                    break;
                }
            }
            #endregion
            Console.Clear();
        }

        public void MultiplicacionMatrices1()
        {
            #region color y llenar matrices
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    iRandom = Random.Next(1, 9);
                    iMatriz1[i, j] = iRandom;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    iRandom = Random.Next(1, 9);
                    iMatriz2[i, j] = iRandom;
                }
            }
            #endregion
            #region grafico
            //matriz1
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("╔");
            Console.SetCursorPosition(45, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("╚");

            Console.SetCursorPosition(46, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(47, 12);
            Console.WriteLine("╦");
            Console.SetCursorPosition(47, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(47, 14);
            Console.WriteLine("╩");
            Console.SetCursorPosition(46, 14);
            Console.WriteLine("═");

            Console.SetCursorPosition(48, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(49, 12);
            Console.WriteLine("╦");
            Console.SetCursorPosition(49, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(49, 14);
            Console.WriteLine("╩");
            Console.SetCursorPosition(48, 14);
            Console.WriteLine("═");

            Console.SetCursorPosition(50, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(51, 12);
            Console.WriteLine("╗");
            Console.SetCursorPosition(51, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(51, 14);
            Console.WriteLine("╝");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("═");

            Console.SetCursorPosition(52, 13);
            Console.WriteLine("*");
            //matriz2
            Console.SetCursorPosition(53, 12);
            Console.WriteLine("╠");
            Console.SetCursorPosition(53, 13);
            Console.WriteLine("║");
            Console.SetCursorPosition(53, 14);
            Console.WriteLine("╚");
            Console.SetCursorPosition(54, 14);
            Console.WriteLine("═");
            Console.SetCursorPosition(54, 12);
            Console.WriteLine("═");
            Console.SetCursorPosition(55, 14);
            Console.WriteLine("╝");
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("╣");
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("║");

            Console.SetCursorPosition(53, 10);
            Console.WriteLine("╠");
            Console.SetCursorPosition(53, 11);
            Console.WriteLine("║");
            Console.SetCursorPosition(55, 10);
            Console.WriteLine("╣");
            Console.SetCursorPosition(55, 11);
            Console.WriteLine("║");
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("═");

            Console.SetCursorPosition(55, 8);
            Console.WriteLine("╗");
            Console.SetCursorPosition(55, 9);
            Console.WriteLine("║");
            Console.SetCursorPosition(53, 8);
            Console.WriteLine("╔");
            Console.SetCursorPosition(53, 9);
            Console.WriteLine("║");
            Console.SetCursorPosition(54, 8);
            Console.WriteLine("═");
            #endregion
            #region ordenamiento matrices
            int x = 46;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x, 13);
                    x = x + 2;
                    Console.WriteLine(iMatriz1[i, j]);
                }
            }
            x = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.SetCursorPosition(54, x);
                    x = x + 2;
                    Console.WriteLine(iMatriz2[i, j]);
                }
            }
            #endregion
            #region operacion
            Console.SetCursorPosition(57, 13);
            Console.Write("Resultado: ");
            iResultadoUsuario = int.Parse(Console.ReadLine());

            //multiplicacion
            iResultadoFinal = ((iMatriz1[0, 0] * iMatriz2[0, 0]) + (iMatriz1[0, 1] * iMatriz2[1, 0]) + (iMatriz1[0, 2] * iMatriz2[2, 0]));

            if (iResultadoUsuario == iResultadoFinal)
                iPuntaje = 10;
            else
                iPuntaje = 1;

            for (int i = 0; i < 6; i++)
            {
                if (iPuntajes[i] == 0)
                {
                    iPuntajes[i] = iPuntaje;
                    break;
                }
            }
            #endregion
            Console.Clear();

            #region puntaje total
            for (int i = 0; i < 6; i++)//ciclo para recorrer los puntajes del jugador
            {
                iPuntajeTotal = iPuntajeTotal + iPuntajes[i];//sumar todos los puntajes y agregarlos a una variables
            }
            Console.SetCursorPosition(48, 13);
            Console.Write("Tu puntaje es: " + iPuntajeTotal);//mostrar el puntaje total
            Console.SetCursorPosition(35, 14);
            Console.Write("Porfavor apreta cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(48, 13);
            Console.Write("Ingresa tu nickname: ");//pedir nickname al usuario
            sNickname = Console.ReadLine();//guardar dato
            Console.Clear();
            #region agregar informacion a un archivo de texto
            sCadena = Convert.ToString(iPuntajeTotal) + "," + sNickname;//convertir el puntaje a string y concatenarlo con el nickname separado por una coma para acceder a esos datos mas facil despues
            Archivo = File.AppendText("Puntajes.txt");//creacion del archivo de texto se le pasa el nombre del archivo
            Archivo.WriteLine(sCadena);//escribe en el archivo lo que hay en la variable cadena (puntaje y nickname)
            Archivo.Close();//cerramos el archivo para guardar 
            #endregion            
            Console.Clear();
            #endregion
        }

        public void Circuito()
        {
            //clase principal que sera lalmada en el menu para ejecutar el circuito
            Juego juego = new Juego();
            juego.Determinante2x2();
            juego.Determinante2x2();
            juego.Determinante3x3();
            juego.Determinante3x3();
            juego.MultiplicacionMatrices();
            juego.MultiplicacionMatrices1();

        }
    }
}

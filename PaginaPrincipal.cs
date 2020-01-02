using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//libreria para crear archivos y leerlos
using System.Threading;//libreria para timing

namespace Circuito_AlgebraicoEXE
{
    class PaginaPrincipal
    {
        public int iSeleccion, iPuntajeTotal = 0;//variables necesarias
        public int[] iPuntajesTotales = new int[10];//vector de orden 10 para almacenar un total de 10 puntajes diferentes
        public string[] sJugadores = new string[10];//vector de orden 10 para almacenar un total de 10 puntajes diferentes
        public string[] sCampos = new string[2];//donde guardaremos la informacion del archivo de texto es de solo 2 porque solo es puntaje y nickname lo que guarda el archivo
        public string sCadena;//variable necesaria para la operacion
        public string sNickname;
        StreamReader leer;//creamos una variable de la calse streamreader que leera la informacion de el archivo de texto
        
        public void Grafico()//metodo que se encarga de la creacion grafica que se muestra
        {
            #region Titulo
            Console.SetCursorPosition(48, 05);//posicion en pantalla x, y en relacion a un plano cartesiano
            Console.ForegroundColor = ConsoleColor.Blue;//color de la letra
            Console.WriteLine("Circuito Algebraico");
            Console.SetCursorPosition(46, 05);
            Console.WriteLine("║");
            Console.SetCursorPosition(46, 04);
            Console.WriteLine("╔");
            for (int i = 47; i < 68; i++)//ciclo for que aumenta x en el plano hasta 67
            {
                Console.SetCursorPosition(i, 04);//posicion
                Console.WriteLine("═");//de 47 hasta la pasicion en x 67 imprimira esto
            }
            Console.SetCursorPosition(68, 04);
            Console.WriteLine("╗");
            Console.SetCursorPosition(68, 05);
            Console.WriteLine("║");
            Console.SetCursorPosition(68, 06);
            Console.WriteLine("╝");
            Console.SetCursorPosition(46, 06);
            Console.WriteLine("╚");
            for (int i = 47; i < 68; i++)
            {
                Console.SetCursorPosition(i, 06);
                Console.WriteLine("═");
            }
            #endregion
            #region opciones
            Console.SetCursorPosition(25, 11);//ubicacion de las opciones del menu
            Console.WriteLine("1. Nuevo Juego");
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("2. Puntajes");
            Console.SetCursorPosition(25, 13);
            Console.WriteLine("3. Salir");

            Console.SetCursorPosition(23, 10);
            Console.WriteLine("╔");
            for (int i = 24; i < 40; i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.WriteLine("═");
            }
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("╗");
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(40, i);
                Console.WriteLine("║");
            }
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("╝");
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(23, i);
                Console.WriteLine("║");
            }
            Console.SetCursorPosition(23, 14);
            Console.WriteLine("╚");
            for (int i = 24; i < 40; i++)
            {
                Console.SetCursorPosition(i, 14);
                Console.WriteLine("═");
            }
            #endregion
            #region seleccion
            Console.SetCursorPosition(46, 11);
            Console.WriteLine("Selecciona");
            Console.SetCursorPosition(46, 12);
            Console.WriteLine("una");
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("opcion:");

            Console.SetCursorPosition(57, 12);
            Console.WriteLine("║");
            Console.SetCursorPosition(57, 11);
            Console.WriteLine("╔");
            Console.SetCursorPosition(58, 11);
            Console.WriteLine("═");
            Console.SetCursorPosition(59, 11);
            Console.WriteLine("╗");
            Console.SetCursorPosition(59, 12);
            Console.WriteLine("║");
            Console.SetCursorPosition(59, 13);
            Console.WriteLine("╝");
            Console.SetCursorPosition(58, 13);
            Console.WriteLine("═");
            Console.SetCursorPosition(57, 13);
            Console.WriteLine("╚");
            #endregion
        }

        public void Menu()//proframacion de menu
        {
            try//hacemos un try catch para validar
            {
                Console.SetCursorPosition(58, 12);
                iSeleccion = int.Parse(Console.ReadLine());//intentara convertir la opcion que ingrese el usuario a entero 
            }
            catch (Exception error)//sino se convierte entonces guardaremos el error que se genero en la variable error
            {
                Console.WriteLine("Ha ocurrido un error "+error.Message);//imprimimos el error
            }
            
            //menu
            while (iSeleccion != 0 && iSeleccion <= 3)//mientras la seleccion del usuario sea diferente de 0 o menor e igual a 3 entonces...
            {
                switch (iSeleccion)//creamos un switch and case con la opcion que ingreso el usuario para el menu
                {
                    case 1://opcion 1 (Nuevo Juego)

                        PaginaPrincipal paginaPrincipal = new PaginaPrincipal();//creamos unas instancia de esta clase
                        paginaPrincipal.temporizador();//y llamamos el metodo temorizador 

                        Console.Clear();//limpiamos panatalla cuando acabe el temporizador
                        Juego juego = new Juego();//creamos instancia de la clase juego
                        juego.Circuito();//llamamos el metodo circuito


                        paginaPrincipal.Paginaprincipal();//cuando termine el juego volvera al menu por eso se llama este metodo
                        break;//se rompe este caso o esta opcion

                    case 2://opcion 2 (Puntajes)
                        Console.SetCursorPosition(85, 5);
                        Console.WriteLine("Puntajes");//aparece en la pantalla un titulo
                        Console.SetCursorPosition(80, 6);
                        Console.WriteLine("*******************");
                        leer = File.OpenText("Puntajes.txt");//abrimos la instancia ller para que lea el archivo que tiene la informacion de nickname y puntaje, abrimos el archivo pasandole el nombre
                        sCadena = leer.ReadLine();//guardamos en una variable la primera linea dela rchivo de texto
                        int i = 0;//variable necearia para la operacion
                        while (sCadena != null)//mientras la variable no sea nula(sin informacion)
                        {
                            sCampos = sCadena.Split(',');//llenamos el vector campos separando el texto por las comas (asi separamos el nickname de el puntaje)
                            iPuntajesTotales[i] = int.Parse(sCampos[0]);//en la posicion 0 esta el puntjae por loq ue este dato lo convertimos en entero y lo guardamos en el vector puntajestotales
                            sJugadores[i] = sCampos[1];//en la posicion 1 esta los nombres y lo guardamos en el vector jugadores

                            i++;//aumentamos i (posicion de los vectores)
                            sCadena = leer.ReadLine();//leemos de nuevo la siguiente linea
                        }
                        leer.Close();//cuando termine de leer todo cerramos este proceso

                        //ordenamiento de mayor a menor los puntajes
                        int y = 0;//variable necesaria
                        for (int x = 0; x < 10 - 1; x++)//ciclo for de 0 hasta 9
                        {
                            for (y = x + 1; y < 10; y++)//ciclo for anidado de la posicion del ciclo anterior mas 1 para poder comparar dos datos diferentes
                            {

                                if (iPuntajesTotales[y] > iPuntajesTotales[x])//si el dato en la posicion y (posicion adelantada) es mayor a el dato en la posicion x
                                {
                                    int aux;//creamos una variable donde guardaremos un dato para no perderlo
                                    aux = iPuntajesTotales[y];//metemos el dato en y para no perderlo
                                    iPuntajesTotales[y] = iPuntajesTotales[x];//y en esa posicion y guardamos el dato de la posicion x
                                    iPuntajesTotales[x] = aux;//y en x lo que hay en aux(dato de posicion y)
                                }
                            }
                        }
                        //impresion de puntajes con nombre
                        y = 8;
                        for (i = 0; i < 10; i++)//ciclo for hasta 9
                        {
                            Console.SetCursorPosition(80, y);//posicion X y Y
                            Console.WriteLine("El puntaje de " + sJugadores[i] + " es: " + iPuntajesTotales[i]);//imprimir el nickname y su correspondiente puntaje

                            if (sJugadores[i] == null && iPuntajesTotales[i] == 0)//si en un momento lo que hay en el vector es igual a nul y en puntajes es 0
                            {
                                break;//deja de funcionar el ciclo for
                            }
                            else//sino
                                y = y + 2;//aumenta e 2 la posicion en y para imprimir en otro renglon la siguiente informacion
                        }
                        break;//romper opcion 2

                    case 3:  //cerrar app                      
                        Environment.Exit(1);//cerramos el programa le pasamos 1 que es igual a true
                        break;//rompre opcion 3
                    
                    default://si escoge algo diferente a esas otras opciones
                        Console.WriteLine("Escogiste una opcion invalida escoge otra porfavor");
                        break;
                }
                try
                {
                    //solicitud de nuevo de opcion
                    Console.SetCursorPosition(58, 12);
                    iSeleccion = int.Parse(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine("Ha ocurrido un error "+error.Message);   
                }
                
            }
        }

        public void Paginaprincipal()//metodo principal
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Grafico();//se invoca todo lo necesario para que se muestre correctamente el menu

            paginaPrincipal.Menu();


        }
        public void temporizador()
        {
            Console.ForegroundColor = ConsoleColor.Red;//temporizador con letras color rojo
            for (int seg = 10; seg > 0; seg--)//ciclo for que decrece de 10 a 0
            {
                Console.Clear();//limpiamos cada vez que pasa un segundo
                Console.SetCursorPosition(48, 13);
                Console.Write("El juego comienza en " + seg);//mostramos el segundo en cuenta regresiva
                Console.SetCursorPosition(43, 14);
                Console.Write("Porfavor no presiones nada");
                Thread.Sleep(1000);//tiempo equivalente a aproximadamente un segundo
            }
        }

    }
}

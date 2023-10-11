using System;

namespace Paint_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string _equipo_1 = "Equipo 1";
                string _equipo_2 = "Equipo 2";
                Console.WriteLine("  _______________________________________________________________________________");
                Console.WriteLine("||_______________________________________________________________________________||");
                Console.WriteLine("||                                                                               ||");
                Console.WriteLine("|| * * *    * * *   * * *   *     *   * * * * *   * *      * * *   *       *     ||");
                Console.WriteLine("|| *   *    *   *     *     * *   *       *       *   *    *   *   *       *     ||");
                Console.WriteLine("|| * * *    * * *     *     *  *  *       *       * *      * * *   *       *     ||");
                Console.WriteLine("|| *        *   *     *     *   * *       *       *   *    *   *   *       *     ||");
                Console.WriteLine("|| *        *   *   * * *   *     *       *       * *      *   *   * * *   * * * ||");
                Console.WriteLine("||_______________________________________________________________________________||");
                Console.WriteLine("||_______________________________________________________________________________||\n\n");

                List<JugadorPaintBall> equipo_1 = new List<JugadorPaintBall>
              {
                new JugadorPaintBall("jugador 1", "Equipo 1", 25, true, 50),
                new JugadorPaintBall("jugador 2", "Equipo 1", 28, true, 50),
                new JugadorPaintBall("jugador 3", "Equipo 1", 22, true, 50)
              };

                List<JugadorPaintBall> equipo_2 = new List<JugadorPaintBall>
               {
                new JugadorPaintBall("jugador 1", "Equipo 2", 25, true, 50),
                new JugadorPaintBall("jugador 2", "Equipo 2", 28, true, 50),
                new JugadorPaintBall("jugador 3", "Equipo 2", 22, true, 50),
                };

                Console.WriteLine("Ingrese exactamente \"SI\" para poder dar nombre a los equipos he integrantes de cada uno de estos\nPresione \"Enter\" para generar nombres");

                if (Console.ReadLine() == "SI")
                {
                    Console.Clear();
                    int _balas = balas();
                    Console.Clear();
                    _equipo_1 = equipo(1);
                    Console.Clear();
                    _equipo_2 = equipo(2);
                    Console.Clear();

                    equipo_1.Clear();
                    equipo_2.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        equipo_1.Add(new JugadorPaintBall(nombre(i + 1, _equipo_1), _equipo_1, edad(), true, _balas));
                        Console.Clear();
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        equipo_2.Add(new JugadorPaintBall(nombre(i + 1, _equipo_2), _equipo_1, edad(), true, _balas));
                        Console.Clear();
                    }
                }
                Console.Clear() ;
                CampoDeBatalla campo = new CampoDeBatalla(equipo_1, equipo_2, _equipo_1, _equipo_2);
                campo.ComenzarBatalla();
                campo.HayGanador();

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Ingrese exactamente \"Si\" para salir, de lo contrario presione \"Enter\"");
              
            } while (Console.ReadLine() != "Si");
        }
        static string nombre(int i, string equipo)
        {
            Console.Write($"Ingrese nombre del participante numero {i} del equipo {equipo}\n");
            return Console.ReadLine();
        }
        static string equipo(int i)
        {

            Console.Write($"Ingrese nombre del equipo numero {i}: ");
            return Console.ReadLine();
        }
        static uint edad()
        {
            uint numero;
            do
            {
                Console.Write("Ingrese la edad\n");
                Console.Write("Ingresa un número positivo: ");

            } while (!uint.TryParse(Console.ReadLine(), out numero) || !Numero_Po(numero));
            return numero;

            static bool Numero_Po(uint numero)
            {
                return numero > 0;
            }
        }
        static int balas()
        {
            int numero;
            do
            {
                Console.Write("Cual sera la cantidad de balas?\n");
                Console.Write("Ingresa un número positivo: ");

            } while (!int.TryParse(Console.ReadLine(), out numero) || !Numero_Po(numero));
            return numero;

            static bool Numero_Po(int numero)
            {
                return numero > 0;
            }
        }
    }

}

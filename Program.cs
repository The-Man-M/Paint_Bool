﻿namespace Paint_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                List<JugadorPaintBall> equipo_1 = new List<JugadorPaintBall>
              {
                new JugadorPaintBall("jugador 1" ,"Equipo 1", 25, true, 50),
                new JugadorPaintBall("jugador 2" ,"Equipo 1", 28, true, 50),
                new JugadorPaintBall("jugador 3" , "Equipo 1", 22, true, 50)
              };

                List<JugadorPaintBall> equipo_2 = new List<JugadorPaintBall>
               {
                new JugadorPaintBall("jugador 1", "Equipo 2", 25, true, 50),
                new JugadorPaintBall("jugador 2", "Equipo 2", 28, true, 50),
                new JugadorPaintBall("jugador 3", "Equipo 2", 22, true, 50),
                };


                CampoDeBatalla campo = new CampoDeBatalla(equipo_1, equipo_2);
                campo.ComenzarBatalla();
                campo.HayGanador();

                Console.ReadKey();
                Console.Clear();
            } while (true);
        }




    }

}

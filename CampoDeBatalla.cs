using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Bool
{
    internal class CampoDeBatalla
    {
        Dictionary<string, List<JugadorPaintBall>> Equipo_1 = new Dictionary<string, List<JugadorPaintBall>>();
        Dictionary<string, List<JugadorPaintBall>> Equipo_2 = new Dictionary<string, List<JugadorPaintBall>>();




        public CampoDeBatalla(List<JugadorPaintBall> equipo_1, List<JugadorPaintBall> equipo_2)
        {

            Equipo_1.Add("Equipo 1", equipo_1);

            Equipo_2.Add("Equipo 2", equipo_2);

        }
        public CampoDeBatalla() { }
        public void ComenzarBatalla()
        {
            while (!HayGanador())
            {

                var equipo1Jugadores = Equipo_1.Values.First(); // Obtiene la lista de jugadores del primer equipo
                var equipo2Jugadores = Equipo_2.Values.First(); // Obtiene la lista de jugadores del segundo equipo

                var jugadoresEnPar = equipo1Jugadores.Zip(equipo2Jugadores, (jugador1, jugador2) => new { Jugador1 = jugador1, Jugador2 = jugador2 });

                

                foreach (var pareja in jugadoresEnPar)
                {
                    pareja.Jugador1.correr();
                    pareja.Jugador2.correr();
                    pareja.Jugador1.disparar(pareja.Jugador2);
                    pareja.Jugador2.disparar(pareja.Jugador1);

                    Console.WriteLine($"{pareja.Jugador1.nombre} esta activo?\n {pareja.Jugador1.activo}");
                    Console.WriteLine($"{pareja.Jugador2.nombre} esta activo?\n {pareja.Jugador2.activo}");

                }
                Console.WriteLine("sexo");
            }
            TerminarBatalla();
        }
        public void TerminarBatalla()
        {


            int equipo1 = 0;
            int equipo2 = 0;

            foreach (var kvp in Equipo_1) foreach (var jugador in kvp.Value) if (jugador.activo) equipo1++;
            foreach (var kvp in Equipo_2) foreach (var jugador in kvp.Value) if (jugador.activo) equipo2++;


            if (equipo1 > equipo2) Console.WriteLine("Ganador equipo 1");

            else if (equipo1 < equipo2) Console.WriteLine("Ganador equipo 2");

        }
        public bool HayGanador()
        {
            int equipo1 = 0;
            int equipo2 = 0;

            foreach (var kvp in Equipo_1) foreach (var jugador in kvp.Value) if (jugador.activo) equipo1++;
            foreach (var kvp in Equipo_2) foreach (var jugador in kvp.Value) if (jugador.activo) equipo2++;


            //     if (equipo1 > equipo2) return true; else if (equipo1 < equipo2) return true;
            if (equipo1 == 0) return true;
            if (equipo2 == 0) return true;

            return false;
        }

    }
}
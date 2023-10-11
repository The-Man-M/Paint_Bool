using System;
using System.Collections.Generic;
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

            Equipo_1.Add("Equipo numero 1", equipo_1);

            Equipo_2.Add("Equipo numero 2", equipo_2);
        }
        public CampoDeBatalla() { }
        public void ComenzarBatalla()
        {

            do
            {

                //Equipo_1.Values()
                //Console.WriteLine(Equipo_1["Equipo numero 1"]);
                //Console.ReadKey();
            } while (true);


        }
        public void TerminarBatalla()
        {

        }
        public bool HayGanador()
        {
            bool ganador = true;


            return ganador;
        }

    }
}
/* 
            foreach (var kvp in Equipo_1)
            {
                Console.WriteLine($"Equipo: {kvp.Key}");

                foreach (var jugador in kvp.Value)
                {
                    Console.WriteLine($"   Nombre: {jugador.nombre}, Edad: {jugador.edad}, Activo: {jugador.activo}");
                  
                }
            }*/
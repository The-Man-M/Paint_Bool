namespace Paint_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<JugadorPaintBall> equipo_1 = new List<JugadorPaintBall>
            {
                new JugadorPaintBall(" 1E N_1", 25, true, 50),
                new JugadorPaintBall(" 1E N_2", 28, true, 50),
                new JugadorPaintBall(" 1E N_3", 22, true, 50)
            };

            List<JugadorPaintBall> equipo_2 = new List<JugadorPaintBall>
            {
                new JugadorPaintBall(" 2E N_1", 25, true, 50),
                new JugadorPaintBall(" 2E N_2", 28, true, 50),
                new JugadorPaintBall(" 2E N_3", 22, true, 50),
            };

            
            CampoDeBatalla campo = new CampoDeBatalla(equipo_1, equipo_2);
            campo.ComenzarBatalla();
            campo.HayGanador();
        
            Console.ReadKey();

        }




    }

}

namespace Paint_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<JugadorPaintBall> equipo_1 = new List<JugadorPaintBall>
            {
                new JugadorPaintBall("Nombre1", 25, true, 50),
                new JugadorPaintBall("Nombre2", 28, true, 50),
                new JugadorPaintBall("Nombre3", 22, true, 50)
            };

            List<JugadorPaintBall> equipo_2 = new List<JugadorPaintBall>
            {
                new JugadorPaintBall("Nombre1", 25, true, 50),
                new JugadorPaintBall("Nombre2", 28, true, 50),
                new JugadorPaintBall("Nombre3", 22, true, 50),
            };


            CampoDeBatalla campo = new CampoDeBatalla(equipo_1, equipo_2);
            campo.ComenzarBatalla();

            Console.WriteLine("hola");
            Console.ReadKey();

        }




    }

}

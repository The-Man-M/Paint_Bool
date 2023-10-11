using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Bool
{
    internal class JugadorPaintBall : Humano
    {
        CampoDeBatalla campo;
        public bool activo;
      public  string equipo;
        int balas;
        int evasividad = 0;

        public JugadorPaintBall(string nombre, string equipo, uint edad, bool _activo, int _balas) : base(nombre, edad)
        {
            this.activo = _activo;
            this.balas = _balas;
            this.equipo = equipo;
        }

        //t              
        public override void correr()
        {
            base.velocidad += 5;
            if (base.velocidad > 1 && base.velocidad <= 5)
            {
                this.evasividad = 1;
            }
            else if (base.velocidad > 5 && base.velocidad <= 10)
            {
                this.evasividad = 2;
            }
            else if (base.velocidad > 10 && base.velocidad <= 15)
            {
                this.evasividad = 3;
            }
            else
            {
                base.velocidad -= 10;
            }

        }

        public void disparar(JugadorPaintBall jugadorenemigo)
        {
            if (this.activo)
            {

                if (this.balas > 0)
                {
                    int _balasDisparadas = balasDisparadas();
                    if (balas >= _balasDisparadas)
                    {
                        balas -= _balasDisparadas;
                    }
                    else
                    {
                        _balasDisparadas = balas;
                        balas -= _balasDisparadas;
                    }

                    Console.WriteLine($"{this.nombre} del equipo {this.equipo} ha disparado {_balasDisparadas} balas a {jugadorenemigo.nombre} del equipo {jugadorenemigo.equipo}\n");


                    switch (jugadorenemigo.evasividad)
                    {

                        case 1:
                            // 25 %
                            if (numr() == 1 || numr() == 2 || numr() == 3)
                            {
                                jugadorenemigo.activo = false;
                                Console.WriteLine("Le ha dado");
                            }
                            break;
                        case 2:

                            // 50%
                            if (numr() == 1 || numr() == 2)
                            {
                                jugadorenemigo.activo = false;
                                Console.WriteLine("Le ha dado");
                            }
                            break;
                        case 3:
                            // 75 %
                            if (numr() == 1)
                            {
                                jugadorenemigo.activo = false;
                                Console.WriteLine("Le ha dado");
                            }
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{this.nombre} esta descalificado\nNo tiene munición\n");
                    this.activo = false;
                }

            }
        }
        int numr()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }
        int balasDisparadas()
        {
            Random balas = new Random();
            return balas.Next(1, 10);
        }
    }
}

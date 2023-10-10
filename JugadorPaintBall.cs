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
        int balas;
        int evasividad = 0;
        public JugadorPaintBall(string nombre, uint edad, bool _activo, int _balas) : base(nombre, edad)
        {

            this.activo = _activo; 
            this.balas = _balas;    
        }
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
            if (this.balas>0)
            {
                if(esquiva(this.evasividad, numr()))
                {
                    
                }
            }
            else
            {
              this.activo=false;
            }

        }
        static int numr()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }
        bool esquiva(int evacividad, int ramdon)
        {
            switch (evacividad)
            {
                // 25 %
                case 1: 
                    if (ramdon >= 1 && ramdon <= 3)
                    {
                        return true;
                    }
                    else return false;
                       // 50% 
                    case 2:
                    if (ramdon >= 1 && ramdon <= 2)
                    {
                        return true;
                    }

                    else return false;

                case 3:
                    if (ramdon ==1 )
                    {
                        return true;
                    }
                    else return false;

                    default : return false;
            }

        }

    }
}

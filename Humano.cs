using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Bool
{
    internal class Humano
    {
        protected string nombre { get; set; }
        protected uint edad {get; set; }
        protected uint velocidad {get; set; }
        
        public Humano(string _nombre, uint _edad) 
        {
            this.nombre = _nombre;
            this.edad = _edad; 
        
        }

        public virtual void correr()
        {
            this.velocidad += 5;
        }
    }
}

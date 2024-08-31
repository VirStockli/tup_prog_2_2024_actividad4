using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.Models
{
    internal class Persona
    {

        public int DNI { get; set; }
        public string Nombre { get; set; }    
        public Persona(int dni) 
        {
            this.DNI = dni;
                }
        public Persona(int dni, string nombre) 
        {   this.DNI = dni;
            this.Nombre = nombre;
        }

    }
}

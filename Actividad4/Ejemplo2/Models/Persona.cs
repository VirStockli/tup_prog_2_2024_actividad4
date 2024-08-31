using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.Models
{
    internal class Persona : IComparable
    {

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public Persona(int dni)
        {
            this.DNI = dni;
        }
        public Persona(int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
        public int CompareTo(object obj)
        {
            Persona p = obj as Persona;
            if (p != null)
                return DNI.CompareTo(p.DNI);
            return 1;
        }

        public override string ToString()
        {
            return $"{DNI} {Nombre}\r\n";

        }
    }
}

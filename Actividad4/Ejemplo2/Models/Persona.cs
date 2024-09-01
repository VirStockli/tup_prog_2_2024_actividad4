using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo2.Models;

namespace Ejemplo2.Models
{
    internal class Persona : IComparable
    {

        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona() { }
        
        public Persona(int DNI, string nombre)
        {
            this.DNI = DNI;
            this.Nombre = nombre;
        }

        public Persona(int DNI)
        {
            this.DNI = DNI;
        }

        int IComparable.CompareTo(object obj)
        {
            Persona p = obj as Persona;
            if (p != null)
            {
                return this.DNI.CompareTo(p.DNI);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"{DNI} {Nombre}\r\n";
        }
    }
}

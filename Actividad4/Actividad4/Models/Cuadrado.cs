using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    internal class Cuadrado:Rectangulo
    {
        public Cuadrado(double lado) : base(lado, lado) { }

        public override string ToString()
        {
            return $"Cuadrado - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }
    }
}


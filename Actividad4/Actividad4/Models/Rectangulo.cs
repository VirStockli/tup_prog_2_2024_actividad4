using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.Models
{
    internal class Rectangulo : IFigura, IComparable
    {
        public double Largo { get;  }
        public double Ancho { get; }
        public Rectangulo(double LadoA, double LadoB)
        {
            this.Largo = LadoA;
            this.Ancho= LadoB;
        }
        
         public double CalcularArea()
        {
            return Largo * Ancho;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        override public string ToString()
        {
            return $"Rectangulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }

        public int CompareTo(object obj)
        {
            IFigura fig = obj as IFigura;
            if (fig != null)
            {
                return this.CalcularArea().CompareTo(fig.CalcularArea());
            }
            return 1;
        }


        //public override double CalcularArea()
        //{
        //    area = ladoUno * ladoDos;
        //    return area;
        //}
        //public override double CalcularPerimetro()
        //{
        //    perimetro = ladoUno * 2 + ladoDos * 2;
        //    return perimetro;
        //}
        //public override string ToString()
        //{
        //    return $"Rectangulo:{CalcularArea():f2}";
        //}
    } 
}

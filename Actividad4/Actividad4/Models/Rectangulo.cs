using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.Models
{
    internal class Rectangulo : IFigura
    {

        public Rectangulo(double LadoU, double LadoD)//:base(LadoU,LadoD)
        {
            this.ladoUno = LadoU;
            this.ladoDos= LadoD;

        }
        public double ladoUno { get; set; }
        public double ladoDos { get; set; }
        public double area = 0;
        public double perimetro = 0;


        public double CalcularArea()
        {
            return ladoUno * ladoDos;
        }
        public double CalcularPerimetro()
        {
            return 2 * (ladoUno + ladoDos);
        }

        public override string ToString()
        {
            return $"Rectangulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
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

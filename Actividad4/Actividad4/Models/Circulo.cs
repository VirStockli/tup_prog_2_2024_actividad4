using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.Models
{
    internal class Circulo:Figura
    {
        private double Radio { get; }
        public Circulo (double radio)
        {
            this.Radio = radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * (Math.Pow(Radio, 2));
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return $"Circulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }

        //public override double CalcularArea()
        //{
        //    double res = Math.PI*Radio;
        //    return res;
        //}
        //public override double CalcularPerimetro()
        //{
        //    double res;
        //    double diametro = 2 * Radio;
        //    res = Math. PI * diametro;
        //    return res;

        //}
    }
}

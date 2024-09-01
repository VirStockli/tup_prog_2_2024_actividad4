using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    abstract class Figura : IFigura, IComparable
    {
        abstract public double CalcularArea();
        abstract public double CalcularPerimetro();
        //public int CompareTo(Figura obj)
        //{
        //    IFigura fig = obj as IFigura;
        //    if (fig != null)
        //    {
        //        return this.CalcularArea().CompareTo(fig.CalcularArea());
        //    }
        //    return 1;
        //}

        int IComparable.CompareTo(object obj)
        {
            IFigura fig = obj as IFigura;
            if (fig != null)
            {
                return this.CalcularArea().CompareTo(fig.CalcularArea());
            }
            return 1;
        }
    }
}

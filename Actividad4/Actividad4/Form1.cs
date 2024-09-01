using Actividad4.Models;
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

namespace Actividad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList figuras = new ArrayList(10);

        IFigura[] misFiguras = new IFigura[10];
        int cont = 0;
        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(tbAlto.Text);
            double anchura = Convert.ToDouble(tbAncho.Text);
            IFigura p = new Rectangulo(altura, anchura);
            //misFiguras[cont++] = new Rectangulo(altura, anchura);

            misFiguras[cont++] = p;
            //cont++;
            figuras.Add(p);

            tbVer.Text += $"Añadiendo figura:\r\n{p}\r\n";

            tbAlto.Text = "0";
            tbAncho.Text = "0";

            //figuras[1] = new Cuadrado(3.5);
            //figuras[2] = new Circulo(2);
            //figuras[3] = new Rectangulo(3, 4);
            //figuras[4] = new Rectangulo(3, 4);

            //foreach (Figura fig in figuras)
            //{
            //    //double a = fig.CalcularArea();
            //    textBox1.Text=(fig.ToString());

            //foreach (IFigura fig in misFiguras)
            //    {
            //        tbVer.Text+=$"Añadiendo figuras:\r\n{fig}\r\n";
            //    }

        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(tbRadio.Text);
            IFigura c = new Circulo (radio);

            misFiguras[cont++] = c;
            figuras.Add(c);

            tbVer.Text += $"Añadiendo figura:\r\n{c}\r\n";
            tbRadio.Text = "0";
            

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(tbLado.Text);
            IFigura c = new Cuadrado(lado);
            
            figuras.Add(c);

            misFiguras[cont++] = c;
 
            tbVer.Text += $"Añadiendo figura:\r\n{c}\r\n";
            tbLado.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbVer.Clear();
            tbVer.Text += $"Figuras:\r\n";
            foreach (IFigura fig in misFiguras)
            {
                tbVer.Text += $"{fig}\r\n";
            }

            figuras.Sort();

            foreach (IFigura fig in figuras )
            {
                if (fig is Cuadrado)
                {
                    tbVer.Text += $"{fig}\r\n";
                }
            }

            //foreach (IFigura fig in figuras)
            //{
            //    IFigura f = fig as Cuadrado;
            //    tbVer.Text += $"{f.CalcularArea().ToString("0.00")}\r\n";
            //}

        }
    }
}

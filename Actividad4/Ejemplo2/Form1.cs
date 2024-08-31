using Ejemplo2.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int DNI;
            ArrayList lista = new ArrayList();
            lista.Add(new Persona(2134343, "rickyyy"));

            lista.Sort();
            textBox1.Text += $"List Ordenada";
            foreach (Persona persona in lista)
            {
                textBox1.Text += $"{persona.DNI}";
            }

            int idx = lista.BinarySearch(new Persona(DNI));
                { if (idx >= 0)
                {
                    Persona p = lista[idx] as Persona;
                    textBox1.Text += $"{p.DNI}";
                }
                else
                {
                    textBox1.Text = "gdgdgdsas";
                }
                
                
            }
        }
    }
}

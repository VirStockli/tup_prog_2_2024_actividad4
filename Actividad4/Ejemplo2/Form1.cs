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

            lista.Add(new Persona(4343433, "Julia"));
            lista.Add(new Persona(2343422, "Estefanía"));
            lista.Add(new Persona(32443433, "Rebeca"));
            lista.Add(new Persona(31343433, "Eduardo"));
            lista.Add(new Persona(10643433, "Lucia"));
            lista.Add(new Persona(40643433, "Reinaldo"));
        }
        ArrayList lista = new ArrayList(20);
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                #region probando la búsqueda
                int dni = Convert.ToInt32(textBox1.Text);

                tbVer.Text += $"\r\nBuscando {dni}\r\n";

                
                lista.Sort();
                int idx = lista.BinarySearch(new Persona(dni));

                Persona p = null;
                if (idx >= 0)
                {
                    p = lista[idx] as Persona;
                    tbVer.Text += $"{p}";
                }
                else
                {
                    tbVer.Text += $"No encontrado";

                    Agregar ventana = new Agregar();
                    ventana.tbdni.Text = dni.ToString();
                    ventana.tbdni.Enabled = false;

                    if (ventana.ShowDialog() == DialogResult.OK)
                    {

                        string nombre = ventana.tbNombre.Text;
                        p = new Persona(dni, nombre);
                        lista.Add(p);
                        tbVer.Text += $"{p.ToString()} ya ha sido agregado";
                    }
                }
                #endregion
            }
        }
        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
          
        //}

        //private void btnListar_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            #region listado desordenado
            tbVer.Text += $"Lista Desordenada\r\n";

            foreach (Persona persona in lista)
            {
                tbVer.Text += $"{persona}";
            }
            #endregion region

            #region probando ordenar
            lista.Sort();
            tbVer.Text += $"Lista Ordenada\r\n";
            foreach (Persona persona in lista)
            {
                tbVer.Text += $"{persona}";
            }
            #endregion
        }
    }
}

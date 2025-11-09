using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quicksort
{
    public partial class Form_Quicksort : Form
    {
        Quicksort quicksort;
        public Form_Quicksort()
        {
            InitializeComponent();
            quicksort = new Quicksort(this);
        }

        Graphics graficos;
        bool ordenando = false;
        int[] numeros;

        private void Form_Quicksort_Paint(object sender, PaintEventArgs e)
        {
            // graficos
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graficos = e.Graphics;

            quicksort.Dibujar_arreglo(graficos, numeros);
            if (ordenando)
            {
                ordenando = false;
                if (numeros != null)
                {
                    quicksort.QuicksortRecursivo(numeros, 0, numeros.Count() - 1, graficos);
                    Thread.Sleep(500);
                    Refresh();
                }
            }
        }

        // ordenar
        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            Actualizar_arreglo();
            ordenando = true;
            Refresh();
        }

        // actualizar el arreglo cuando se cambia el texto
        private void txt_arreglo_TextChanged(object sender, EventArgs e)
        {
            Actualizar_arreglo();
        }

        private void Actualizar_arreglo()
        {
            // arreglo auxiliar
            string[] datos = txt_arreglo.Text.Split(',');
            // hacer que el arreglo tenga 
            numeros = new int[datos.Length];

            // agregar cada elemento del arreglo a la lista
            for (int i = 0; i < datos.Length; i++)
            {
                try
                {
                    // agregar el numero al arreglo
                    numeros[i] = int.Parse(datos[i]);
                }
                catch
                {
                    // eliminar el ultimo caracter si es una coma o doble coma
                    if ((!txt_arreglo.Text.EndsWith(",") || txt_arreglo.Text.EndsWith(",,") || txt_arreglo.Text.EndsWith(" ")) && !string.IsNullOrEmpty(txt_arreglo.Text))
                    {
                        // eliminar el ultimo caracter
                        txt_arreglo.Text = txt_arreglo.Text.Substring(0, txt_arreglo.Text.Length - 1);

                        txt_arreglo.Focus(); // Da el foco al TextBox
                        txt_arreglo.SelectionStart = txt_arreglo.Text.Length; // Coloca el cursor al final
                    }
                    else
                    {
                        // eliminar un item del centro cuando esta mal
                        if (!string.IsNullOrEmpty(txt_arreglo.Text) && !string.IsNullOrEmpty(datos[i]))
                        {
                            txt_arreglo.Text = txt_arreglo.Text.Replace(datos[i], "");
                            txt_arreglo.Text = txt_arreglo.Text.Replace(",,", ",");
                        }
                    }

                    // eliminar el promer caracter si es una coma
                    if (txt_arreglo.Text.StartsWith(","))
                    {
                        txt_arreglo.Text = txt_arreglo.Text.Substring(1);
                    }
                }
            }
            Refresh();
        }
    }
}

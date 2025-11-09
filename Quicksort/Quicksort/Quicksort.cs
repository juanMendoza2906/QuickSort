using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quicksort
{
    internal class Quicksort
    {
        public Quicksort(Form_Quicksort form)
        {
            Form = form;
        }

        // velocidad en la que se actualiza la visualizacion
        const int velocidad = 900;

        public Form_Quicksort Form { get; set; }

        // metodo principal para ordenar un arreglo usando Quicksort
        public void QuicksortRecursivo(int[] arreglo, int inicio, int fin, Graphics graficos)
        {
            // condicion base
            if (inicio < fin) // comprobar si hay mas de un elemento
            {
                // particionar el arreglo y obtener el indice del pivote
                int indicePivote = Particionar(arreglo, inicio, fin, graficos);

                // ordenar la parte izquierda
                QuicksortRecursivo(arreglo, inicio, indicePivote - 1, graficos); // pasar el arreglo, inicio y el indice del pivote -1

                // ordenar la parte derecha
                QuicksortRecursivo(arreglo, indicePivote + 1, fin, graficos); // pasar el arreglo, el indice del pivote +1 y fin
            }
        }

        // metodo para particionar el arreglo
        private int Particionar(int[] arreglo, int inicio, int fin, Graphics graficos)
        {
            int pivote = arreglo[fin]; // elegir el ultimo elemento como pivote
            int indice = inicio - 1; // indice del elemento mas pequeño

            Colorear_elemento(graficos, arreglo, fin, Brushes.DarkGreen); // colorear el pivote de verde obcuro
            Thread.Sleep(velocidad); // esperar

            // recorrer el arreglo de inicio a fin
            for (int i = inicio; i < fin; i++)
            {
                if (arreglo[i] < pivote) // si el elemento actual es menor que el pivote
                {
                    // incrementar el indice del elemento mas pequeño
                    indice++;
                    Intercambiar(arreglo, indice, i, graficos); // mover el elemento actual al indice del elemento mas pequeño

                }
            }

            // colocar el pivote en la posicion correcta
            Intercambiar(arreglo, indice + 1, fin, graficos);

            Colorear_elemento(graficos, arreglo, indice + 1, Brushes.Green); // colorear el pivote de verde
            Thread.Sleep(velocidad); // esperar

            // colorear los nodos menores al pivote
            for (int i = inicio; i < indice + 1; i++)
            {
                Colorear_elemento(graficos, arreglo, i, Brushes.Blue); // colorear los menores al pivote de azul
            }
            Thread.Sleep(velocidad); // esperar

            // colorear los nodos mayores al pivote
            for (int i = indice + 2; i <= fin; i++)
            {
                Colorear_elemento(graficos, arreglo, i, Brushes.Red); // colorear los mayores al pivote de rojo
            }
            Thread.Sleep(velocidad); // esperar


            return indice + 1;
        }

        // funcion para intercambiar dos elementos en el arreglo
        private void Intercambiar(int[] arreglo, int i, int j, Graphics graficos)
        {
            // intercambiar de la poisicion i a j
            int temp = arreglo[i]; // guardar el valor de i en una variable temporal
            arreglo[i] = arreglo[j]; // asignar el valor de j a i
            arreglo[j] = temp; // asignar el valor temporal a j

            // colorear los elementos intercambiados
            Thread.Sleep(velocidad / 3);// esperar
            Colorear_elemento(graficos, arreglo, i, Brushes.Beige);
            Colorear_elemento(graficos, arreglo, j, Brushes.Beige);
            Thread.Sleep(velocidad); // esperar
            Colorear_elemento(graficos, arreglo, i, Brushes.LightBlue);
            Colorear_elemento(graficos, arreglo, j, Brushes.LightBlue);
            Thread.Sleep(velocidad); // esperar
        }


        public void Colorear_elemento(Graphics graficos, int[] numeros, int indice, Brush color)
        {
            if (numeros != null && indice >= 0 && indice < numeros.Count())
            {
                // definir posicion del rectangulo
                Point posicion = new Point(Form.Width / numeros.Count() * indice, Form.Height / 2);
                // definir el tamaño del rectangulo
                Size tamaño = new Size(Form.Width / numeros.Count() - 5, Form.Width / numeros.Count());
                // ajustar tamaño si se sale del area de dibujo
                if (posicion.Y + tamaño.Height > Form.Height - 5)
                {
                    tamaño.Height = Form.Height - posicion.Y - 5;
                }
                // crear rectangulo
                Rectangle rectangulo = new Rectangle(posicion, tamaño);
                // rellenar rectangulo
                graficos.FillRectangle(color, rectangulo);
                graficos.DrawRectangle(Pens.Black, rectangulo);
                // calcular el centro del rectangulo
                Point posicion_centro = new Point(posicion.X + tamaño.Width / 2, posicion.Y + tamaño.Height / 2);
                // formato del texto
                StringFormat formato = new StringFormat();
                // alinear el texto en el centro del rectangulo
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;
                graficos.DrawString(numeros[indice].ToString(), Form.Font, Brushes.Black, posicion_centro.X, posicion_centro.Y, formato); // escribir el numero
            }
        }

        public void Dibujar_arreglo(Graphics graficos, int[] numeros)
        {
            if (numeros != null)
            {
                // dibujar el arreglo
                for (int i = 0; i < numeros.Count(); i++)
                {
                    // definir posicion del rectangulo
                    Point posicion = new Point(Form.Width / numeros.Count() * i, Form.Height / 2);
                    // definir el tamaño del rectangulo
                    Size tamaño = new Size(Form.Width / numeros.Count() - 5, Form.Width / numeros.Count());

                    // ajustar tamaño si se sale del area de dibujo
                    if (posicion.Y + tamaño.Height > Form.Height - 5)
                    {
                        tamaño.Height = Form.Height - posicion.Y - 5;
                    }

                    // crear rectangulo
                    Rectangle rectangulo = new Rectangle(posicion, tamaño);
                    // rellenar rectangulo
                    graficos.FillRectangle(Brushes.LightBlue, rectangulo);
                    graficos.DrawRectangle(Pens.Black, rectangulo);

                    // calcular el centro del rectangulo
                    Point posicion_centro = new Point(posicion.X + tamaño.Width / 2, posicion.Y + tamaño.Height / 2);

                    // formato del texto
                    StringFormat formato = new StringFormat();

                    // alinear el texto en el centro del rectangulo
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Center;
                    graficos.DrawString(numeros[i].ToString(), Form.Font, Brushes.Black, posicion_centro.X, posicion_centro.Y, formato); // escribir el numero

                }
            }
        }
    }
}

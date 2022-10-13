using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Integrador_Carritos
{
    class cubo
    {
        public int X { get; set; } //saber posición en eje X del circulo
        public int Y { get; set; } //saber posición en eje Y del circulo
        public int inflateX = 0; //tamaño del circulo inflado en el eje X
        public int inflateY = 0; //tamaño del circulo inflado en el eje Y
        Color RGB; //color personalizado para el circulo
        //Constructor de la clase circulo
        public cubo(Point ubicacion, Color RGB)
        {
            X = ubicacion.X; //detectar ubicación del circulo en eje X
            Y = ubicacion.Y; //detectar ubicación del circulo en eje Y
            this.RGB = RGB; //Inicializar color del circulo.
        }
        //Dibujar el circulo
        public void Dibujar(PaintEventArgs e)
        {
            //Inicializar los graficos
            Graphics g = e.Graphics;
            //Efecto de ilumincación para el circulo
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dibujo el contorno del circulo
            Pen contorno = new Pen(RGB, 4);
            //Relleno del circulo
            Brush relleno = new SolidBrush(RGB);
            //Dibujamos el controno del circulo: posicion de X, Y y ancho y alto del circulo ya "comido" por el auto
            g.DrawRectangle(contorno, X, Y, 27 + inflateX, +27 + inflateY);
            //Más o menos en el centro del circulo tendrá un color blanco
            g.FillRectangle(Brushes.White, X + 2, Y + 2, 23 + inflateX, 23 + inflateY);
            //Rellenamos el color del circulo del color deseaso
            g.FillRectangle(relleno, X + 6, Y + 6, 15 + inflateY, 15 + inflateY);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Librería de gráficos en 2D.
using System.Windows.Forms;

namespace Integrador_Carritos
{
    class auto
    {
        //variables globales de la clase auto:
        public int X { get; set}; //Me permite saber en que coordenada de X esta el auto
        Color RGB; //objeto que me permite pintar el auto de un color personalizado.
        //Método constructor de la clase auto
        public auto(int X, Color RGB)
        { //inicializo los objetos de los parametros
            this.X = X;
            this.RGB = RGB;
        }
        //Método en el cual dibujo el auto por partes: techo, puertas, vidrios, etc.
        public void Dibujar(PaintEventArgs e)
        {
            //Crear un objeto de tipo graphics
            Graphics g = e.Graphics;
            //Efectos y calidad de color
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Vamos a crear "regiones" para dibujar el auto
            #region Estructura de puntos del auto
            //Arreglo de puntos para la composición del auto
            Point[] auto =
            {
                //Definir el lado izquierdo del atuo
                //Point(X,Y) --> x = la va a tomar de la posición en la que está el auto, Y la voy a definir de acuerdo
                //al tamaño de la ventana.
                new Point(X, 425),
                new Point(X-3, 441),
                new Point(X-3, 451),
                new Point(X, 470),
                //Lado inferios del auto
                new Point(X+8, 473),
                new Point(X+16, 473),
                new Point(X+24, 470),
                //Lado derecho del auto
                new Point(X+27, 454),
                new Point(X+24, 441),
                new Point(X+24, 425),
                //Lado superio del auto
                new Point(X+16, 422),
                new Point(X+6, 422),
                new Point(X+24, 425),
            };
            //Dibujar la ventana superior del auto
            Point[] ventaSup =
            {
                //curva superior
                new Point(X+4, 433),
                new Point(X+21, 441),
                new Point(X+19, 440),
                new Point(X, 440),
            };
            //Dibujar parte inferior del auto
            Point[] ventaInf =
            {
                //parte inferior del auto
                new Point(X+4, 463),
                new Point(X+21, 463),
                new Point(X+19, 456),
                new Point(X+6, 456),
            };
            //Dibujo el techo del auto
            Rectangle techo = new Rectangle(X + 6, 440, 13, 16);
            #endregion
            //Pintar el auto de los colores personalizados
            #region Pintura auto
            //Definir color para los contornos a través de un plumon
            Pen contorno = new Pen(RGB, 4);
            //Definir color para el relleno del auto
            Brush techoC = new SolidBrush(RGB);
            //Color de los parabrisas del auto
            Brush parabrisas = new SolidBrush(Color.FromArgb(0, 0, 255));
            #endregion
            #region Dibujar auto
            //Colocar el relleno del auto
            g.FillClosedCurve(Brushes.White, auto);
            g.DrawBeziers(contorno, auto);
            //Rellenar el techo del auto
            g.FillRectangle(techoC, techo);
            //Rellenar parabrisas frontal
            g.FillPolygon(parabrisas, ventaSup);
            //Rellenar parabrisas trasero
            g.FillPolygon(parabrisas, ventaInf);
            #endregion
        }
    }
}

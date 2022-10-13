using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphics3DS; //Agregar libreria de 3D
//Para realizar el juego de carreras de autos necesitamos tres clases adicionales: auto, circulo, cubo.

namespace Integrador_Carritos
{
    public partial class fondo : Form
    {
        public fondo()
        {
            InitializeComponent();
        }
        #region Variables y objetos globales para que funcione el auto
        //Variables de apoyo para umentar el tamaño del circulo/cubo cuando el auto choque con ellas.
        int inflateX = 2;
        int inglateY = 2;
        //variable tipo enum para saber si el auto esta activo o no.
        enum estadoActualAuto
        {
            izquierda,
            derecha
        }
        //Objeto de tipo Graphics para inicializar los dibujos
        Graphics g;
        //Creo el carro con el cual voy a jugar
        auto car1;
        auto car2; //para tener dos carros en la competencia

        #endregion

        private void pista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fondo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fondo_Load(object sender, EventArgs e)
        {

        }
    }
}

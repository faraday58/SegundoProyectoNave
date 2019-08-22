using System;
using System.Drawing;

namespace JuegoNave_2020_I_G3
{
    class Nave : Personaje
    {
        /// <summary>
        /// Constructor de la Nave que define la posición inicial
        /// </summary>
        /// <param name="x">Define la posición de la Nave en el eje X de acuerdo a PosX</param>
        /// <param name="y">Define la posición de la Nave en el eje Y de acuerdo a PosY</param>

        public Nave(short x, short y)
        {
            PosX = x;
            PosY = y;
            SptPersonaje.Image = global::SegundoProyectoNave.Properties.Resources.shipm;
            SptPersonaje.Size = new Size(Ancho, Alto);
            SptPersonaje.Location = new Point(PosX, PosY);
            SptPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }



    }
}

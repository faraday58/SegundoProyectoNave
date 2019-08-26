using System;
using System.Drawing;

namespace SegundoProyectoNave
{
    class Nave : Personaje
    {
        public override short PosX
        {
            get => base.PosX;
            set
            {
                if( value < 0 )
                {
                    PosX = 0;
                }
                else if(  value
                    >  ConstanteJuego.anchoVentana - (2*this.Ancho) )
                {
                    PosX = (short)(ConstanteJuego.anchoVentana-2*this.Ancho);
                }
                else
                {
                    base.PosX= value;
                }
            }
        }

        public override short PosY
        {
            get => base.PosY;
            set
            {
                if (value<0)
                {
                    PosY = 0;
                }
                else if (value>ConstanteJuego.altoVentana-2*this.Alto)
                {
                    PosY = (short)(ConstanteJuego.altoVentana - 2 * this.Alto);
                }
                else
                {
                    base.PosY = value;
                }
            }
        }

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

        public override void Mover(short xdir, short ydir)
        {
            base.Mover(xdir, ydir);
            //Para mover dentro del formulario
            SptPersonaje.Location = new Point(PosX, PosY);
        }



    }
}

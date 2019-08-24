using System;
using System.Windows.Forms;
namespace SegundoProyectoNave
{ 
    class Personaje
    {

        #region Atributos
        private short posX;
        private short posY;
        private short ancho;
        private short alto;
        private PictureBox sptPersonaje;
        #endregion

        #region Propiedades
        public virtual short PosX { get => posX; set => posX = value; }
        public virtual short PosY { get => posY; set => posY = value; }
        public short Ancho { get => ancho; set => ancho = value; }
        public short Alto { get => alto; set => alto = value; }
        public PictureBox SptPersonaje { get => sptPersonaje; set => sptPersonaje = value; }
        #endregion

        #region Constructor
        public Personaje()
        {
            Ancho = 23;
            Alto = 48;
            SptPersonaje = new PictureBox();
        }
        #endregion

        #region Métodos
        public bool Intersecar(Personaje personaje)
        {
            short difx = Convert.ToInt16(Math.Abs(PosX - personaje.PosX));
            short dify = Convert.ToInt16(Math.Abs(PosY - personaje.PosY));

            if( difx >= 0  && difx < Ancho && dify >=0 && dify < Alto  )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Establece el movimiento del personaje en el eje X y Y
        /// </summary>
        /// <param name="xdir">Establece la cantidad de pixeles a desplazar en eje X</param>
        /// <param name="ydir">Establece la cantidad de pixeles a desplazar en eje Y</param>

        public virtual void Mover(short xdir, short ydir)
        {
            PosX += xdir;
            PosY += ydir;
        }


        #endregion


    }




}


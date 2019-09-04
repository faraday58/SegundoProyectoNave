using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SegundoProyectoNave
{
    class Bala : Personaje
    {
        public Bala(short PosX, short PosY,short anchoNave, short altoNave)
        {
            Ancho = (short)Properties.Resources.laser_boltsm.Width;
            Alto = (short)Properties.Resources.laser_boltsm.Height;
            this.PosX = (short)(PosX + anchoNave / 4);
            this.PosY = (short)(PosY-altoNave-Alto);
            SptPersonaje.Image = global::SegundoProyectoNave.Properties.Resources.laser_boltsm;
            SptPersonaje.Size = new Size(Ancho, Alto);
            SptPersonaje.Location = new Point(PosX, PosY);
            SptPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }

        public override void Mover(short xdir, short ydir)
        {
            xdir = 0;
            base.Mover(xdir,(short) -ydir);
            SptPersonaje.Location = new Point(PosX,PosY);

        }
    }
}

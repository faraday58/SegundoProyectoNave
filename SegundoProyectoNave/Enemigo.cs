﻿using System;
using System.Drawing;


namespace SegundoProyectoNave
{
    class Enemigo:Personaje
    {
        bool cambiaDirec;
        public Enemigo()
        {
            
            PosX = ConstanteJuego.anchoVentana/2;
            PosY = ConstanteJuego.altoVentana/3;
            SptPersonaje.Image = global::SegundoProyectoNave.Properties.Resources.enemy_small;
            SptPersonaje.Size = new Size(Ancho, Alto);
            SptPersonaje.Location = new Point(PosX, PosY);
            SptPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }
        public override short PosX
        {
            get => base.PosX;
            set
            {
                if (value < 0)//tendría que moverse a la izquierda siempre, no hay restricción para movimiento a la derecha
                {
                    PosX = ConstanteJuego.anchoVentana;
                }
               
                else
                {
                    base.PosX =value;
                }
            }
        }
        public override void Mover(short xdir, short ydir)
        {
            if (PosX >= ConstanteJuego.anchoVentana -2*(Properties.Resources.enemy_small.Width))
            {
                cambiaDirec = true;
            }
            if (PosX ==0)
            {
                cambiaDirec = false;
            }
            if (cambiaDirec == true)
            {
                xdir = (short)-xdir;
            }
            base.Mover(xdir, 0);
            SptPersonaje.Location = new Point(PosX, PosY);
        }
    }
}

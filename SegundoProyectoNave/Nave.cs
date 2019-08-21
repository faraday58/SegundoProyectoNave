using System;


namespace JuegoNave_2020_I_G3
{
    class Nave : Personaje
    {
        public Nave(short x, short y)
        {
            PosX = x;
            PosY = y;
            SptPersonaje.Image = global::SegundoProyectoNave.Properties.Resources.clouds_transparent;


        }

    }
}

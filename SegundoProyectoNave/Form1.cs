using System;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class Form1 : Form
    {
        private Nave miNave;
        private short despNave;
        private short despEnemigo;
        private Enemigo miEnemigo;

        public Form1()
        {
            InitializeComponent();
            this.Width = ConstanteJuego.anchoVentana;
            this.Height = ConstanteJuego.altoVentana;

            miNave = new Nave((short)(this.Width/2),(short)(this.Height- (2*48)));         
            despNave = 20;
            miEnemigo = new Enemigo();
            AgregarPersonaje();
            temporizadorLoop.Start();
        }

        public void AgregarPersonaje()
        {
            this.Controls.Add(miNave.SptPersonaje);
            this.Controls.Add(miEnemigo.SptPersonaje);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch( e.KeyCode   )
            {
                case Keys.Up:
                    miNave.Mover(0, (short)-despNave);
                    break;
                case Keys.Down:
                    miNave.Mover(0, despNave);
                    break;
                case Keys.Right:
                    miNave.Mover(despNave, 0);
                    break;
                case Keys.Left:
                    miNave.Mover((short)-despNave, 0);
                    break;


            }
        }

        private void temporizadorLoop_Tick(object sender, EventArgs e)
        {

            miEnemigo.Mover(despNave, 0);
            miNave.Balaser.Mover(0,(short)( 2 * despNave));
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Space )
            {
                miNave.Disparar();
                this.Controls.Add(miNave.Balaser.SptPersonaje);

            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class Form1 : Form
    {
        private Nave miNave;
        private short despNave;

        public Form1()
        {
            InitializeComponent();
            this.Width = ConstanteJuego.anchoVentana;
            this.Height = ConstanteJuego.altoVentana;

            miNave = new Nave((short)(this.Width/2),(short)(this.Height- (2*48)));
            AgregarPersonaje();
            despNave = 20;
        }

        public void AgregarPersonaje()
        {
            this.Controls.Add(miNave.SptPersonaje);
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
    }
}

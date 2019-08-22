using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoNave_2020_I_G3
{
    public partial class Form1 : Form
    {
        private Nave miNave;


        public Form1()
        {
            InitializeComponent();
            miNave = new Nave((short)(this.Width/2),(short)(this.Height- (2*48)));
            AgregarPersonaje();
        }

        public void AgregarPersonaje()
        {
            this.Controls.Add(miNave.SptPersonaje);
        }

    }
}

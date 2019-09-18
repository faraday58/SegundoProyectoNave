using System;
using Usuarios;

using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class FormRegistrar : Form
    {
        private Usuario[] usuarios;
        private Form FormPadre;

        

        private byte contUs;

        /// <summary>
        /// Constructor para especificar el Formulario que controla a este 
        /// </summary>
        /// <param name="FormPadre">Es el formulario que instancia al presente constructor</param>

        public FormRegistrar(Form FormPadre)
        {
            this.FormPadre = FormPadre;
            InitializeComponent();
            usuarios = new Usuario[3];
        }

        public byte ContUs
        {
            get => contUs;
            set
            {
                if (value == 3)
                {
                    contUs = 0;
                }
                else
                {
                    contUs = value;
                }
            } 
        }

        public Usuario[] Usuarios { get => usuarios;  }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NickName = txtNickName.Text;
            usuario.Password = txtbPassword.Text;
            usuario.Nombre = txtbNombre.Text;
            usuario.Pregunta = cmbPregunta.Items[cmbPregunta.SelectedIndex].ToString();
            usuario.Respuesta = txtbRespuesta.Text;
            usuarios[ContUs++] = usuario;

        }

        private void FormRegistrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPadre.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPadre.Show();
        }
    }
}

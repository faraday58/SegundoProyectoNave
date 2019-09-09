using System;
using Usuarios;

using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class FormRegistrar : Form
    {
        private Usuario[] usuarios;

        private byte contUs;
        public FormRegistrar()
        {
            InitializeComponent();
            usuarios = new Usuario[3];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NickName = txtNickName.Text;
            usuario.Password = txtbPassword.Text;
            usuario.Nombre = txtbNombre.Text;
            usuario.Pregunta = cmbPregunta.Items[cmbPregunta.SelectedIndex].ToString();
            usuario.Respuesta = txtbRespuesta.Text;


        }
    }
}

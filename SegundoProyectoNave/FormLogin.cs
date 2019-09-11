using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class FormLogin : Form
    {
        private Form1 formJuego;
        private FormRegistrar formRegistrar;
        string[] nomusuarios;
        string[] contraseñas;
        private ErrorProvider ErrorAcceso;
        public FormLogin()
        {
            ErrorAcceso = new ErrorProvider();
            nomusuarios = new string[] { "usuario1", "satan", "maya" };
            contraseñas = new string[] { "usuario1", "666", "0000" };
            InitializeComponent();
            txtbPassword.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            
            string nomUsuario = txtbLogin.Text;
            string passUsuario = txtbPassword.Text;
            for (int i = 0;i< nomusuarios.Length; i++)
            {
                if (formRegistrar != null)
                {
                    if (nomUsuario == formRegistrar.Usuarios[i].NickName && passUsuario == formRegistrar.Usuarios[i].Password)
                    {

                        if (formJuego == null)
                        {
                            formJuego = new Form1(this);
                            formJuego.Show();
                            this.Hide();
                            formJuego = null;

                        }
                        ErrorAcceso.Clear();
                        break;
                    }
                }
                else
                {
                    ErrorAcceso.SetError(txtbPassword, "Usuario o contraseña incorrecta");
                }

            }

            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(formRegistrar == null)
            {
                formRegistrar = new FormRegistrar(this);
                formRegistrar.Show();
                this.Hide();
             
            }
        }
    }
}

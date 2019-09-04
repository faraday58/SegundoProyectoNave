using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class FormLogin : Form
    {
        private Form1 formJuego;
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
                if (nomUsuario == nomusuarios[i] && passUsuario == contraseñas[i])
                {
                    ErrorAcceso.Clear();
                    if (formJuego == null)
                    {
                        formJuego = new Form1(this);
                        formJuego.Show();
                        this.Hide();
                        formJuego = null;

                    }

                }
                else
                {
                    ErrorAcceso.SetError(txtbPassword, "Usuario o contraseña incorrecta");
                }

            }

            
        }

    }
}

using System;
using Usuarios;

using System.Windows.Forms;

namespace SegundoProyectoNave
{
    public partial class FormRegistrar : Form
    {
        private Usuario[] usuarios;
        private Form FormPadre;
        private ErrorProvider errorProvider;
        

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
            //Instanciando error Provider
            errorProvider = new ErrorProvider();
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
            byte i = 0;
            try            
           {
                Usuario usuario = new Usuario();
                usuario.NickName = txtNickName.Text; 
                
                if(usuario.NickName =="")
                {
                    i = 1;
                    string error = "No puedes dejar el campo vacío";
                    throw new ApplicationException(error);
                }
                usuario.Password = txtbPassword.Text;
                if(txtbPassword.Text =="")
                {
                    txtbPassword.Text = usuario.Password;
                }
                else if(usuario.Password.Contains("123"))
                {
                    i = 4;
                    //string error = "Debe tener una mayuscula, una minuscula y un numero";
                    string error = "No debe tener números consecutivos";
                    throw new ApplicationException(error);
                }
                bool mayus=false, minus=false,num= false;
                for (int j = 0; j < usuario.Password.Length; j++)
                {
                    if (usuario.Password[j]>64&&usuario.Password[j]<91)
                    {
                        mayus = true;
                        break;
                    }
                }
                for (int j = 0; j < usuario.Password.Length; j++)
                {
                    if(usuario.Password[j] > 96 && usuario.Password[j] < 122)
                    {
                        minus = true;
                        break;
                    }
                }
                for (int j = 0; j < usuario.Password.Length; j++)
                {
                    if (usuario.Password[j] > 47 && usuario.Password[j] < 58)
                    {
                        num = true;
                        break;
                    }
                }            
                
                if (mayus == false ||minus == false ||num==false)
                {
                    i = 5;
                    string error = "Debe tener al menos una mayus, una minus y un numero";
                    throw new ApplicationException(error);
                }
                


                usuario.Nombre = txtbNombre.Text;
                if (usuario.Nombre == "")
                {
                    i = 2;
                    string error = "No puedes dejar el campo vacío";
                    throw new ApplicationException(error);
                }
                usuario.Pregunta = cmbPregunta.Items[cmbPregunta.SelectedIndex].ToString();
                usuario.Respuesta = txtbRespuesta.Text;
                if (usuario.Respuesta == "")
                {
                    i = 3;
                    string error = "No puedes dejar el campo vacío";
                    throw new ApplicationException(error);
                }
                usuarios[ContUs++] = usuario;
            }
           
            catch(ApplicationException error )
            {
                switch (i)
                {
                    case 1:
                        errorProvider.SetError(txtNickName, error.Message);
                        break;
                    case 2:
                        errorProvider.SetError(txtbNombre, error.Message);
                        break;
                    case 3:
                        errorProvider.SetError(txtbRespuesta, error.Message);
                        break;
                    case 4:
                        errorProvider.SetError(txtbPassword, error.Message);
                        break;
                    case 5:
                        errorProvider.SetError(txtbPassword, error.Message);
                        break;

                }
       
                
            }
            catch(ArgumentOutOfRangeException )
            {
                errorProvider.SetError(cmbPregunta, "Debes seleccionar una pregunta");
            }
            catch
            {
                MessageBox.Show("Hubo un error");

            }
            

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

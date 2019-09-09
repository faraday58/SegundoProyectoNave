using System;


namespace Usuarios
{
    public class Usuario
    {
        #region Atributos
        private string nickName;
        private string password;
        private string nombre;
        private string correo;
        private string pregunta;

        #endregion Atributos

        #region Propiedades
        public string NickName { get => nickName; set => nickName = value; }
        public string Password
        {
            get => password;
            set
            {
                if( value == "" )
                {
                    password = GenerarCadena();
                }
                else
                {
                    password = value;
                }
                
            }
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pregunta { get => pregunta; set => pregunta = value; }
        #endregion Propiedades

        #region Metodos

        public string GenerarCadena()
        {
            string passAleatorio="";
            Random aleatorio = new Random();
            int[] contra = new int[12];
            for (int i = 0; i < 12; i++)
            {
                contra[i] = aleatorio.Next(33, 126);
                passAleatorio = passAleatorio + (char)contra[i];
            }
            /*byte[] buffer = new byte[12];
            aleatorio.NextBytes(buffer);

           for (int i=0;i<12;i++)
            {
                while (buffer[i]>122||(33> buffer[i] || (buffer[i]>93 && buffer[i] <97)))
                {
                    buffer[i] = (byte)aleatorio.Next();
                }
            }

            foreach(byte caracter in buffer    )
            {
                passAleatorio = passAleatorio + (char)caracter;
            }*/
            return passAleatorio;

        }

        
        #endregion Metodos

    }
}

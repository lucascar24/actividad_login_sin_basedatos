namespace BugTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            //Validacion de campo de usuario no este vacio
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            //Validacion de campo de contrase�a no este vacio
            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Se debe ingresar un contrase�a");
                return;
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //Validacion de campo de usuario no este vacio
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            //Validacion de campo de contrase�a no este vacio
            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Se debe ingresar un contrase�a");
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema");
            this.Close();
            //Validacion de que las credenciales ingresadas sean las correctas, caso contrario informar con un MessageBox

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
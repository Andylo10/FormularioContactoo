namespace FormularioContactoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {

            {
                // Obtener los valores de los TextBox
                string nombre = TextBoxNombre.Text.Trim();
                string email = TextBoxEmail.Text.Trim();
                string mensaje = TextBoxMensaje.Text.Trim();

                // Verificar si todos los campos están completos
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mensaje))
                {
                    LabelEstado.Text = "Por favor, complete todos los campos.";
                    LabelEstado.ForeColor = Color.Red;  // Mostrar en rojo si hay error
                }
                else
                {
                    LabelEstado.Text = "Formulario enviado correctamente.";
                    LabelEstado.ForeColor = Color.Green;  // Mostrar en verde si todo está bien
                }
            }



        }
    }
}

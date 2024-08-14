
namespace FormularioContactoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonEnviar = new Button();
            TextBoxNombre = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxMensaje = new TextBox();
            EtiquetaNombre = new Label();
            EtiquetaEmail = new Label();
            EtiquetaMensaje = new Label();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // ButtonEnviar
            // 
            ButtonEnviar.Location = new Point(241, 208);
            ButtonEnviar.Name = "ButtonEnviar";
            ButtonEnviar.Size = new Size(161, 49);
            ButtonEnviar.TabIndex = 0;
            ButtonEnviar.Text = "Enviar";
            ButtonEnviar.UseVisualStyleBackColor = true;
            ButtonEnviar.Click += Enviar_Click;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(189, 58);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(304, 23);
            TextBoxNombre.TabIndex = 1;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(189, 104);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(304, 23);
            TextBoxEmail.TabIndex = 2;
            // 
            // TextBoxMensaje
            // 
            TextBoxMensaje.Location = new Point(189, 147);
            TextBoxMensaje.Name = "TextBoxMensaje";
            TextBoxMensaje.Size = new Size(304, 23);
            TextBoxMensaje.TabIndex = 3;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(109, 66);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(54, 15);
            EtiquetaNombre.TabIndex = 4;
            EtiquetaNombre.Text = "Nombre:";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Location = new Point(75, 107);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(108, 15);
            EtiquetaEmail.TabIndex = 5;
            EtiquetaEmail.Text = "Correo Electronico:";
            // 
            // EtiquetaMensaje
            // 
            EtiquetaMensaje.AutoSize = true;
            EtiquetaMensaje.Location = new Point(109, 149);
            EtiquetaMensaje.Name = "EtiquetaMensaje";
            EtiquetaMensaje.Size = new Size(54, 15);
            EtiquetaMensaje.TabIndex = 6;
            EtiquetaMensaje.Text = "Mensaje:";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(227, 284);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(42, 15);
            LabelEstado.TabIndex = 7;
            LabelEstado.Text = "Estado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 326);
            Controls.Add(LabelEstado);
            Controls.Add(EtiquetaMensaje);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaNombre);
            Controls.Add(TextBoxMensaje);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNombre);
            Controls.Add(ButtonEnviar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            // Aquí agregas la implementación para manejar el clic en el botón
            string nombre = TextBoxNombre.Text.Trim();
            string email = TextBoxEmail.Text.Trim();
            string mensaje = TextBoxMensaje.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mensaje))
            {
                LabelEstado.Text = "Por favor, complete todos los campos.";
                LabelEstado.ForeColor = Color.Red;
            }
            else
            {
                LabelEstado.Text = "Formulario enviado correctamente.";
                LabelEstado.ForeColor = Color.Green;
            }


            {
                throw new NotImplementedException();
            }
        }
    

        #endregion

        private Button ButtonEnviar;
        private TextBox TextBoxNombre;
        private TextBox TextBoxEmail;
        private TextBox TextBoxMensaje;
        private Label EtiquetaNombre;
        private Label EtiquetaEmail;
        private Label EtiquetaMensaje;
        private Label LabelEstado;
    }
}


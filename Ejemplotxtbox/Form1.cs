namespace Ejemplotxtbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2._Mensaje = "Saludos";
            Persona persona = new Persona();
            form2.persona.Nombre = "ffff";
            form2.persona.Apellido = "ddddd";
            form2.persona.Edad = "3";
            form2.Show();
        }
    }
}
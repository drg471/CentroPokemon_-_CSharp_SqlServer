using System;
using System.Windows.Forms;

namespace Tarea3RodriguezGarciaDavid
{
    public partial class Form1 : Form
    {
        AppMainForm mainForm = new AppMainForm();

        public Form1()
        {
            InitializeComponent();
            FormLocked(); // Llama al método para bloquear la ventana
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1300; // Establecer intervalo en milisegundos
            timer1.Start(); // Iniciar el temporizador
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            mainForm.Show();
            this.Hide();
        }

        // Método que configura la visualización de la ventana
        private void FormLocked()
        {
            FormBorderStyle = FormBorderStyle.None; // Oculta los bordes de la ventana
            StartPosition = FormStartPosition.CenterScreen; // Centra la ventana en la pantalla
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

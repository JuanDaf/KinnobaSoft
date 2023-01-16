using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisKinnova
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }
       
        private void Herramientas_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxApagar_Click(object sender, EventArgs e)
        {
            if (panelApagar.Visible.Equals(false))
            {
                panelApagar.Visible = true;
            }
            else
            {
                panelApagar.Visible = false;
            }
        }

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
        }  
    private void buttonTareas_Click(object sender, EventArgs e)
        {
            this.Close();
            Tareas tareas = new Tareas();
            tareas.Show();

        }

        private void buttonAsuntos_Click(object sender, EventArgs e)
        {
            this.Close();
            Asuntos asuntos = new Asuntos();    
            asuntos.Show();
        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {
            this.Close();
            Horario horario = new Horario();
            horario.Show();

        }

        private void buttonJuegos_Click(object sender, EventArgs e)
        {
            this.Close();
            Juegos juegos = new Juegos();
            juegos.Show();
        }

        private void buttonBiblioteca_Click(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n nodisponible";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu.ActiveForm.Hide();
            Apagar apagar = new Apagar();
            apagar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu.ActiveForm.Hide(); 
            Reiniciar reiniciar = new Reiniciar();
            reiniciar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n nodisponible";
                panelNotificar.Location = new Point(202,6);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Word word = new Word();
            word.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            PowerPoint powerPoint = new PowerPoint();
            powerPoint.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Paint paint = new Paint();
            paint.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Scratch scratch = new Scratch();
            scratch.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            Aprende aprende = new Aprende();
            aprende.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            Numeros numeros = new Numeros();
            numeros.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
            Ciencia ciencia = new Ciencia();
            ciencia.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Archivos archivos = new Archivos();
            archivos.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            Duolingo duolingo = new Duolingo();
            duolingo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n nodisponible";
              
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n nodisponible";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

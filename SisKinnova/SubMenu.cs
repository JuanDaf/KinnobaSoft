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
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void panelnoti()
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n no disponible";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Archivos archivos = new Archivos();
            archivos.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Tareas tareas = new Tareas();
            tareas.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Monitoreo monitoreo = new Monitoreo();
            monitoreo.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Virus virus = new Virus();
            virus.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Reloj reloj = new Reloj();
            reloj.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Juegos juegos = new Juegos();
            juegos.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            Horario horario = new Horario();
            horario.Show();
        }
    }
}

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
    public partial class Asuntos : Form
    {
        public Asuntos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            todopanel();
        }
        public void todopanel()
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n no disponible";
                textBoxescribir.Visible = false;
                textBoxescribir.Text = "Escribe...";
                pictureBox2.Visible = true;
                button7.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            todopanel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            todopanel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            todopanel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            textBoxescribir.Visible = true;
            button7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(true))
            {
                panelNotificar.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxescribir.Visible=false;
            textBoxescribir.Text = "Escribe...";
            button7.Visible = false;
            pictureBox2.Visible = true;
        }

        private void Asuntos_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

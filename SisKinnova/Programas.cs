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
    public partial class Programas : Form
    {
        public Programas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void notifi(string texto)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = texto;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            notifi("Scratch \n no disponible para \n desinstalar");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notifi("Aprende a leer \n no disponible para \n desinstalar");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            notifi("Números \n no disponible para \ndesinstalar");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            notifi("Ciencia \n no disponible para \n desinstalar");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            notifi("Duolingo \n no disponible para \ndesinstalar");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }
    }
}

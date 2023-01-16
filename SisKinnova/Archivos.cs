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
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void notifi(string text)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = text;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            notifi("Archivo pdf \n lectura no disponible");  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notifi("Archivo ppt \n lectura no disponible");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            notifi("Archivo docx \n lectura no disponible");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            notifi("Archivo xlsx \n lectura no disponible");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            notifi("Archivo txt \n lectura no disponible");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }
    }
}

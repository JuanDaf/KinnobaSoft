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
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();
        }

        public void notifi(string texto)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = texto;
            }
        }
        private void label26_Click(object sender, EventArgs e)
        {
            notifi("Cambio de \n contraseña \n no disponible");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            notifi("El usuario \n no se puede \n modificar");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

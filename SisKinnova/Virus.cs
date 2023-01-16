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
    public partial class Virus : Form
    {
        public Virus()
        {
            InitializeComponent();
        }
        public void notifi()
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción \n no disponible";
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notifi();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            notifi();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            notifi();
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

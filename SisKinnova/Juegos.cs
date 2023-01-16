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
    public partial class Juegos : Form
    {
        public Juegos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Juego \n no disponible";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible=false;   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Juego \n no disponible";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Juego \n no disponible";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Juego \n no disponible";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Need need = new Need();
            need.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Need need = new Need();
            need.Show();
        }
    }
}

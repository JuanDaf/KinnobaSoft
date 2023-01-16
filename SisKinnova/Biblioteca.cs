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
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTareas_Click(object sender, EventArgs e)
        {
            if (button9.Visible.Equals(false))
            {
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                label1.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
        }

        private void textBoxBuscar_Leave(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "Buscar...";
        }

        public void notifi()
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opción\n no disponible";
            }
        }

        public void cerrarmate()
        {
            if (button9.Visible.Equals(true))
            {
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                label1.Visible = true;
                pictureBox1.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            notifi();
            cerrarmate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifi();
            cerrarmate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            notifi();
            cerrarmate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notifi();
            cerrarmate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            notifi();
            cerrarmate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            notifi();
            cerrarmate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                textBoxescribir.Text = "";
                label1.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(true))
            {
                panelNotificar.Visible = false;
                
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

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBoxescribir.Visible = true;
        }

        private void Tareas_Load(object sender, EventArgs e)
        {

        }
    }
}

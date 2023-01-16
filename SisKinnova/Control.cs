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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }


        public void notifi(string text)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = text; 
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            notifi("Opción \n no disponible");  
        }

        private void button11_Click(object sender, EventArgs e)
        {
            notifi("Opción \n no disponible");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            notifi("Personalización \n no disponible");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Programas programas = new Programas();
            programas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cuentas cuentas = new Cuentas();
            cuentas.Show();
        }
    }
}

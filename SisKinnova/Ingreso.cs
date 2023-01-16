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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!textBoxpass.Text.Equals(""))
            {
                if (textBoxpass.PasswordChar.Equals('*'))
                {
                    textBoxpass.PasswordChar = '\0';

                }
                else
                {
                    textBoxpass.PasswordChar = '*';
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "123")
            {
                textBoxpass.Text = null;
                this.Close();
                Bienvenida bienvenida = new Bienvenida();
                bienvenida.Show();
            }
            else
            {
                textBoxpass.Text = null;
                panelNotificar.Visible = true;
                labelnotificar.Text = "Error... \n intenta de nuevo";
                panelNotificar.Location = new Point(552,513);
              
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(245, 666);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(245, 666);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(104, 29);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (panelOpcion.Visible.Equals(false))
            {
                panelOpcion.Visible = true;
            }
            else
            {
                panelOpcion.Visible = false;
                panelApagar.Visible = false;
                panelBateria.Visible = false;
                panelLenguaje.Visible = false;
                panelNotificar.Visible = false;
                panelWifi.Visible = false;
                panelOpciones.Visible = false;
            }
        }

        private void pictureBoxApagar_Click(object sender, EventArgs e)
        {
            if (panelApagar.Visible.Equals(false))
            {
                panelApagar.Visible = true;

            }
            else
            {
                panelApagar.Visible = false;
            }
        }

        private void pictureBoxOpciones_Click(object sender, EventArgs e)
        {
            if (panelOpciones.Visible.Equals(false))
            {
                panelOpciones.Visible = true;
            }
            else
            {
                panelOpciones.Visible = false;
            }
        }

        private void pictureBoxWifi_Click(object sender, EventArgs e)
        {
            if (panelWifi.Visible.Equals(false))
            {
                panelWifi.Visible = true;
            }
            else
            {
                panelWifi.Visible = false;
            }
        }

        private void pictureBoxBateria_Click(object sender, EventArgs e)
        {
            if (panelBateria.Visible.Equals(false))
            {
                panelBateria.Visible = true;
            }
            else
            {
                panelBateria.Visible = false;
            }
        }

        private void pictureBoxIdioma_Click(object sender, EventArgs e)
        {
            if ( panelLenguaje.Visible.Equals(false))
            {
                panelLenguaje.Visible = true;
            }
            else
            {
                panelLenguaje.Visible = false;
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpc_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(724, 368);
            }
        }

        private void buttonTeclado_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(724, 368);
            }
        }

        private void buttonWifi_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(724, 368);
            }
        }

        private void buttonBateria_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(724, 368);
            }
        }

        private void buttonIdioma_Click(object sender, EventArgs e)
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "Opcion \n no disponible";
                panelNotificar.Location = new Point(724, 368);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apagar apagar = new Apagar();
            apagar.Show();
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reiniciar reiniciar = new Reiniciar();
            reiniciar.Show();
        }
    }
}

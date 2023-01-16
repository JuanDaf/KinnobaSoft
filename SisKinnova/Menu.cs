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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible.Equals(false))
            {
                panelMenu.Visible = true;
            }
            else
            {
              
                panelMenu.Visible = false;
                panelNotificar.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelfechahora.Text = DateTime.Now.ToLongTimeString();

            labelFecha.Text = DateTime.Now.ToLongDateString();

        }

        public void abrirVentanas(Object formulariohijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form form = formulariohijo as Form;
            form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(form);
            this.panelContenido.Tag = form;
            form.Show();

        }
        int cont = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cont++;
            //if (panelContenido.Visible.Equals(false))
            //{
                //panelContenido.Visible = true;
            if (cont.Equals(2))
            {
                
                panelContenido.Controls.Clear();
                cont = 0;
            }
            else
            {
               
                abrirVentanas(new Herramientas());
            }
            //}
            //else
            //{
            //    panelContenido.Visible = false;
            //}
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if (panelContenido.Visible.Equals(false))
            //{
                //panelContenido.Visible = true;
                abrirVentanas(new SubMenu());
            //}
            //else
            //{
            //    panelContenido.Visible = false;
            //}
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (panellateral.Visible.Equals(false))
            {
                
                panellateral.Visible = true;
                panel1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panellateral.Visible = false;
            panel1.Visible = true;
        }

        public void panelnoti()
        {
            if (panelNotificar.Visible.Equals(false))
            {
                panelNotificar.Visible = true;
                labelnotificar.Text = "No \n disponible";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelNotificar.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panelnoti();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelNotificar.Location = new Point(148,107);
            panelnoti();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Virus virus = new Virus();
            virus.Show();
            panellateral.Visible = false;
            panel1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //panelContenido.Visible = false;
            //if (panelContenido.Visible.Equals(false))
            //{
                //panelContenido.Visible = true;
                abrirVentanas(new Horario());
                panellateral.Visible = false;
                panel1.Visible = true;
            //}
            //else
            //{
            //    panelContenido.Visible =  false;
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //panelContenido.Visible = false;
            //if (panelContenido.Visible.Equals(false))
            //{
                //panelContenido.Visible = true;
                abrirVentanas(new Tareas());
                panellateral.Visible = false;
                panel1.Visible = true;
            //}
            //else
            //{
            //    panelContenido.Visible = false;
            //}
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //if (panelContenido.Visible.Equals(false))
            //{
                //panelContenido.Visible = true;
                Chrome chrome = new Chrome();
                chrome.Show();
            //}
            //else
            //{
            //    panelContenido.Visible = false;
            //}
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Archivos arch = new Archivos();
            arch.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panellateral.Visible = false;
            Control control = new Control();
            control.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelNotificar.Location = new Point(148, 107);
            panelnoti();
        }
    }
    }

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
    public partial class Reiniciar : Form
    {
        public Reiniciar()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont.Equals(100))
            {
                this.Hide();
                Arranque arranque = new Arranque();
                arranque.Show();
                
            }
        }
    }
}

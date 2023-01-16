namespace SisKinnova
{
    public partial class Arranque : Form
    {
        public Arranque()
        {
            InitializeComponent();
        }
        bool paso = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value == 100)
            {
                paso = true;
                timer1.Stop();
                timer1.Dispose();
                next();

            }
        }

        public void next()
        {
            if (paso == true)
            {
                this.Hide();    
                Ingreso ingreso = new Ingreso();
                ingreso.Show();
            }
        }
    }
}
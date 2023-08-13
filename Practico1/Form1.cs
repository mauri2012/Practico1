namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
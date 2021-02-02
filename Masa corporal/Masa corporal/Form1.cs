using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masa_corporal
{
    public partial class Form1 : Form
    {

        static Operacion op = new Operacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {
            lblRes.Text = (op.Calcular(float.Parse(txtv1.Text), float.Parse(txtv2.Text)).ToString());
        }

        private void cmdNormal_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Tu peso es Normal");
        }

        private void cmdSobre_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Tienes Sobrepeso");
        }

        private void cmdObe_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Tu peso se domina como Obesidad");
        }

        private void lblRes_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Selecciona al lado derecho tu peso conforme tu resultado");
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }
    }
}

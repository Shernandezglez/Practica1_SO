using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorDeProcesos
{
    public partial class Form1 : Form
    {
        Algoritmos p;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProcesos_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnMostrarProcesos_Click(object sender, EventArgs e)
        {
            
            txtResultados.Text += p.mostrarProcesos().ToString();

            
        }

        private void btnLlenarProcesos_Click(object sender, EventArgs e)
        {
            int np = Convert.ToInt32(txtNumProcesos.Text);
            int cMax = Convert.ToInt32(txtTiempoMaximo.Text);
            p = new Algoritmos(np, cMax);
            p.llenarProcesos();
        }

        private void btnCalcularFCFS_Click(object sender, EventArgs e)
        {
            p.FCFS();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularLJF_Click(object sender, EventArgs e)
        {
            p.LongJobFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = p.mostrarPromedios().ToString();
        }

        private void btnCalcularSJF_Click(object sender, EventArgs e)
        {
            p.ShortJobFirst();
        }
    }
}

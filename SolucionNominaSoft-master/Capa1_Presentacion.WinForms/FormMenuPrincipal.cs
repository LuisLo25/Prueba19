using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa1_Presentacion.WinForms
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionarNominaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGestionarContrato procesar = new FormGestionarContrato();
            procesar.Show();
        }

        private void procesarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProcesarNomina procesar = new FormProcesarNomina();
            procesar.Show();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

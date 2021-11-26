using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;
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
    public partial class FormBuscarNomina : Form
    {
        private List<Nomina> listaNomina;
       
        ProcesarNominaServicio procesarNominaServicio;
        public FormBuscarNomina()
        {
            InitializeComponent();
           
            InitService();
        }
        private void InitService()
        {
            procesarNominaServicio = new ProcesarNominaServicio();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarNomina_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            MessageBox.Show("Hola");
        }
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

            MessageBox.Show("Hola");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id = (this.listaNomina[e.RowIndex]).Nomina_id;
            var response = this.procesarNominaServicio.GetNominaById(id);
            if (response != null)
            {
                FormProcesarNomina viewForm = new FormProcesarNomina(response);
                this.Close();
                viewForm.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarNomina_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscarNomina_Click_1(object sender, EventArgs e)
        {
            var text = textSearch.Text;
            var listaNomina = procesarNominaServicio.GetNominaList(text);
            if (listaNomina.Count > 0)
            {
                this.listaNomina = listaNomina;
                dtNominas.DataSource = listaNomina;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormProcesarNomina frmProcess = new FormProcesarNomina();
            this.Close();
            frmProcess.Show();
        }
    }
}

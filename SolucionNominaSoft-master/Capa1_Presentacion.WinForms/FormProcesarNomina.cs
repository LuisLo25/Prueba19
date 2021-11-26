using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capa1_Presentacion.WinForms
{
    public partial class FormProcesarNomina : Form
    {
       // private List<Nomina> listaNomina;
        private Nomina nominaModel;
        ProcesarNominaServicio nominaService;
        public FormProcesarNomina(Nomina nominaModel = null)
        {
            InitializeComponent();
            InitService();
            this.eneableOrDisableComponents(0);
            if (nominaModel != null)
            {
                this.nominaModel = nominaModel;
                loadModelFroms();
            }
            nominaModel = new Nomina();

        }

        private void InitService()
        {
            nominaService = new ProcesarNominaServicio();
            cboPeriodoNomina.ValueMember = "periodo_id";
            cboPeriodoNomina.DisplayMember = "Descripcion";
            var response = nominaService.GetPeriodoNominaList();
            cboPeriodoNomina.Items.Clear();
            foreach (var i in response)
            {
                cboPeriodoNomina.Items.Add(i);

            }

        }

        private void loadModelFroms()
        {
            FromDate.Value = nominaModel.PeriodoDeNomina.Fechainicio;
            ToDate.Value = nominaModel.PeriodoDeNomina.Fechafin;
            textDescription.Text = nominaModel.Descripcion;
            cboPeriodoNomina.SelectedItem = nominaModel.PeriodoDeNomina;
            var result = nominaService.GetBoletaList(nominaModel.Nomina_id);
            if (result.pagos.Count > 0)
            {
                dtoPaymentList.DataSource = result.pagos;
                
                this.eneableOrDisableComponents(2);
            }
            else
            {
                this.eneableOrDisableComponents(2);
            }
            textNeto.Text = result.AllPaymentDocument.ToString();
            textEmploye.Text = result.CountEMployes.ToString();
            textAllNomina.Text = result.IngresoNomina.ToString();
            textRetencion.Text = result.RegienPensionario.ToString();
            if (nominaModel.Cerrada)
            {
                btnClose.Enabled = !nominaModel.Cerrada;
            }


        }
        private void eneableOrDisableComponents(int caseOption)
        {
            switch (caseOption)
            {
                case 1:
                    btnSearchData.Enabled = !Enabled;
                    ToDate.Enabled = !ToDate.Enabled;
                    FromDate.Enabled = !FromDate.Enabled;
                    cboPeriodoNomina.Enabled = !cboPeriodoNomina.Enabled;
                    textDescription.Enabled = !textDescription.Enabled;
                    btnGenerate.Enabled = !btnSaveN.Enabled;
                    btnSaveN.Enabled = !btnSaveN.Enabled;
                    break;
                case 2:
                    btnCreate.Enabled = false;
                    FromDate.Enabled = false;
                    ToDate.Enabled = false;
                    cboPeriodoNomina.Enabled = false;
                    textDescription.Enabled = false;
                    btnGenerate.Enabled = false;
                    //btnSaveN.Enabled = false;
                    btnClose.Enabled = !btnClose.Enabled;
                    btnDelete.Enabled = !btnDelete.Enabled;
                    break;
                default:
                    btnSearchData.Enabled = true;
                    btnCreate.Enabled = true;
                    FromDate.Enabled = !FromDate.Enabled;
                    ToDate.Enabled = !ToDate.Enabled;
                    cboPeriodoNomina.Enabled = !cboPeriodoNomina.Enabled;
                    textDescription.Enabled = !textDescription.Enabled;
                    btnGenerate.Enabled = false;
                    btnSaveN.Enabled = false;
                    btnCancel.Enabled = true;
                    btnClose.Enabled = false;
                    btnDelete.Enabled = false;
                    textNeto.Enabled = !textNeto.Enabled;
                    textEmploye.Enabled = !textEmploye.Enabled;
                    textAllNomina.Enabled = !textAllNomina.Enabled;
                    textRetencion.Enabled = !textRetencion.Enabled;
                    break;

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "¿Está seguro de cerrar la Nómina?. Si cierra la Nómina no se podrán modificar los pagos generados de la Nómina ni eliminar la Nómina";
            if (MessageBox.Show(message, "Si cerrar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = nominaService.CloseNomina(nominaModel.Nomina_id);
                if (result > 0)
                {
                    MessageBox.Show("Se cerró la Nómina y se podrán enviar las boletas de pago a los empleados");
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Error al cerrar la Nómina");
                }
            }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormProcesarNomina_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void cboPeriodoNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPeriodoNomina.SelectedIndex == -1)
                return;

            if (cboPeriodoNomina.SelectedItem == null)
                return;

            PeriodoDeNomina item = (PeriodoDeNomina)cboPeriodoNomina.SelectedItem;
            FromDate.Value = item.Fechainicio;
            ToDate.Value = item.Fechafin;
            nominaModel = new Nomina() { };
            nominaModel.PeriodoDeNomina = new PeriodoDeNomina() { Periodo_id = item.Periodo_id };
        }
        private bool ValidaIngresoData()
        {
            if (String.IsNullOrEmpty(textDescription.Text))
            {
                MessageBox.Show("Ingrese una descripción para su periodo de nomina");
                return false;
            }
            if (textDescription.TextLength > 18)
            {
                MessageBox.Show("La descripición del periodo no puede ser mayor a 18  carecteres");
                return false;
            }
            if (cboPeriodoNomina.SelectedIndex == -1)
            {
                MessageBox.Show("Debe especificar el periodo de la operacion.", "Periodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (issueData.Value == null)
            {
                MessageBox.Show("Debe especificar la fecha de emision de la operacion.", "Fecha Emision", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (ValidaIngresoData() == false)
            {
                return;
            }
            nominaModel.Fecha = issueData.Value;
            nominaModel.Descripcion = textDescription.Text;
            nominaModel.PeriodoDeNomina.Fechainicio = FromDate.Value;
            nominaModel.PeriodoDeNomina.Fechafin = ToDate.Value;
            var result = nominaService.Save(nominaModel);
            if (result > 0)
            {
                MessageBox.Show("Nomina creada exitosamente");
                ClearControls();
            }
            else
            {
                MessageBox.Show("Error  al grabar Nomina");
            }
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            FormBuscarNomina formBuscarNomina = new FormBuscarNomina();
            formBuscarNomina.Show();
            this.Close();
        }

        private void textAllNomina_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.eneableOrDisableComponents(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearControls()
        {
            textNeto.Text = "";
            textEmploye.Text = "";
            textAllNomina.Text = "";
            textRetencion.Text = "";
            textDescription.Text = "";
            cboPeriodoNomina.SelectedItem = null;
            dtoPaymentList.DataSource = null;
            dtoPaymentList.Refresh();
            this.eneableOrDisableComponents(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nominaModel.Cerrada)
            {
                MessageBox.Show("Esta Nomina ya fue cerrada. Solo esta permitido  eliminar una nomina cuando no este cerrada");
                return;
            }
            string message = "¿Está seguro de eliminar la Nómina?. Si elimina la Nómina también de eliminaran los pagos generados de la Nómina";
            if (MessageBox.Show(message, "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = nominaService.DeleteNomina(nominaModel.Nomina_id);
                if (result > 0)
                {
                    MessageBox.Show("Se eliminó la Nómina");
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la Nómina");
                }
            }
        }

        private void textRetencion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarNomina formBuscarNomina = new FormBuscarNomina();
            formBuscarNomina.Show();
            this.Close();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            this.eneableOrDisableComponents(1);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnSaveN.Enabled = !btnSaveN.Enabled;
            if (cboPeriodoNomina.SelectedIndex == -1)
                return;

            if (cboPeriodoNomina.SelectedItem == null)
                return;

            PeriodoDeNomina item = (PeriodoDeNomina)cboPeriodoNomina.SelectedItem;
            var result = nominaService.GetContratoList(item.Periodo_id);
            if (result.pagos.Count > 0)
            {
                dtoPaymentList.DataSource = result.pagos;

            }
            textNeto.Text = result.AllPaymentDocument.ToString();
            textEmploye.Text = result.CountEMployes.ToString();
            textAllNomina.Text = result.IngresoNomina.ToString();
            textRetencion.Text = result.RegienPensionario.ToString();
        }

        private void btnSaveN_Click(object sender, EventArgs e)
        {
            if (ValidaIngresoData() == false)
            {
                return;
            }
            nominaModel.Fecha = issueData.Value;
            nominaModel.Descripcion = textDescription.Text;
            nominaModel.PeriodoDeNomina.Fechainicio = FromDate.Value;
            nominaModel.PeriodoDeNomina.Fechafin = ToDate.Value;
            var result = nominaService.Save(nominaModel);
            if (result > 0)
            {
                MessageBox.Show("Nomina creada exitosamente");
                ClearControls();
            }
            else
            {
                MessageBox.Show("Error  al grabar Nomina");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = "¿Está seguro de cerrar la Nómina?. Si cierra la Nómina no se podrán modificar los pagos generados de la Nómina ni eliminar la Nómina";
            if (MessageBox.Show(message, "Si cerrar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = nominaService.CloseNomina(nominaModel.Nomina_id);
                if (result > 0)
                {
                    MessageBox.Show("Se cerró la Nómina y se podrán enviar las boletas de pago a los empleados");
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Error al cerrar la Nómina");
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (nominaModel.Cerrada)
            {
                MessageBox.Show("Esta Nomina ya fue cerrada. Solo esta permitido  eliminar una nomina cuando no este cerrada");
                return;
            }
            string message = "¿Está seguro de eliminar la Nómina?. Si elimina la Nómina también de eliminaran los pagos generados de la Nómina";
            if (MessageBox.Show(message, "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = nominaService.DeleteNomina(nominaModel.Nomina_id);
                if (result > 0)
                {
                    MessageBox.Show("Se eliminó la Nómina");
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la Nómina");
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

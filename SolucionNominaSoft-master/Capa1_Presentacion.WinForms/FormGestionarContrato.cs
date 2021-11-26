using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;
using Capa4_Persistencia.ADONet_SQLServer;


namespace Capa1_Presentacion.WinForms
{
    public partial class FormGestionarContrato : Form
    {
        GestionarContratoServicio servicio = new GestionarContratoServicio();
        Empleado empleado;
        Contrato contrato;
        Afp afp;
        int bandera=0;
        int indice;
        public FormGestionarContrato()
        {
            InitializeComponent();
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGestionarContrato_Load(object sender, EventArgs e)
        {
            buttonGuardarContrato.Enabled = false;
            dateTimePickerInicioCont.Enabled = false;
            dateTimePickerFinCont.Enabled = false;
            textIdContrato.Enabled = false;
            textPuesto.Enabled = false;
            comboAFP.Enabled = false;
            buttonCrearContrato.Enabled = false;
            buttonEditarContrato.Enabled = false;
            textHorasxSem.Enabled = false;
            textPagoxHora.Enabled = false;
            
            

               
            
        }

        private void buttonCrearContrato_Click(object sender, EventArgs e)
        {
            buttonCrearContrato.Enabled = false;
            buttonGuardarContrato.Enabled = true;
            dateTimePickerInicioCont.Enabled = true;
            dateTimePickerFinCont.Enabled = true;
            textIdContrato.Enabled = false;
            textPuesto.Enabled = true;
            comboAFP.Enabled = true;
            textPuesto.Text = "";
            comboAFP.Text = "";
            textasig.Text = "";
            textHorasxSem.Text = "";
            textPagoxHora.Text = "";
            estadoEmpleado.Text = "Estado del Empleado";
            textHorasxSem.Enabled = true;
            textPagoxHora.Enabled = true;
            textasig.Enabled = true;
            bandera = 1;
            

        }

        private void buttonEditarContrato_Click(object sender, EventArgs e)
        {
            buttonCrearContrato.Enabled = false;
            buttonGuardarContrato.Enabled = true;
            dateTimePickerInicioCont.Enabled = true;
            dateTimePickerFinCont.Enabled = true;
            textIdContrato.Enabled = false;
            textPuesto.Enabled = true;
            comboAFP.Enabled = true;
            textasig.Enabled = true;
            textHorasxSem.Enabled = true;
            textPagoxHora.Enabled = true;



        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonCrearContrato.Enabled = false;
            buttonGuardarContrato.Enabled = false;
            dateTimePickerInicioCont.Enabled = false;
            dateTimePickerFinCont.Enabled = false;
            textasig.Enabled = false;
            textasig.Text = "";
            textIdContrato.Text = "";
            textIdContrato.Enabled = false;
            textPuesto.Text = "";
            textPuesto.Enabled = false;
            comboAFP.Enabled = false;
            comboAFP.Text = "";
            textHorasxSem.Text = "";
            textHorasxSem.Enabled = false;
            textPagoxHora.Text = "";
            textPagoxHora.Enabled = false;

            //////////////////////////////////////////////////////////////////////////////////////////////////

            textIdEmpleado.Text = "";
            textNombres.Text = "";
            textApellidos.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
            textDireccion.Text = "";
            textFechaNacim.Text = "";
            textBoxDNI.Text = "";
            buttonCancelar.Enabled = false;
            buttonEditarContrato.Enabled = false;
            textBoxDNI.Focus();

        }

        private void buttonGuardarContrato_Click(object sender, EventArgs e)
        {
            buttonCrearContrato.Enabled = false;
           // buttonGuardarContrato.Enabled = false;
            buttonGuardarContrato.Enabled = true;
            int idEmpleado = Convert.ToInt32(textIdEmpleado.Text);
            Contrato antiguoContrato = servicio.BuscarContrato(idEmpleado);
            Contrato nuevoCotrato = new Contrato();
            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.Empleado_id = idEmpleado;

            nuevoCotrato.Fechainicio = dateTimePickerInicioCont.Value;
            nuevoCotrato.Fechafin = dateTimePickerFinCont.Value;
            nuevoCotrato.Puesto = textPuesto.Text;
            nuevoCotrato.AFP1 = indice+1;

            if (textasig.Text == "SI" || textasig.Text == "si"|| textasig.Text=="Si" || textasig.Text=="sI")
            {
                nuevoCotrato.Tieneasignacionfamiliar = true;
                nuevoCotrato.Horasporsemana = Convert.ToInt32(textHorasxSem.Text);
                nuevoCotrato.Pagoporhora = Convert.ToDecimal(textPagoxHora.Text);
                nuevoCotrato.Cancelado = false;

                nuevoCotrato.Empleado = nuevoEmpleado;
                nuevoCotrato.Contrato_id = Convert.ToInt32(textIdContrato.Text);



                try
                {
                    //servicio.crearContratoNuevo(nuevoCotrato, dateTimePicker1.Value, idEmpleado);
                    servicio.guardarContrato(nuevoCotrato, bandera,dateTimePicker1.Value);

                    if (bandera == 1)
                    {

                        MessageBox.Show(this, "Se creo el Contrato.", "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Se edito el Contrato.", "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

                catch (Exception err)
                {

                    MessageBox.Show(this, err.Message, "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textasig.Text == "NO" || textasig.Text == "no" || textasig.Text=="No" || textasig.Text=="nO")
                {
                    nuevoCotrato.Tieneasignacionfamiliar = false;
                    nuevoCotrato.Horasporsemana = Convert.ToInt32(textHorasxSem.Text);
                    nuevoCotrato.Pagoporhora = Convert.ToDecimal(textPagoxHora.Text);
                    nuevoCotrato.Cancelado = false;

                    nuevoCotrato.Empleado = nuevoEmpleado;
                    nuevoCotrato.Contrato_id = Convert.ToInt32(textIdContrato.Text);



                    try
                    {
                        //servicio.crearContratoNuevo(nuevoCotrato, dateTimePicker1.Value, idEmpleado);
                        servicio.guardarContrato(nuevoCotrato, bandera,dateTimePicker1.Value);

                        if (bandera == 1)
                        {

                            MessageBox.Show(this, "Se creo el Contrato.", "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Se edito el Contrato.", "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                    catch (Exception err)
                    {

                        MessageBox.Show(this, err.Message, "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
                else
                {
                MessageBox.Show(this, "Ingrese si/no", "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);     
               
                }
            }
            
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) //Rangos del codigo ASCII que no permitira presionar, solo del 48 al 57 que son solo numeros. 
            {
                MessageBox.Show("Ingrese solo numeros", "Sistema Nominasoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) //Rangos del codigo ASCII que no permitira presionar, solo del 32 al 64, del 91 al 96, del 123 al 255 que son caracteres diferentes a letras.
            {
                MessageBox.Show("Ingrese solo letras", "Sistema Nominasoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void comboAsignacFam_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int indice = comboAsignacFam.SelectedIndex;
        }

        private void comboAFP_SelectedIndexChanged(object sender, EventArgs e)
        {
           indice = comboAFP.SelectedIndex;
        }

        private void dateTimePickerInicioCont_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePickerInicioCont.Value;
        }

        private void dateTimePickerFinCont_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePickerFinCont.Value;
        }

        private void textHorasxSem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) //Rangos del codigo ASCII que no permitira presionar, solo del 48 al 57 que son solo numeros. 
            {
                MessageBox.Show("Ingrese solo numeros", "Sistema Nominasoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void buttonBuscarDNI_Click(object sender, EventArgs e)
        {
            string dni = textBoxDNI.Text.Trim();
            
            try
            {
               
                empleado = servicio.BuscarEmpleado(dni);
                 
                
                
                    textIdEmpleado.Text = empleado.Empleado_id.ToString();
                    textNombres.Text = empleado.Nombres;
                    textApellidos.Text = empleado.Apellidos;
                    textDireccion.Text = empleado.Direccion;
                    textCorreo.Text = empleado.Correo;
                    textTelefono.Text = empleado.Telefono;
                    textFechaNacim.Text = empleado.Fechanacimiento.Date.ToString();
                int idEmpleado = Convert.ToInt32(textIdEmpleado.Text);
                
                 contrato = servicio.BuscarContrato(idEmpleado);

                
                    textIdContrato.Text = contrato.Contrato_id.ToString();
                    dateTimePickerInicioCont.Text = contrato.Fechainicio.ToString();
                    dateTimePickerFinCont.Text = contrato.Fechafin.ToString();
                    textPuesto.Text = contrato.Puesto;
                    afp = servicio.BuscarAFP(contrato.AFP1);
                    comboAFP.Text = afp.Nombre;
                    textasig.Text = contrato.Tieneasignacionfamiliar.ToString();
                    textHorasxSem.Text = contrato.Horasporsemana.ToString();
                    textPagoxHora.Text = contrato.Pagoporhora.ToString();
                if (contrato.Tieneasignacionfamiliar == true)
                {
                    textasig.Text = "SI";
                }
                else
                    textasig.Text = "NO";

                if (contrato.Cancelado == false)
                {
                    estadoEmpleado.Text = "EL CONTRATO NO ESTA CANCELADO";
                    buttonEditarContrato.Enabled = true;
                    buttonCrearContrato.Enabled = false;
                }
                else
                {
                    estadoEmpleado.Text = "EL CONTRATO ESTA CANCELADO";
                    buttonCrearContrato.Enabled = true;
                    buttonEditarContrato.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

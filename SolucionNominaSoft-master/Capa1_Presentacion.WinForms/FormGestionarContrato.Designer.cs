
namespace Capa1_Presentacion.WinForms
{
    partial class FormGestionarContrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarDNI = new System.Windows.Forms.Button();
            this.buttonCrearContrato = new System.Windows.Forms.Button();
            this.buttonEditarContrato = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardarContrato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textIdEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textFechaNacim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textIdContrato = new System.Windows.Forms.TextBox();
            this.textPuesto = new System.Windows.Forms.TextBox();
            this.textHorasxSem = new System.Windows.Forms.TextBox();
            this.textPagoxHora = new System.Windows.Forms.TextBox();
            this.comboAFP = new System.Windows.Forms.ComboBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dateTimePickerInicioCont = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinCont = new System.Windows.Forms.DateTimePicker();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.estadoEmpleado = new System.Windows.Forms.Label();
            this.textasig = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI de Empleado:";
            // 
            // buttonBuscarDNI
            // 
            this.buttonBuscarDNI.Location = new System.Drawing.Point(249, 59);
            this.buttonBuscarDNI.Name = "buttonBuscarDNI";
            this.buttonBuscarDNI.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarDNI.TabIndex = 2;
            this.buttonBuscarDNI.Text = "Buscar";
            this.buttonBuscarDNI.UseVisualStyleBackColor = true;
            this.buttonBuscarDNI.Click += new System.EventHandler(this.buttonBuscarDNI_Click);
            // 
            // buttonCrearContrato
            // 
            this.buttonCrearContrato.Location = new System.Drawing.Point(687, 21);
            this.buttonCrearContrato.Name = "buttonCrearContrato";
            this.buttonCrearContrato.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearContrato.TabIndex = 3;
            this.buttonCrearContrato.Text = "Crear";
            this.buttonCrearContrato.UseVisualStyleBackColor = true;
            this.buttonCrearContrato.Click += new System.EventHandler(this.buttonCrearContrato_Click);
            // 
            // buttonEditarContrato
            // 
            this.buttonEditarContrato.Location = new System.Drawing.Point(687, 91);
            this.buttonEditarContrato.Name = "buttonEditarContrato";
            this.buttonEditarContrato.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarContrato.TabIndex = 4;
            this.buttonEditarContrato.Text = "Editar";
            this.buttonEditarContrato.UseVisualStyleBackColor = true;
            this.buttonEditarContrato.Click += new System.EventHandler(this.buttonEditarContrato_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(687, 157);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardarContrato
            // 
            this.buttonGuardarContrato.Location = new System.Drawing.Point(687, 222);
            this.buttonGuardarContrato.Name = "buttonGuardarContrato";
            this.buttonGuardarContrato.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarContrato.TabIndex = 6;
            this.buttonGuardarContrato.Text = "Guardar";
            this.buttonGuardarContrato.UseVisualStyleBackColor = true;
            this.buttonGuardarContrato.Click += new System.EventHandler(this.buttonGuardarContrato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Identificador:";
            // 
            // textIdEmpleado
            // 
            this.textIdEmpleado.Location = new System.Drawing.Point(15, 157);
            this.textIdEmpleado.Name = "textIdEmpleado";
            this.textIdEmpleado.Size = new System.Drawing.Size(175, 20);
            this.textIdEmpleado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fec. nacimiento:";
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(211, 157);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(144, 20);
            this.textNombres.TabIndex = 18;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(369, 157);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(148, 20);
            this.textApellidos.TabIndex = 19;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(15, 222);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(182, 20);
            this.textDireccion.TabIndex = 20;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(211, 222);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(144, 20);
            this.textCorreo.TabIndex = 21;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(369, 222);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(148, 20);
            this.textTelefono.TabIndex = 22;
            // 
            // textFechaNacim
            // 
            this.textFechaNacim.Location = new System.Drawing.Point(103, 271);
            this.textFechaNacim.Name = "textFechaNacim";
            this.textFechaNacim.Size = new System.Drawing.Size(92, 20);
            this.textFechaNacim.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Datos del Empleado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Datos de Contrato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Identif. Contrato:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Fec. Inicio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(461, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fec. Fin:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Puesto:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(173, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "AFP:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(299, 418);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Asig. Familiar:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(462, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Horas/Sem. :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(462, 450);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Pago/Hora:";
            // 
            // textIdContrato
            // 
            this.textIdContrato.Location = new System.Drawing.Point(105, 342);
            this.textIdContrato.Name = "textIdContrato";
            this.textIdContrato.Size = new System.Drawing.Size(92, 20);
            this.textIdContrato.TabIndex = 34;
            // 
            // textPuesto
            // 
            this.textPuesto.Location = new System.Drawing.Point(61, 415);
            this.textPuesto.Name = "textPuesto";
            this.textPuesto.Size = new System.Drawing.Size(98, 20);
            this.textPuesto.TabIndex = 37;
            this.textPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPuesto_KeyPress);
            // 
            // textHorasxSem
            // 
            this.textHorasxSem.Location = new System.Drawing.Point(555, 415);
            this.textHorasxSem.Name = "textHorasxSem";
            this.textHorasxSem.Size = new System.Drawing.Size(69, 20);
            this.textHorasxSem.TabIndex = 40;
            this.textHorasxSem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHorasxSem_KeyPress);
            // 
            // textPagoxHora
            // 
            this.textPagoxHora.Location = new System.Drawing.Point(555, 447);
            this.textPagoxHora.Name = "textPagoxHora";
            this.textPagoxHora.Size = new System.Drawing.Size(69, 20);
            this.textPagoxHora.TabIndex = 41;
            // 
            // comboAFP
            // 
            this.comboAFP.FormattingEnabled = true;
            this.comboAFP.Items.AddRange(new object[] {
            "Integra",
            "Habitad",
            "Prima",
            "Profuturo"});
            this.comboAFP.Location = new System.Drawing.Point(209, 415);
            this.comboAFP.Name = "comboAFP";
            this.comboAFP.Size = new System.Drawing.Size(75, 21);
            this.comboAFP.TabIndex = 49;
            this.comboAFP.SelectedIndexChanged += new System.EventHandler(this.comboAFP_SelectedIndexChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(687, 469);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 50;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dateTimePickerInicioCont
            // 
            this.dateTimePickerInicioCont.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicioCont.Location = new System.Drawing.Point(311, 341);
            this.dateTimePickerInicioCont.Name = "dateTimePickerInicioCont";
            this.dateTimePickerInicioCont.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerInicioCont.TabIndex = 51;
            this.dateTimePickerInicioCont.ValueChanged += new System.EventHandler(this.dateTimePickerInicioCont_ValueChanged);
            // 
            // dateTimePickerFinCont
            // 
            this.dateTimePickerFinCont.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinCont.Location = new System.Drawing.Point(515, 342);
            this.dateTimePickerFinCont.Name = "dateTimePickerFinCont";
            this.dateTimePickerFinCont.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerFinCont.TabIndex = 52;
            this.dateTimePickerFinCont.ValueChanged += new System.EventHandler(this.dateTimePickerFinCont_ValueChanged);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(128, 62);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 54;
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // estadoEmpleado
            // 
            this.estadoEmpleado.AutoSize = true;
            this.estadoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoEmpleado.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.estadoEmpleado.Location = new System.Drawing.Point(14, 454);
            this.estadoEmpleado.Name = "estadoEmpleado";
            this.estadoEmpleado.Size = new System.Drawing.Size(170, 20);
            this.estadoEmpleado.TabIndex = 55;
            this.estadoEmpleado.Text = "Estado del Contrato";
            // 
            // textasig
            // 
            this.textasig.Enabled = false;
            this.textasig.Location = new System.Drawing.Point(369, 415);
            this.textasig.Name = "textasig";
            this.textasig.Size = new System.Drawing.Size(56, 20);
            this.textasig.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha Actual";
            // 
            // FormGestionarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textasig);
            this.Controls.Add(this.estadoEmpleado);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.dateTimePickerFinCont);
            this.Controls.Add(this.dateTimePickerInicioCont);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.comboAFP);
            this.Controls.Add(this.textPagoxHora);
            this.Controls.Add(this.textHorasxSem);
            this.Controls.Add(this.textPuesto);
            this.Controls.Add(this.textIdContrato);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textFechaNacim);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textIdEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGuardarContrato);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditarContrato);
            this.Controls.Add(this.buttonCrearContrato);
            this.Controls.Add(this.buttonBuscarDNI);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionarContrato";
            this.Text = "FormGestionarContrato";
            this.Load += new System.EventHandler(this.FormGestionarContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarDNI;
        private System.Windows.Forms.Button buttonCrearContrato;
        private System.Windows.Forms.Button buttonEditarContrato;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardarContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIdEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textFechaNacim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textIdContrato;
        private System.Windows.Forms.TextBox textPuesto;
        private System.Windows.Forms.TextBox textHorasxSem;
        private System.Windows.Forms.TextBox textPagoxHora;
        private System.Windows.Forms.ComboBox comboAFP;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicioCont;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinCont;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label estadoEmpleado;
        private System.Windows.Forms.TextBox textasig;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}
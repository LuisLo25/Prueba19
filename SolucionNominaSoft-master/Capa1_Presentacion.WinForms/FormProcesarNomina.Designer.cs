
namespace Capa1_Presentacion.WinForms
{
    partial class FormProcesarNomina
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtoPaymentList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textRetencion = new System.Windows.Forms.TextBox();
            this.textNeto = new System.Windows.Forms.TextBox();
            this.textEmploye = new System.Windows.Forms.TextBox();
            this.textAllNomina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.issueData = new System.Windows.Forms.DateTimePicker();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.cboPeriodoNomina = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchData = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSaveN = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtoPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Emision";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periodo Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Periodo Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingresar Descripcion:";
            // 
            // dtoPaymentList
            // 
            this.dtoPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtoPaymentList.Location = new System.Drawing.Point(33, 245);
            this.dtoPaymentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtoPaymentList.Name = "dtoPaymentList";
            this.dtoPaymentList.RowHeadersWidth = 51;
            this.dtoPaymentList.Size = new System.Drawing.Size(932, 302);
            this.dtoPaymentList.TabIndex = 12;
            this.dtoPaymentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 587);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nro. de empleados pagados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 638);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total de Ingresos de nomina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 574);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total de Retenciones de nomina:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 629);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Neto a pagar de nomina:";
            // 
            // textRetencion
            // 
            this.textRetencion.Location = new System.Drawing.Point(799, 569);
            this.textRetencion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRetencion.Name = "textRetencion";
            this.textRetencion.Size = new System.Drawing.Size(132, 22);
            this.textRetencion.TabIndex = 23;
            this.textRetencion.TextChanged += new System.EventHandler(this.textRetencion_TextChanged);
            // 
            // textNeto
            // 
            this.textNeto.Location = new System.Drawing.Point(799, 624);
            this.textNeto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNeto.Name = "textNeto";
            this.textNeto.Size = new System.Drawing.Size(132, 22);
            this.textNeto.TabIndex = 24;
            // 
            // textEmploye
            // 
            this.textEmploye.Location = new System.Drawing.Point(240, 582);
            this.textEmploye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmploye.Name = "textEmploye";
            this.textEmploye.Size = new System.Drawing.Size(132, 22);
            this.textEmploye.TabIndex = 25;
            // 
            // textAllNomina
            // 
            this.textAllNomina.Location = new System.Drawing.Point(240, 633);
            this.textAllNomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAllNomina.Name = "textAllNomina";
            this.textAllNomina.Size = new System.Drawing.Size(132, 22);
            this.textAllNomina.TabIndex = 26;
            this.textAllNomina.TextChanged += new System.EventHandler(this.textAllNomina_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Lista de Pagos:";
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.FromDate.Location = new System.Drawing.Point(203, 101);
            this.FromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 22);
            this.FromDate.TabIndex = 29;
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // ToDate
            // 
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(597, 102);
            this.ToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 22);
            this.ToDate.TabIndex = 30;
            // 
            // issueData
            // 
            this.issueData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issueData.Location = new System.Drawing.Point(895, 21);
            this.issueData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issueData.Name = "issueData";
            this.issueData.Size = new System.Drawing.Size(200, 22);
            this.issueData.TabIndex = 31;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(568, 156);
            this.textDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(229, 22);
            this.textDescription.TabIndex = 11;
            // 
            // cboPeriodoNomina
            // 
            this.cboPeriodoNomina.DisplayMember = "descripcion";
            this.cboPeriodoNomina.FormattingEnabled = true;
            this.cboPeriodoNomina.Location = new System.Drawing.Point(195, 162);
            this.cboPeriodoNomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPeriodoNomina.Name = "cboPeriodoNomina";
            this.cboPeriodoNomina.Size = new System.Drawing.Size(175, 24);
            this.cboPeriodoNomina.TabIndex = 32;
            this.cboPeriodoNomina.SelectedIndexChanged += new System.EventHandler(this.cboPeriodoNomina_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Sellecciona Periodo:";
            
            // 
            // btnSearchData
            // 
            this.btnSearchData.Location = new System.Drawing.Point(832, 88);
            this.btnSearchData.Name = "btnSearchData";
            this.btnSearchData.Size = new System.Drawing.Size(133, 33);
            this.btnSearchData.TabIndex = 35;
            this.btnSearchData.Text = "BUSCAR";
            this.btnSearchData.UseVisualStyleBackColor = true;
            this.btnSearchData.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(987, 88);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 33);
            this.btnCreate.TabIndex = 36;
            this.btnCreate.Text = "Crear Nomina";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(832, 150);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(133, 33);
            this.btnGenerate.TabIndex = 37;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSaveN
            // 
            this.btnSaveN.Location = new System.Drawing.Point(987, 150);
            this.btnSaveN.Name = "btnSaveN";
            this.btnSaveN.Size = new System.Drawing.Size(133, 33);
            this.btnSaveN.TabIndex = 38;
            this.btnSaveN.Text = "Guardar";
            this.btnSaveN.UseVisualStyleBackColor = true;
            this.btnSaveN.Click += new System.EventHandler(this.btnSaveN_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1002, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 34);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1002, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 33);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1002, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 29);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // FormProcesarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 708);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveN);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearchData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboPeriodoNomina);
            this.Controls.Add(this.issueData);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textAllNomina);
            this.Controls.Add(this.textEmploye);
            this.Controls.Add(this.textNeto);
            this.Controls.Add(this.textRetencion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtoPaymentList);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProcesarNomina";
            this.Text = "FormProcesarNomina";
            this.Load += new System.EventHandler(this.FormProcesarNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtoPaymentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtoPaymentList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textRetencion;
        private System.Windows.Forms.TextBox textNeto;
        private System.Windows.Forms.TextBox textEmploye;
        private System.Windows.Forms.TextBox textAllNomina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker issueData;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.ComboBox cboPeriodoNomina;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearchData;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSaveN;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}
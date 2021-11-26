
namespace Capa1_Presentacion.WinForms
{
    partial class FormBuscarNomina
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.dtNominas = new System.Windows.Forms.DataGridView();
            this.buttonBuscarNomina = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtNominas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuadro de Busqueda:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(165, 109);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(244, 22);
            this.textSearch.TabIndex = 3;
            // 
            // dtNominas
            // 
            this.dtNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNominas.Location = new System.Drawing.Point(12, 158);
            this.dtNominas.Name = "dtNominas";
            this.dtNominas.RowHeadersWidth = 51;
            this.dtNominas.RowTemplate.Height = 24;
            this.dtNominas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtNominas.Size = new System.Drawing.Size(743, 412);
            this.dtNominas.TabIndex = 1;
            this.dtNominas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonBuscarNomina
            // 
            this.buttonBuscarNomina.Location = new System.Drawing.Point(465, 99);
            this.buttonBuscarNomina.Name = "buttonBuscarNomina";
            this.buttonBuscarNomina.Size = new System.Drawing.Size(140, 36);
            this.buttonBuscarNomina.TabIndex = 30;
            this.buttonBuscarNomina.Text = "Buscar Nomina";
            this.buttonBuscarNomina.UseVisualStyleBackColor = true;
            this.buttonBuscarNomina.Click += new System.EventHandler(this.buttonBuscarNomina_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(631, 99);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 36);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormBuscarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.buttonBuscarNomina);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtNominas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBuscarNomina";
            this.Text = "FormBuscarNomina";
            this.Load += new System.EventHandler(this.FormBuscarNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridView dtNominas;
        private System.Windows.Forms.Button buttonBuscarNomina;
        private System.Windows.Forms.Button btnClose;
    }
}
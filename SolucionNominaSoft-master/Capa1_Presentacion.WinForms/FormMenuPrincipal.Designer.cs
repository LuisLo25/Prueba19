
namespace Capa1_Presentacion.WinForms
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarPagoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarBoletaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesarPagoToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // procesarPagoToolStripMenuItem
            // 
            this.procesarPagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesarPagoToolStripMenuItem1,
            this.procesarBoletaDePagoToolStripMenuItem});
            this.procesarPagoToolStripMenuItem.Name = "procesarPagoToolStripMenuItem";
            this.procesarPagoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.procesarPagoToolStripMenuItem.Text = "Proceso";
            // 
            // procesarPagoToolStripMenuItem1
            // 
            this.procesarPagoToolStripMenuItem1.Name = "procesarPagoToolStripMenuItem1";
            this.procesarPagoToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.procesarPagoToolStripMenuItem1.Text = "Procesar nomina";
            this.procesarPagoToolStripMenuItem1.Click += new System.EventHandler(this.procesarPagoToolStripMenuItem1_Click);
            // 
            // procesarBoletaDePagoToolStripMenuItem
            // 
            this.procesarBoletaDePagoToolStripMenuItem.Name = "procesarBoletaDePagoToolStripMenuItem";
            this.procesarBoletaDePagoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.procesarBoletaDePagoToolStripMenuItem.Text = "Procesar boleta de pago";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarContratosToolStripMenuItem,
            this.gestionarNominaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // gestionarContratosToolStripMenuItem
            // 
            this.gestionarContratosToolStripMenuItem.Name = "gestionarContratosToolStripMenuItem";
            this.gestionarContratosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestionarContratosToolStripMenuItem.Text = "Gestionar empleados";
            // 
            // gestionarNominaToolStripMenuItem
            // 
            this.gestionarNominaToolStripMenuItem.Name = "gestionarNominaToolStripMenuItem";
            this.gestionarNominaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestionarNominaToolStripMenuItem.Text = "Gestionar contrato";
            this.gestionarNominaToolStripMenuItem.Click += new System.EventHandler(this.gestionarNominaToolStripMenuItem_Click_1);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
            this.Text = "NOMINASOFT";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procesarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesarPagoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesarBoletaDePagoToolStripMenuItem;
    }
}


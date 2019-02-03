namespace Interfaz
{
    partial class Form1
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
            this.mapa = new Interfaz.Mapa();
            this.informacionTabla = new Interfaz.InformacionTabla();
            this.groupBox_Informacion = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Informacion = new System.Windows.Forms.TabPage();
            this.tabPage_Graficas = new System.Windows.Forms.TabPage();
            this.informacionGraficas = new Interfaz.InformacionGraficas();
            this.groupBox_Informacion.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_Informacion.SuspendLayout();
            this.tabPage_Graficas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapa
            // 
            this.mapa.Location = new System.Drawing.Point(10, 19);
            this.mapa.Name = "mapa";
            this.mapa.Size = new System.Drawing.Size(347, 408);
            this.mapa.TabIndex = 0;
            this.mapa.Load += new System.EventHandler(this.mapa1_Load);
            // 
            // informacionTabla
            // 
            this.informacionTabla.Location = new System.Drawing.Point(363, 19);
            this.informacionTabla.Name = "informacionTabla";
            this.informacionTabla.Size = new System.Drawing.Size(508, 408);
            this.informacionTabla.TabIndex = 1;
            // 
            // groupBox_Informacion
            // 
            this.groupBox_Informacion.Controls.Add(this.mapa);
            this.groupBox_Informacion.Controls.Add(this.informacionTabla);
            this.groupBox_Informacion.Location = new System.Drawing.Point(3, 6);
            this.groupBox_Informacion.Name = "groupBox_Informacion";
            this.groupBox_Informacion.Size = new System.Drawing.Size(877, 445);
            this.groupBox_Informacion.TabIndex = 2;
            this.groupBox_Informacion.TabStop = false;
            this.groupBox_Informacion.Text = "Cali, Valle del Cauca";
            this.groupBox_Informacion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Informacion);
            this.tabControl.Controls.Add(this.tabPage_Graficas);
            this.tabControl.Location = new System.Drawing.Point(2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(891, 483);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage_Informacion
            // 
            this.tabPage_Informacion.Controls.Add(this.groupBox_Informacion);
            this.tabPage_Informacion.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Informacion.Name = "tabPage_Informacion";
            this.tabPage_Informacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Informacion.Size = new System.Drawing.Size(883, 457);
            this.tabPage_Informacion.TabIndex = 0;
            this.tabPage_Informacion.Text = "Informacion";
            this.tabPage_Informacion.UseVisualStyleBackColor = true;
            // 
            // tabPage_Graficas
            // 
            this.tabPage_Graficas.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Graficas.Controls.Add(this.informacionGraficas);
            this.tabPage_Graficas.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Graficas.Name = "tabPage_Graficas";
            this.tabPage_Graficas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Graficas.Size = new System.Drawing.Size(883, 457);
            this.tabPage_Graficas.TabIndex = 1;
            this.tabPage_Graficas.Text = "Graficas";
            // 
            // informacionGraficas
            // 
            this.informacionGraficas.Location = new System.Drawing.Point(3, 3);
            this.informacionGraficas.Name = "informacionGraficas";
            this.informacionGraficas.Size = new System.Drawing.Size(874, 445);
            this.informacionGraficas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 482);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Informacion.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Informacion.ResumeLayout(false);
            this.tabPage_Graficas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Mapa mapa;
        private InformacionTabla informacionTabla;
        private System.Windows.Forms.GroupBox groupBox_Informacion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Informacion;
        private System.Windows.Forms.TabPage tabPage_Graficas;
        private InformacionGraficas informacionGraficas;
    }
}


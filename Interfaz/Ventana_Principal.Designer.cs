using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;

namespace Interfaz
{
    partial class Ventana_Principal
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Informacion = new System.Windows.Forms.TabPage();
            this.informacionTabla = new Interfaz.InformacionTabla();
            this.tabPage_Graficas = new System.Windows.Forms.TabPage();
            this.informacionGraficas = new Interfaz.InformacionGraficas();
            this.Mapa_rios = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl.SuspendLayout();
            this.tabPage_Informacion.SuspendLayout();
            this.tabPage_Graficas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Informacion);
            this.tabControl.Controls.Add(this.tabPage_Graficas);
            this.tabControl.Location = new System.Drawing.Point(450, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(851, 483);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage_Informacion
            // 
            this.tabPage_Informacion.Controls.Add(this.informacionTabla);
            this.tabPage_Informacion.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Informacion.Name = "tabPage_Informacion";
            this.tabPage_Informacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Informacion.Size = new System.Drawing.Size(843, 457);
            this.tabPage_Informacion.TabIndex = 0;
            this.tabPage_Informacion.Text = "Informacion";
            this.tabPage_Informacion.UseVisualStyleBackColor = true;
            // 
            // informacionTabla
            // 
            this.informacionTabla.Location = new System.Drawing.Point(3, 0);
            this.informacionTabla.Name = "informacionTabla";
            this.informacionTabla.Size = new System.Drawing.Size(834, 446);
            this.informacionTabla.TabIndex = 1;
            this.informacionTabla.VP = null;
            
            // 
            // tabPage_Graficas
            // 
            this.tabPage_Graficas.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Graficas.Controls.Add(this.informacionGraficas);
            this.tabPage_Graficas.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Graficas.Name = "tabPage_Graficas";
            this.tabPage_Graficas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Graficas.Size = new System.Drawing.Size(843, 457);
            this.tabPage_Graficas.TabIndex = 1;
            this.tabPage_Graficas.Text = "Graficas";
            // 
            // informacionGraficas
            // 
            this.informacionGraficas.Location = new System.Drawing.Point(3, 3);
            this.informacionGraficas.Name = "informacionGraficas";
            this.informacionGraficas.Size = new System.Drawing.Size(833, 445);
            this.informacionGraficas.TabIndex = 0;
            // 
            // mapa_rios
            // 
            this.Mapa_rios.Bearing = 0F;
            this.Mapa_rios.CanDragMap = true;
            this.Mapa_rios.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapa_rios.GrayScaleMode = false;
            this.Mapa_rios.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapa_rios.LevelsKeepInMemmory = 5;
            this.Mapa_rios.Location = new System.Drawing.Point(12, 12);
            this.Mapa_rios.MarkersEnabled = true;
            this.Mapa_rios.MaxZoom = 18;
            this.Mapa_rios.MinZoom = 0;
            this.Mapa_rios.MouseWheelZoomEnabled = true;
            this.Mapa_rios.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapa_rios.Name = "mapa_rios";
            this.Mapa_rios.NegativeMode = false;
            this.Mapa_rios.PolygonsEnabled = true;
            this.Mapa_rios.RetryLoadTile = 0;
            this.Mapa_rios.RoutesEnabled = true;
            this.Mapa_rios.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapa_rios.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapa_rios.ShowTileGridLines = false;
            this.Mapa_rios.Size = new System.Drawing.Size(432, 458);
            this.Mapa_rios.TabIndex = 4;
            this.Mapa_rios.Zoom = 12D;

           
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 482);
            this.Controls.Add(this.Mapa_rios);
            this.Controls.Add(this.tabControl);
            this.Name = "Ventana_Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Informacion.ResumeLayout(false);
            this.tabPage_Graficas.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private InformacionTabla informacionTabla;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Informacion;
        private System.Windows.Forms.TabPage tabPage_Graficas;
        private InformacionGraficas informacionGraficas;
        private GMap.NET.WindowsForms.GMapControl mapa_rios;

        public GMapControl Mapa_rios { get => mapa_rios; set => mapa_rios = value; }
    }
}


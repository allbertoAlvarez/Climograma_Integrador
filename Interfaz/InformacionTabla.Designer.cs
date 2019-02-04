namespace Interfaz
{
    partial class InformacionTabla
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBox_Rios = new System.Windows.Forms.ListBox();
            this.dataGridView_Tabla = new System.Windows.Forms.DataGridView();
            this.label_Rio = new System.Windows.Forms.Label();
            this.button_Informacion = new System.Windows.Forms.Button();
            this.button_Limpiar_Tabla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Rios
            // 
            this.listBox_Rios.FormattingEnabled = true;
            this.listBox_Rios.Items.AddRange(new object[] {
            "Aguacatal",
            "Cali",
            "Cañaveralejo",
            "Lili",
            "Melendez",
            "Pance"});
            this.listBox_Rios.Location = new System.Drawing.Point(13, 39);
            this.listBox_Rios.Name = "listBox_Rios";
            this.listBox_Rios.Size = new System.Drawing.Size(202, 95);
            this.listBox_Rios.TabIndex = 0;
            // 
            // dataGridView_Tabla
            // 
            this.dataGridView_Tabla.AllowUserToAddRows = false;
            this.dataGridView_Tabla.AllowUserToDeleteRows = false;
            this.dataGridView_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Tabla.Location = new System.Drawing.Point(13, 153);
            this.dataGridView_Tabla.Name = "dataGridView_Tabla";
            this.dataGridView_Tabla.ReadOnly = true;
            this.dataGridView_Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tabla.Size = new System.Drawing.Size(804, 252);
            this.dataGridView_Tabla.TabIndex = 1;
            // 
            // label_Rio
            // 
            this.label_Rio.AutoSize = true;
            this.label_Rio.Location = new System.Drawing.Point(10, 13);
            this.label_Rio.Name = "label_Rio";
            this.label_Rio.Size = new System.Drawing.Size(26, 13);
            this.label_Rio.TabIndex = 2;
            this.label_Rio.Text = "Rio:";
            this.label_Rio.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Informacion
            // 
            this.button_Informacion.Location = new System.Drawing.Point(221, 56);
            this.button_Informacion.Name = "button_Informacion";
            this.button_Informacion.Size = new System.Drawing.Size(101, 36);
            this.button_Informacion.TabIndex = 3;
            this.button_Informacion.Text = "Informacion";
            this.button_Informacion.UseVisualStyleBackColor = true;
            this.button_Informacion.Click += new System.EventHandler(this.button_Informacion_Click);
            // 
            // button_Limpiar_Tabla
            // 
            this.button_Limpiar_Tabla.Location = new System.Drawing.Point(221, 98);
            this.button_Limpiar_Tabla.Name = "button_Limpiar_Tabla";
            this.button_Limpiar_Tabla.Size = new System.Drawing.Size(101, 36);
            this.button_Limpiar_Tabla.TabIndex = 4;
            this.button_Limpiar_Tabla.Text = "Limpiar tabla";
            this.button_Limpiar_Tabla.UseVisualStyleBackColor = true;
            this.button_Limpiar_Tabla.Click += new System.EventHandler(this.button_Limpiar_Tabla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Visualizar muestra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InformacionTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Limpiar_Tabla);
            this.Controls.Add(this.button_Informacion);
            this.Controls.Add(this.label_Rio);
            this.Controls.Add(this.dataGridView_Tabla);
            this.Controls.Add(this.listBox_Rios);
            this.Name = "InformacionTabla";
            this.Size = new System.Drawing.Size(834, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Rios;
        private System.Windows.Forms.DataGridView dataGridView_Tabla;
        private System.Windows.Forms.Label label_Rio;
        private System.Windows.Forms.Button button_Informacion;
        private System.Windows.Forms.Button button_Limpiar_Tabla;
        private System.Windows.Forms.Button button1;
    }
}

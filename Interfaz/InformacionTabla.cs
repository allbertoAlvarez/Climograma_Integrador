using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Collections;

namespace Interfaz
{
    public partial class InformacionTabla : UserControl
    {

        //private Estudio estudio = new Estudio();
        private Ventana_Principal vP;

        public Ventana_Principal VP { get => vP; set => vP = value; }

        public InformacionTabla()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Informacion_Click(object sender, EventArgs e)
        {
            if (listBox_Rios.SelectedIndex > -1)
            {
                dataGridView_Tabla.DataSource = VP.Estudio.Hash_Muestras[listBox_Rios.SelectedIndex + 1];

            }
            else
            {
                MessageBox.Show("Debes seleccionar un rio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Limpiar_Tabla_Click(object sender, EventArgs e)
        {
            dataGridView_Tabla.DataSource = "";
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = listBox_Rios.SelectedIndex + 1;
            ArrayList muestras = (ArrayList)VP.Estudio.Hash_Muestras[indice];


            if (dataGridView_Tabla.CurrentRow.Index > -1) {
                 int seleccion = dataGridView_Tabla.CurrentRow.Index;
            
                VP.marcadores(((Muestra)muestras[seleccion]).Latitud, ((Muestra)muestras[seleccion]).Longitud);
            }

        }
    }
}

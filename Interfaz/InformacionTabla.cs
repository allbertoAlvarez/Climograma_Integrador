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

        private void dataGridView_Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VP.marcadores(Double.Parse(dataGridView_Tabla.CurrentRow.Cells[11].Value.ToString()), Double.Parse(dataGridView_Tabla.CurrentRow.Cells[12].Value.ToString()));
            MessageBox.Show(dataGridView_Tabla.CurrentRow.Cells[11].Value.ToString()+" "+ dataGridView_Tabla.CurrentRow.Cells[12].Value.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

       
    }
}

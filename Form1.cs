using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea_en_clase_p1_c16.Datos.Modelos;
using tarea_en_clase_p1_c16.Datos;

namespace tarea_en_clase_p1_c16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            coneccion con = new coneccion();
            con.pruebaConneccion();
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            consola_parametros consola = new consola_parametros(textBoxnombre.Text,comboBoxCompania.Text,numericUpDownanio.Value, numericUpDowngeneracion.Value);
        }
    }
}

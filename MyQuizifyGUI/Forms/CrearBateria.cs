using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CrearBateria : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();

        public CrearBateria()
        {
            Dictionary<string, PreguntaMO> preguntas = services.obtenerPreguntas();
            InitializeComponent();
        }

        private void CrearPregunta_Load(object sender, EventArgs e)
        {
            
            
        }
        void cargarDatos(Dictionary<string, PreguntaMO> data)
        {

            dataGridPreguntas.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "MultiOpcion")
            {
                Dictionary<string, PreguntaMO> preguntas = services.obtenerPreguntas();
                cargarDatos(preguntas);
            }
        }
    }
}

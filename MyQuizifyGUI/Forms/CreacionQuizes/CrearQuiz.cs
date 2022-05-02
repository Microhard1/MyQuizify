using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using MyQuizifyLib.BussinessLogic.Entidades;
using Newtonsoft.Json;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyGUI
{
    public partial class CrearQuiz : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        ConexionBD cf;
        

        public CrearQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void CrearQuiz_Load(object sender, EventArgs e)
        {
            Dictionary<string, PreguntaMO> preguntas = services.obtenerPreguntas();
            cargarDatos(preguntas);

        }

        void cargarDatos(Dictionary<string, PreguntaMO> data) {

            dataGridPreguntas.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data) {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {dataGridPreguntas.Columns.Clear();
                dataGridPreguntas.Rows.Clear();
            Dictionary<string, Bateria> baterias = services.obtenerBaterias();
            Dictionary<string, PreguntaMO> preguntas = services.obtenerPreguntas();
            string filtro = comboBox1.Text;
            if (filtro == "Baterias")
            {
                dataGridPreguntas.Columns.Clear();
                DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
                col1.HeaderText = "Selecciona";
                dataGridPreguntas.Columns.Add(col1);
                dataGridPreguntas.Columns.Add("nombre", "id");
                dataGridPreguntas.Columns.Add("Numero de preguntas", "nº Preguntas");

                foreach (var bateria in baterias) 
                {
                    dataGridPreguntas.Rows.Add(false, bateria.Key, bateria.Value.preguntasBateria.Count);
                }
            }
            else cargarDatos(preguntas);
        }
    }
}

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
        ConexionBD cf = ConexionBD.getInstancia();


        public CrearQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filtro = comboBox1.Text;
            switch (filtro)
            {
                case "Baterias MultiOpcion":
                    int duracion = Int32.Parse(textBoxHoras.Text) * 60 + Int32.Parse(textBoxMinutos.Text);
                    BateriaMultiOpcion bmo = getBateriaMO();
                    Quiz q = new QuizMO(textBoxNombreQuiz.Text,
                        services.getInstructorById(cf.usuarioConectado.username),
                        duracion, Int32.Parse(textBoxPeso.Text), textBoxDificultad.Text,
                        dateTimePicker1.Value, dateTimePicker2.Value, "En preparacion",
                        services.getCursoById(comboBoxCurso.Text));
                    foreach (var pregunta in bmo.preguntasBateria)
                    {
                        q.añadirPregunta(pregunta.id, pregunta.enunciado,
                            pregunta.imagen, pregunta.puntuacion, pregunta.explicacion);
                    }
                    MessageBox.Show("Quiz creado con exito");
                    break;
            }
        }



        private void CrearQuiz_Load(object sender, EventArgs e)
        {


        }

        void cargarDatosMO(Dictionary<string, PreguntaMO> data)
        {

            dataGridPreguntas.Columns.Clear();
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

        void cargarDatosA(Dictionary<string, PreguntaA> data)
        {

            dataGridPreguntas.Columns.Clear();
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

        void cargarDatosVF(Dictionary<string, PreguntaVF> data)
        {

            dataGridPreguntas.Columns.Clear();
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
            dataGridPreguntas.Columns.Clear();
            dataGridPreguntas.Rows.Clear();

            Dictionary<string, PreguntaMO> preguntasMO = services.obtenerPreguntasMO();
            Dictionary<string, PreguntaVF> preguntasVF = services.obtenerPreguntasVF();
            Dictionary<string, PreguntaA> preguntasA = services.obtenerPreguntasA();
            string filtro = comboBox1.Text;
            if (filtro == "Baterias MultiOpcion")
            {
                Dictionary<string, BateriaMultiOpcion> bateriasMO = services.obtenerBateriasMO();
                dataGridPreguntas.Columns.Clear();
                dataGridPreguntas.Rows.Clear();
                DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
                col1.HeaderText = "Selecciona";
                dataGridPreguntas.Columns.Add(col1);
                dataGridPreguntas.Columns.Add("nombre", "id");
                dataGridPreguntas.Columns.Add("Numero de preguntas", "numero de preguntas");

                foreach (var bateria in bateriasMO)
                {
                    dataGridPreguntas.Rows.Add(false, bateria.Key, bateria.Value.preguntasBateria.Count);
                }
            }
            if (filtro == "Baterias Abiertas")
            {
                Dictionary<string, BateriaAbierta> bateriasA = services.obtenerBateriasA();
                dataGridPreguntas.Columns.Clear();
                dataGridPreguntas.Rows.Clear();
                DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
                col1.HeaderText = "Selecciona";
                dataGridPreguntas.Columns.Add(col1);
                dataGridPreguntas.Columns.Add("nombre", "id");
                dataGridPreguntas.Columns.Add("Numero de preguntas", "numero de preguntas");

                foreach (var bateria in bateriasA)
                {
                    dataGridPreguntas.Rows.Add(false, bateria.Key, bateria.Value.preguntasBateria.Count);
                }
            }
            if (filtro == "Baterias Verdadero/Falso")
            {
                Dictionary<string, BateriaVerdaderoFalso> bateriasVF = services.obtenerBateriasVF();
                dataGridPreguntas.Columns.Clear();
                dataGridPreguntas.Rows.Clear();
                DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
                col1.HeaderText = "Selecciona";
                dataGridPreguntas.Columns.Add(col1);
                dataGridPreguntas.Columns.Add("nombre", "id");
                dataGridPreguntas.Columns.Add("Numero de preguntas", "numero de preguntas");

                foreach (var bateria in bateriasVF)
                {
                    dataGridPreguntas.Rows.Add(false, bateria.Key, bateria.Value.preguntasBateria.Count);
                }
            }
            if (filtro == "Preguntas MultiOpcion") { cargarDatosMO(preguntasMO); }
            if (filtro == "Preguntas Verdadero/Falso") { cargarDatosVF(preguntasVF); }
            if (filtro == "Preguntas Abiertas") { cargarDatosA(preguntasA); }
        }

        public BateriaMultiOpcion getBateriaMO()
        {
            BateriaMultiOpcion b = null;
            bool isChecked = false;
            for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
            {
                isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                if (isChecked)
                {
                    b = services.getBateriaMOById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                }
            }
            return b;
        }

        private void dataGridPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

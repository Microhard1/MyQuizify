using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.Persistencia;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using MyQuizifyLib.BussinessLogic.Entidades;
using Newtonsoft.Json;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyGUI.Forms;

namespace MyQuizifyGUI
{
    public partial class QuizesActivos : Form
    {
        private CreacionDeQuizes q;
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public QuizesActivos()
        {
            InitializeComponent();
            q = new CreacionDeQuizes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.ShowDialog();
        }

        private void InicioInstructor_Load(object sender, EventArgs e)
        {
            
            dataGridQuizes.Rows.Clear();
            

            dataGridQuizes.Columns.Add("nombre", "Nombre");
            dataGridQuizes.Columns.Add("tipo", "Tipo");
            dataGridQuizes.Columns.Add("dificultad", "Dificultad");
            dataGridQuizes.Columns.Add("duracion", "Duracion");
            dataGridQuizes.Columns.Add("fechaDeInicio", "Inicio");
            dataGridQuizes.Columns.Add("fechaFin", "Fin");
            dataGridQuizes.Columns.Add("estado", "Estado");

            mostrarQuizes();

        }

        private void botonPreparado_Click(object sender, EventArgs e)
        {
            string estado = "En preparacion";
            cambiarEstado(estado);
            if(comboBoxEstados.Text != estado && comboBoxEstados.Text != "") eliminarDatosGrid();
            deseleccionarChecks();

            
        }

        private void botonCompleto_Click(object sender, EventArgs e)
        {
            string estado = "Completo";
            cambiarEstado(estado);
            if (comboBoxEstados.Text != estado && comboBoxEstados.Text != "") eliminarDatosGrid();
            deseleccionarChecks();
        }
        
        public string getTipoQuiz(string quiz)
        {
            string tipo = "QuizesMO";
            if (quiz == "Pregunta Abierta") tipo = "QuizesPA";
            else if (quiz == "Verdadero/Falso") tipo = "QuizesVF";
            return tipo;
        }

        public void mostrarQuizes()
        {                       
                
                FirebaseResponse quizesMO = cf.client.Get(@"Quizes/QuizesMO");
                Dictionary<string, QuizMO> quizesMultiOpcion =
                    JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(quizesMO.Body.ToString());
                if (quizesMultiOpcion != null)
                {
                    foreach (var q in quizesMultiOpcion)
                    {
                        if (q.Value.creadoPor.username == cf.usuarioConectado.username)
                        {
                            dataGridQuizes.Rows.Add(false, q.Key, "MultiOpcion", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                        }
                    }
                }

                FirebaseResponse quizesA = cf.client.Get(@"Quizes/QuizesPA");
                Dictionary<string, QuizPA> quizesAbiertos =
                    JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesA.Body.ToString());
                if (quizesAbiertos != null)
                {
                    foreach (var q in quizesAbiertos)
                    {
                        if (q.Value.creadoPor.username == cf.usuarioConectado.username)
                        {
                            dataGridQuizes.Rows.Add(false, q.Key, "Pregunta Abierta", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                        }
                    }
                }

                FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
                Dictionary<string, QuizVF> quizesVerdaderoFalso =
                    JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());
                if (quizesVerdaderoFalso != null)
                {
                    foreach (var q in quizesVerdaderoFalso)
                    {
                        if (q.Value.creadoPor.username == cf.usuarioConectado.username)
                        {
                            dataGridQuizes.Rows.Add(false, q.Key, "Verdadero/Falso", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                        }
                    }
                }
        }

        public void cambiarEstado(string estadoQuiz)
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true && dataGridQuizes.Rows[i].Cells[1].Value != null)
                {
                    string tipo = getTipoQuiz(dataGridQuizes.Rows[i].Cells[2].Value.ToString());
                    string nombreQuiz = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    FirebaseResponse editarEstado =
                        cf.client.Get("/Quizes/" + tipo + "/" + nombreQuiz);

                    if (tipo == "QuizesMO")
                    {

                        QuizMO quizMO = editarEstado.ResultAs<QuizMO>();
                        quizMO.estado = estadoQuiz;
                        cf.client.Set("Quizes/QuizesMO/" + nombreQuiz + "/", quizMO);
                    }
                    if (tipo == "QuizesPA")
                    {

                        QuizPA quizPA = editarEstado.ResultAs<QuizPA>();
                        quizPA.estado = estadoQuiz;
                        cf.client.Set("Quizes/QuizesPA/" + nombreQuiz + "/", quizPA);
                    }
                    if (tipo == "QuizesVF")
                    {
                        QuizVF quizVF = editarEstado.ResultAs<QuizVF>();
                        quizVF.estado = estadoQuiz;
                        cf.client.Set("Quizes/QuizesVF/" + nombreQuiz + "/", quizVF);
                    }

                    dataGridQuizes.Rows[i].Cells[7].Value = estadoQuiz;
                }
            }
        }

        private void botonLanzado_Click(object sender, EventArgs e)
        {
            string estado = "Lanzado";
            cambiarEstado(estado);
            if (comboBoxEstados.Text != estado && comboBoxEstados.Text != "") eliminarDatosGrid();
            deseleccionarChecks();

        }

        private void botonCancelado_Click(object sender, EventArgs e)
        {
            string estado = "Cancelado";
            cambiarEstado(estado);
            if (comboBoxEstados.Text != estado && comboBoxEstados.Text != "") eliminarDatosGrid();
            deseleccionarChecks();
        }

        private void botonTerminado_Click(object sender, EventArgs e)
        {
            string estado = "Terminado";
            cambiarEstado(estado);
            if (comboBoxEstados.Text != estado && comboBoxEstados.Text != "") eliminarDatosGrid();
            deseleccionarChecks();
        }

        private void botonRPublicados_Click(object sender, EventArgs e)
        {
            string estado = "Resultados publicados";
            cambiarEstado(estado);
            if (comboBoxEstados.Text != estado && comboBoxEstados.Text != "") eliminarDatosGrid();
            deseleccionarChecks();

        }

        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = comboBoxEstados.Text;
            mostrarQuizesFiltrados(estado);
        }

        
        public void mostrarQuizesFiltrados(string filtro)
        {
            dataGridQuizes.Rows.Clear();

            FirebaseResponse quizesMO = cf.client.Get(@"Quizes/QuizesMO");
            Dictionary<string, QuizMO> quizesMultiOpcion =
                JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(quizesMO.Body.ToString());
            if (quizesMultiOpcion != null)
            {
                foreach (var q in quizesMultiOpcion)
                {
                    if (q.Value.estado == filtro && q.Value.creadoPor.username == cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "MultiOpcion", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                    }
                }
            }

            FirebaseResponse quizesA = cf.client.Get(@"Quizes/QuizesPA");
            Dictionary<string, QuizPA> quizesAbiertos =
                JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesA.Body.ToString());
            if (quizesAbiertos != null)
            {
                foreach (var q in quizesAbiertos)
                {
                    if (q.Value.estado == filtro && q.Value.creadoPor.username == cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "Pregunta Abierta", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                    }
                }
            }

            FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
            Dictionary<string, QuizVF> quizesVerdaderoFalso =
                JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());
            if (quizesVerdaderoFalso != null)
            {
                foreach (var q in quizesVerdaderoFalso)
                {
                    if (q.Value.estado == filtro && q.Value.creadoPor.username == cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "Verdadero/Falso", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                    }
                }
            }

            
        }

        public void eliminarDatosGrid()
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    dataGridQuizes.Rows.Remove(dataGridQuizes.Rows[i]);
                }
            }
        }

        public void deseleccionarChecks()
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true) dataGridQuizes.Rows[i].Cells[0].Value = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridQuizes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using Newtonsoft.Json;
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
    public partial class Estadisticas : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        Quiz quiz;
        MyQuizifyServices services = new MyQuizifyServices();
        public Estadisticas(Quiz q)
        {
            InitializeComponent();
            quiz = q;
            lblNombreQuiz.Text = quiz.nombreQuiz;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            dataGridEstadisticas.Columns.Add("nombre", "Nombre");
            dataGridEstadisticas.Columns.Add("apellidos", "Apellidos");
            dataGridEstadisticas.Columns.Add("nota", "Nota");
            mostrarEstadisticas();
        }
        public void mostrarEstadisticas()
        {
            Dictionary<string, CalificacionVF> diccionarioCalificacion = services.getDiccionarioCalificacionVF(quiz);
            double media = 0, maxima = 0, minima = 10;
            int count = 0;
            foreach (var calificacion in diccionarioCalificacion)
            {
                if (calificacion.Value.quizRealizado.nombreQuiz == quiz.nombreQuiz)
                {
                    dataGridEstadisticas.Rows.Add(calificacion.Value.examinado.nombre, calificacion.Value.examinado.apellidos, calificacion.Value.nota);
                    media = media + calificacion.Value.nota;
                    count++;
                    if (maxima < calificacion.Value.nota) { maxima = calificacion.Value.nota; }
                    if (minima > calificacion.Value.nota) { minima = calificacion.Value.nota; }
                }
            }
            media = media / count;
            lblMedia.Text = media.ToString();
            lblMaxima.Text = maxima.ToString();
            lblMinima.Text = minima.ToString();
        }

        private void btbVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

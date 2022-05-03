using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
<<<<<<< HEAD
using MyQuizifyLib.BussinessLogic.Servicios;
=======
>>>>>>> dc5f3a276ef3c4fd4be29d84c230f7b932f28d38
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
<<<<<<< HEAD
        Quiz quiz;
        MyQuizifyServices services = new MyQuizifyServices();
        public Estadisticas(Quiz q)
=======
        public Estadisticas()
>>>>>>> dc5f3a276ef3c4fd4be29d84c230f7b932f28d38
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

            Dictionary<string, Calificacion> diccionarioCalificacion = services.getDiccionarioCalificacion();
            double media = 0, maxima = 0, minima = 10;
            int count = 0;
            foreach (var calificacion in diccionarioCalificacion) 
            {
               if (calificacion.Value.quizRealizado.nombreQuiz == quiz.nombreQuiz)
               {
                   dataGridEstadisticas.Rows.Add(calificacion.Value.examinado.nombre, calificacion.Value.examinado.apellidos, calificacion.Value.nota);
                    media = media + calificacion.Value.nota;
                    count++;
                    if(maxima < calificacion.Value.nota) { maxima = calificacion.Value.nota; }
                    if(minima > calificacion.Value.nota) { minima = calificacion.Value.nota; }  
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

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }
    }
}

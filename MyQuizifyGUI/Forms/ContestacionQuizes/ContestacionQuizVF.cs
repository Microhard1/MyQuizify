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

namespace MyQuizifyGUI.Forms.ContestacionQuizes
{
    public partial class ContestacionQuizVF : Form
    {
        Quiz quiz;
        ICollection<Pregunta> preguntasSinContestar = new List<Pregunta>();
        MyQuizifyServices servicios = new MyQuizifyServices();
        int progreso = 0;

        public ContestacionQuizVF(Quiz q)
        {
            InitializeComponent();
            quiz = q;
            quiz.preguntas = servicios.preguntasDeUnQuiz(q.nombreQuiz);
            preguntasSinContestar = quiz.preguntas;
            cargarPregunta();
            progreso = getProgreso();
        }

        private int getProgreso()
        {
            return 100/quiz.preguntas.Count;
        }
        private void cargarPregunta()
        {
            if (preguntasSinContestar.Count>0)
            {
                Pregunta p = preguntasSinContestar.ElementAt(0);
                preguntasSinContestar.Remove(preguntasSinContestar.ElementAt(0));

                Enunciado.Text = p.enunciado;
            }

        }
        private void ContestacionQuizVF_Load(object sender, EventArgs e)
        {

        }

        private void Enunciado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarPregunta();
            if (preguntasSinContestar.Count > 0)
            {
                cargarPregunta();
            }
            else if (preguntasSinContestar.Count > 1)
            {
                progressBar1.Value += progreso;
            }
            else
            {
                MessageBox.Show("Quiz finalizado");
            }
          
        }
    }
}

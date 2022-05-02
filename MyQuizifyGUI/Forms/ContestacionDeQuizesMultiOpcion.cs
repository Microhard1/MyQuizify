using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyGUI.Forms
{
    public partial class ContestacionDeQuizesMultiOpcion : Form
    {
        Quiz aContestar;
        int contadorPregunta;
        MyQuizifyServices servicios = new MyQuizifyServices();
        public ContestacionDeQuizesMultiOpcion(Quiz q)
        {
            InitializeComponent();
            this.aContestar = q;
        }

        private void ContestacionDeQuizesMultiOpcion_Load(object sender, EventArgs e)
        {
            contadorPregunta = 0;
            aContestar.preguntas = servicios.preguntasDeUnQuiz(aContestar.nombreQuiz);
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            
        }
    }
}

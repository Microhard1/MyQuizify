using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            progreso = getProgreso();
            cargarPregunta(); 
            inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
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
                string res = servicios.getRespuestaVF(preguntasSinContestar.ElementAt(0));
                inputImagen.Image = getImagen();
                preguntasSinContestar.Remove(preguntasSinContestar.ElementAt(0));
                Enunciado.Text = p.enunciado;
            }
            else
            {
                botonSiguiente.Text = "Enviar quiz";
                var result = MessageBox.Show("Test enviado", "Envio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }
        private Image getImagen()
        {
            byte[] img = Convert.FromBase64String(preguntasSinContestar.ElementAt(0).imagen);
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }
        private void ContestacionQuizVF_Load(object sender, EventArgs e)
        {

        }

        private void Enunciado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (preguntasSinContestar.Count > 0)
            {
                if (comprobarRespuesta()) {
                    MessageBox.Show("Respuesta correcta");
                }
                cargarPregunta();
                progressBar1.Value += progreso;
            }
        }

        private bool comprobarRespuesta()
        {
            Pregunta p = preguntasSinContestar.ElementAt(0);
            string res = servicios.getRespuestaVF(p);
            if (botonVerdadero.Checked && res.Contains( "True")) {
                return true;
            }
            else if (botonFalso.Checked && res.Contains("False"))
            {
                return true;
            }
            return false;
        }
        private void inputImagen_Click(object sender, EventArgs e)
        {

        }
    }
}

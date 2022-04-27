using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using MyQuizifyLib.Persistencia;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class QuizMO : Quiz
    {
        ConexionBD cf = ConexionBD.getInstancia();
        public ICollection<Pregunta> preguntasMO;

        public QuizMO(string nombreQuiz, Instructor creadoPor, int duracion, int peso, string dificultad,
                DateTime inicio, DateTime fin, string estado, Curso asignatura) : 
            base(nombreQuiz, creadoPor, duracion, peso, dificultad, inicio, fin, estado, asignatura)
        {
            this.preguntasMO = preguntas;
            FirebaseResponse res = cf.client.Set("/Quizes/QuizesMO/" + nombreQuiz , this);
        }

        public override Pregunta crearPregunta(string id,string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaMO(id, enunciado, imagen, puntuacion, explicacion);
            return p;
        }
    }
}

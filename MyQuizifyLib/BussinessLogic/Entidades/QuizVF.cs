using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class QuizVF : Quiz
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public QuizVF(string nombreQuiz, Instructor creadoPor, int duracion, string dificultad,
                DateTime inicio, DateTime fin, string estado, Curso asignatura) :
            base(nombreQuiz, creadoPor, duracion, dificultad, inicio, fin, estado, asignatura)
        {
            
            FirebaseResponse res = cf.client.Set("/Quizes/QuizesVF/" + nombreQuiz, this);
        }
        public override Pregunta crearPregunta(string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaMO(enunciado, imagen, puntuacion, explicacion);
            return p;
        }
    }
}

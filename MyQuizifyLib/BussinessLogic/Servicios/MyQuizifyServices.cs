using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyQuizifyLib.BussinessLogic.Servicios
{
    public class MyQuizifyServices : IServices
    {
        public MyQuizifyServices() 
        { 

        }

        ConexionBD cf = ConexionBD.getInstancia();

        public Dictionary<string, PreguntaMO> obtenerPreguntas()
        {
            FirebaseResponse preguntasDB = cf.client.Get(@"Preguntas");
            Dictionary<string, PreguntaMO> datos =
                JsonConvert.DeserializeObject<Dictionary<string, PreguntaMO>>(preguntasDB.Body.ToString());
            return datos;
        }
        public Dictionary<string, Bateria> obtenerBaterias()
        {
            FirebaseResponse bateriasDB = cf.client.Get(@"Baterias");
            Dictionary<string, Bateria> datos =
                JsonConvert.DeserializeObject<Dictionary<string, Bateria>>(bateriasDB.Body.ToString());
            return datos;
        }

        public Alumno getAlumnoById(string id) 
        {
            FirebaseResponse get = cf.client.Get("Usuarios/Alumnos/"+ id);
            Alumno a = get.ResultAs<Alumno>();
            return a;
        }
        public Instructor getInstructorById(string id)
        {
            FirebaseResponse get = cf.client.Get("Usuarios/Instructores/" + id);
            Instructor i = get.ResultAs<Instructor>();
            return i;
        }

        public Quiz getQuizById(string id)
        {
            FirebaseResponse getQuizMO = cf.client.Get(@"Quizes/QuizesMO/" + id);
            QuizMO qmo = getQuizMO.ResultAs<QuizMO>();
            FirebaseResponse getQuizPA = cf.client.Get(@"Quizes/QuizesPA/" + id);
            QuizPA qpa = getQuizPA.ResultAs<QuizPA>();
            FirebaseResponse getQuizVF = cf.client.Get(@"Quizes/QuizesVF/" + id);
            QuizVF qvf = getQuizVF.ResultAs<QuizVF>();

            if (qmo == null)
            {
                if (qpa == null)
                {
                    if (qvf == null)
                    {
                        return null;
                    }
                    else return qvf;
                }
                else return qpa;
            } 
            else return qmo;
           
        }

        public Type getTipoQuiz(string id)
        {
            if(getQuizById(id) != null)
            return getQuizById(id).GetType();
            return null;
        }

        public Curso getCursoById(string id)
        {
            Curso c = cf.client.Get("Cursos/" + id).ResultAs<Curso>();
            return c;
        }

        public List<Curso> listarCursos() 
        {
            FirebaseResponse cursos = cf.client.Get(@"Cursos/");
            List<Curso> listaCursos = new List<Curso>();
            Dictionary<string, Curso> dicCursos = JsonConvert.DeserializeObject<Dictionary<string, Curso>>(cursos.Body.ToString());
            foreach(var curso in dicCursos)
            {
                Curso aux = getCursoById(curso.Value.id);
                listaCursos.Add(aux);
            }
            return listaCursos;
        }

        public List<Quiz> listaQuizes()
        {
            List<Quiz> quizes = new List<Quiz>();
            FirebaseResponse quizesMO = cf.client.Get(@"Quizes/QuizesMO");
            Dictionary<string, QuizMO> quizesMultiOpcion =
                JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(quizesMO.Body.ToString());

            foreach(var item in quizesMultiOpcion)
            {
                quizes.Add(getQuizById(item.Value.nombreQuiz));
            }

            FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
            Dictionary<string, QuizVF> quizesVerdaderoFalso =
                JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());

            foreach (var item in quizesVerdaderoFalso)
            {
                quizes.Add(getQuizById(item.Value.nombreQuiz));
            }

            FirebaseResponse quizesPA = cf.client.Get(@"Quizes/QuizesPA");
            Dictionary<string, QuizPA> quizesPreguntaAbierta =
                JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesPA.Body.ToString());

            foreach (var item in quizesPreguntaAbierta)
            {
                quizes.Add(getQuizById(item.Value.nombreQuiz));
            }

            return quizes;
        }

        
    }
}

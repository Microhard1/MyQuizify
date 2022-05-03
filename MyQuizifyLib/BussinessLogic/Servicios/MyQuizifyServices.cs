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
            FirebaseResponse getQuizMO = cf.client.Get("Quizes/QuizesMO/" + id);
            QuizMO qmo = getQuizMO.ResultAs<QuizMO>();
            FirebaseResponse getQuizPA = cf.client.Get("Quizes/QuizesPA/" + id);
            QuizPA qpa = getQuizPA.ResultAs<QuizPA>();
            FirebaseResponse getQuizVF = cf.client.Get("Quizes/QuizesVF/" + id);
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

        public string getTipoQuiz(Quiz q)
        {
            return q.GetType().Name;
            
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
        
        public List<Pregunta> preguntasDeUnQuiz(string nombreQuiz)
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Quiz q = getQuizById(nombreQuiz);
            if (getTipoQuiz(q) == "QuizPA")
            {
                FirebaseResponse preguntasDelQuiz = cf.client.Get(@"Preguntas/PreguntasAbiertas/" + q.nombreQuiz);
                Dictionary<string, PreguntaA> p =
                    JsonConvert.DeserializeObject<Dictionary<string, PreguntaA>>(preguntasDelQuiz.Body.ToString());
                foreach (var preg in p)
                {
                    preguntas.Add(preg.Value);
                }
                
            }
            if (getTipoQuiz(q) == "QuizMO")
            {
                FirebaseResponse preguntasDelQuiz = cf.client.Get(@"Preguntas/PreguntasMultiOpcion/" + q.nombreQuiz);
                Dictionary<string, PreguntaMO> p =
                    JsonConvert.DeserializeObject<Dictionary<string, PreguntaMO>>(preguntasDelQuiz.Body.ToString());
                foreach (var preg in p)
                {
                    preguntas.Add(preg.Value);
                }

            }
            if (getTipoQuiz(q) == "QuizVF")
            {
                FirebaseResponse preguntasDelQuiz = cf.client.Get(@"Preguntas/PreguntasverdaderoFalso/" + q.nombreQuiz);
                Dictionary<string, PreguntaVF> p =
                    JsonConvert.DeserializeObject<Dictionary<string, PreguntaVF>>(preguntasDelQuiz.Body.ToString());
                foreach (var preg in p)
                {
                    preguntas.Add(preg.Value);
                }

            }
            return preguntas;
        }

        public List<Respuesta> respuestasDeUnaPregunta(string idPregunta)
        {
            List<Respuesta> respuestas = new List<Respuesta>();
            if (getPreguntaMOById(idPregunta) != null)
            {
               
                FirebaseResponse resp1 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/0");
                Respuesta a = resp1.ResultAs<Respuesta>();
                FirebaseResponse resp2 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/1");
                Respuesta b = resp2.ResultAs<Respuesta>();
                FirebaseResponse resp3 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/2");
                Respuesta c = resp3.ResultAs<Respuesta>();
                FirebaseResponse resp4 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/3");
                Respuesta d = resp4.ResultAs<Respuesta>();
                respuestas.Add(a);
                respuestas.Add(b);
                respuestas.Add(c);
                respuestas.Add(d);
            }
            else if (getPreguntaAById(idPregunta) != null)
            {
                FirebaseResponse resp1 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/0");
                Respuesta a = resp1.ResultAs<Respuesta>();
                FirebaseResponse resp2 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/1");
                Respuesta b = resp2.ResultAs<Respuesta>();
                FirebaseResponse resp3 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/2");
                Respuesta c = resp3.ResultAs<Respuesta>();
                FirebaseResponse resp4 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/3");
                Respuesta d = resp4.ResultAs<Respuesta>();
                respuestas.Add(a);
                respuestas.Add(b);
                respuestas.Add(c);
                respuestas.Add(d);
            }
            else if (getPreguntaVFById(idPregunta) != null)
            {
                FirebaseResponse resp1 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/0");
                Respuesta a = resp1.ResultAs<Respuesta>();
                FirebaseResponse resp2 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/1");
                Respuesta b = resp2.ResultAs<Respuesta>();
                FirebaseResponse resp3 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/2");
                Respuesta c = resp3.ResultAs<Respuesta>();
                FirebaseResponse resp4 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/3");
                Respuesta d = resp4.ResultAs<Respuesta>();
                respuestas.Add(a);
                respuestas.Add(b);
                respuestas.Add(c);
                respuestas.Add(d);
            }

            return respuestas;
        }

        public Pregunta getPreguntaById(string id, string nombreQuiz)
        {
            FirebaseResponse preguntaMO = cf.client.Get("Preguntas/PreguntasMultiOpcion/" + nombreQuiz + "/"+ id);
            Pregunta p1 = preguntaMO.ResultAs<PreguntaMO>();
            if (preguntaMO != null) return p1;
            FirebaseResponse preguntaVF = cf.client.Get("Preguntas/PreguntasVerdaderoFalso/" + nombreQuiz + "/" + id);
            Pregunta p2 = preguntaVF.ResultAs<PreguntaVF>();
            if (preguntaVF != null) return p2;
            FirebaseResponse preguntaPA = cf.client.Get("Preguntas/PreguntasAbiertas/" + nombreQuiz + "/" + id);
            Pregunta p3 = preguntaPA.ResultAs<PreguntaA>();
            if (preguntaPA != null) return p3;

            return null;
            
        }
        public Dictionary<string, Calificacion> getDiccionarioCalificacion()
        {
            FirebaseResponse calificaciones = cf.client.Get(@"Calificaciones");
            Dictionary<string, Calificacion> diccionarioCalificacion =
                JsonConvert.DeserializeObject<Dictionary<string, Calificacion>>(calificaciones.Body.ToString());
            return diccionarioCalificacion;
        }

        


    }
}

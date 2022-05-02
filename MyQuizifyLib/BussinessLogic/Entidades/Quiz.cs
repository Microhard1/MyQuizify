using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQuizifyLib.Persistencia;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Quiz
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public ICollection<Pregunta> preguntas;
        public ICollection<Alumno> hechoPor;

        public Curso asignatura;
        public Instructor creadoPor;

        public DateTime fechaDeInicio;
        public DateTime fechaFin;

        public int peso;
        public int duracion;
        public string dificultad;
        public string nombreQuiz;

        public string estado;

        public Quiz(string nombreQuiz, Instructor creadoPor, int duracion, int peso, string dificultad,
                DateTime inicio, DateTime fin, string estado, Curso asignatura)
        {
            this.peso = peso;
            this.nombreQuiz = nombreQuiz;
            this.creadoPor = creadoPor;
            this.duracion = duracion;
            this.dificultad = dificultad;
            this.fechaDeInicio = inicio;
            this.fechaFin = fin;
            this.estado = estado;
            this.asignatura = asignatura;

            preguntas = new List<Pregunta>();

        }

        public void añadirPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            string tipo = "";
            if (this.GetType().Name == "QuizMO") tipo = "MultiOpcion";
            if (this.GetType().Name == "QuizVF") tipo = "VerdaderoFalso";
            if (this.GetType().Name == "QuizPA") tipo = "Abierta";

            Pregunta p = crearPregunta(id, enunciado, imagen, puntuacion, explicacion);
            preguntas.Add(p);
            FirebaseResponse addPregunta = cf.client.Set("Preguntas/"+ tipo + "/" + this.nombreQuiz, p);
        }

        public abstract Pregunta crearPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion);
        
        public bool preguntasRepetidas()
        {
            /* REFACTORING?
            var myArray = preguntasQuiz.ToArray<Pregunta>();
            var longitud = preguntasQuiz.Count;

            for (int i = 0; i < longitud - 1; i++)
            {
                if (myArray[i].enunciado.Equals(myArray[i + 1].enunciado))
                {
                    return true;
                }
            }
            return false;
            */

            for (int i = 0; i < preguntas.Count - 1; i++)
            {
                if (preguntas.ToArray<Pregunta>()[i].enunciado.Equals(preguntas.ToArray<Pregunta>()[i + 1].enunciado))
                {
                    return true;
                }
            }
            return false;
        }
        public void ordenAleatorioPreguntas(Quiz q) 
        { 
            Random rnd = new Random();
            q.preguntas.OrderBy(item => rnd.Next());
        }
        public Quiz clonarQuiz(Quiz q) 
        {
            //eliminar despues de entrega sprint 2
            String nombreUsuario = cf.usuarioConectado.username;
            MyQuizifyServices services = new MyQuizifyServices();
            Instructor a = services.getInstructorById(nombreUsuario);
            //eliminar despues de entrega de sprint 2

            if (this.GetType().Name == "QuizMO")
            {
                QuizMO quiz = new QuizMO(q.nombreQuiz, a/*q.creadoPor*/, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.estado, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
            else if (this.GetType().Name == "QuizVF")
            {
                QuizVF quiz = new QuizVF(q.nombreQuiz, a/*q.creadoPor*/, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.estado, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
            else 
            {
                QuizPA quiz = new QuizPA(q.nombreQuiz, a/*q.creadoPor*/, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.estado, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
        }
    }
}

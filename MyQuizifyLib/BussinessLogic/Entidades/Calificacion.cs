using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Calificacion
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public double nota;
        public Quiz quizRealizado;
        public Alumno examinado;
        public DateTime fecha;

        public Calificacion(double nota, Quiz quizRealizado, Alumno examinado , DateTime fecha)
        {
            this.fecha = fecha;
            this.nota = nota;
            this.quizRealizado = quizRealizado;
            this.examinado = examinado;

            FirebaseResponse nuevaCalificacion = 
                cf.client.Set("Calificaciones/" + quizRealizado.nombreQuiz, this);
        }
    }
}

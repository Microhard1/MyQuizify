using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Servicios
{
    public interface IServices
    {

        Alumno getAlumnoById(string id);
        Instructor getInstructorById(string id);
        Quiz getQuizById(string id);
        string getTipoQuiz(Quiz q);
        List<Curso> listarCursos();
        Curso getCursoById(string id);
        Dictionary<string, PreguntaMO> obtenerPreguntas();
        Dictionary<string, Bateria> obtenerBaterias();
        List<Quiz> listaQuizes();
        List<Pregunta> preguntasDeUnQuiz(string nombreQuiz);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        BateriaMultiOpcion getBateriaMOById(string nombreBat);
=======
>>>>>>> parent of c8995d0 (baterias arregladas)
=======
>>>>>>> parent of c8995d0 (baterias arregladas)

=======
>>>>>>> dfb136d49427070422d659d70a11d20629f6bdff
    }
}

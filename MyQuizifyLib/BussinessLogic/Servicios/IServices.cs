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
        Type getTipoQuiz(string id);
        List<Curso> listarCursos();
        Curso getCursoById(string id);





    }
}

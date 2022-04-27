using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Pregunta
    {

        public ICollection<Respuesta> respuestas;
        public string id;
        public string enunciado;
        public string imagen;
        public double puntuacion;
        public string explicacion;

        public Pregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            this.id = id;
            this.enunciado = enunciado;
            this.explicacion = explicacion;
            this.puntuacion = puntuacion;
            this.imagen = imagen;

            respuestas = new List<Respuesta>();
        }

        public Pregunta(string enunciado, double puntuacion, string explicacion)
        {
            this.enunciado = enunciado;
            this.explicacion = explicacion;
            this.puntuacion = puntuacion;
        }

        public void añadirRespuesta(string enunciado)
        {
            Respuesta r = crearRespuesta(enunciado);
            respuestas.Add(r);
        }

        public abstract Respuesta crearRespuesta(string enunciado);
    }   
}

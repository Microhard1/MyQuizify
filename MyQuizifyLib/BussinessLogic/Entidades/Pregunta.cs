using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Pregunta
    {
        ConexionBD cf = ConexionBD.getInstancia();
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

        

        public void añadirRespuesta(Respuesta r)
        {
            respuestas.Add(r);
            FirebaseResponse addRespuesta = cf.client.Set("Respuestas/" + this.id, r);
        }

        public abstract Respuesta crearRespuesta(string enunciado);
        public void añadirImagen()
        {

        }
    }   
}

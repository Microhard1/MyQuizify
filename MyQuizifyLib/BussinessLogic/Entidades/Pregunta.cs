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

        

        public void añadirRespuesta(string enunciado)
        {
<<<<<<< HEAD

            string tipo = "";
            if (this.GetType().Name == "PreguntaA") tipo = "RespuestasMultiOpcion";
            if (this.GetType().Name == "PreguntaMO") tipo = "RespuestasAbiertas";
            if (this.GetType().Name == "PreguntaVF") tipo = "RespuestasVerdaderoFalso";
=======
>>>>>>> parent of c8995d0 (baterias arregladas)
            Respuesta r = crearRespuesta(enunciado);

            respuestas.Add(r);
            FirebaseResponse addRespuesta = cf.client.Set("Respuestas/" + this.id, respuestas);
        }

        public abstract Respuesta crearRespuesta(string enunciado);

        public override string ToString()
        {
            return "id: " + id + "\n" + 
                "Enunciado: " + enunciado + "\n" + 
                "Explicacion: " + explicacion + "\n" 
                + "puntuacion: " + puntuacion + "\n" 
                + "imagen: " + imagen + "\n";
        }
    }   
}

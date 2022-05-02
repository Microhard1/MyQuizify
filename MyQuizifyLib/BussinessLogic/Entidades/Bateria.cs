using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQuizifyLib.Persistencia;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Bateria
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public ICollection<PreguntaMO> preguntasBateria;
        public string id;

        public Bateria(string id ,List<PreguntaMO> preguntasBateria)
        {
            this.id = id;
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/" + id, this);
        }

        public bool contienePregunta(string nombrePregunta)
        {
            foreach(var pregunta in preguntasBateria)
            {
                if(pregunta.id == nombrePregunta)
                {
                    return true;
                }
            }
            return false;
        }



    }
}

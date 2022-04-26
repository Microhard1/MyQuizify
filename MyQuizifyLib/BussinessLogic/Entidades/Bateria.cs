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

        public ICollection<Pregunta> preguntasBateria;
        public string id;

        public Bateria(string id ,List<Pregunta> preguntasBateria)
        {
            this.id = id;
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/" + id, this);
        }





    }
}

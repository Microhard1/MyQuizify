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
    public class BateriaAbierta
    {
        ConexionBD cf = ConexionBD.getInstancia();
        public ICollection<PreguntaA> preguntasBateria;
        public string id;

        public BateriaAbierta(string id ,List<PreguntaA> preguntasBateria)
        {
            this.id = id;
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/Abiertas/" + id, this);
        }
    }
}

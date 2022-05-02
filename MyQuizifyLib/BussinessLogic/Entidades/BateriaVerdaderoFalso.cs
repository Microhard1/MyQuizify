using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class BateriaVerdaderoFalso
    {
        ConexionBD cf = ConexionBD.getInstancia();
        public ICollection<PreguntaVF> preguntasBateria;
        public string id;

        public BateriaVerdaderoFalso(string id, List<PreguntaVF> preguntasBateria)
        {
            this.id = id;
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/VerdaderoFalso/" + id, this);
        }
    }
}

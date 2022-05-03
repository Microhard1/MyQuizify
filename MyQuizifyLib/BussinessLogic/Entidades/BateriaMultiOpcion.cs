using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class BateriaMultiOpcion
    {
        ConexionBD cf = ConexionBD.getInstancia();
        public ICollection<PreguntaMO> preguntasBateria;
        public string id;

        public BateriaMultiOpcion(string id, List<PreguntaMO> preguntasBateria)
        {
            this.id = id;
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/MultiOpcion/" + id, this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using MyQuizifyLib.BussinessLogic.Entidades;
using Newtonsoft.Json;

namespace MyQuizifyGUI
{
    public partial class CrearQuiz : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        public CrearQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void CrearQuiz_Load(object sender, EventArgs e)
        {
            FirebaseResponse preguntasDB = cf.client.Get(@"Preguntas");
            Dictionary<string, PreguntaMO> datos =
                JsonConvert.DeserializeObject<Dictionary<string, PreguntaMO>>(preguntasDB.Body.ToString());
            cargarDatos(datos);            
        }

        void cargarDatos(Dictionary<string, PreguntaMO> data) {

            dataGridPreguntas.Rows.Clear();
            dataGridPreguntas.Columns.Clear();

            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data) {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }
    }
}

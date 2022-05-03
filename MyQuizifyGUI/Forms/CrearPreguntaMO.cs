using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CrearPreguntaMO : Form
    {
        public CrearPreguntaMO()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enunciado = textBoxEnunciado.Text;
            string explicacion = textBoxExplicacion.Text;
            string id = textBoxNombrePregunta.Text;
            Pregunta p = new PreguntaMO(id, enunciado, "", 0, explicacion);
            p.añadirRespuesta(textBox1.Text);
            p.añadirRespuesta(textBox2.Text);
            p.añadirRespuesta(textBox3.Text);
            p.añadirRespuesta(textBox4.Text);
            MessageBox.Show("Pregunta creada con exito");
        }

    }
}

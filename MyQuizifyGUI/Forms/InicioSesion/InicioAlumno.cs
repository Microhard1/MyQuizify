using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.Persistencia;
using FireSharp;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using MyQuizifyGUI.Forms;

namespace MyQuizifyGUI
{
    public partial class InicioAlumno : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        private CrearQuiz crearQuizForm;
        public InicioAlumno()
        {
            InitializeComponent();
            crearQuizForm = new CrearQuiz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoQuizes alumnoQuizes = new AlumnoQuizes();
            alumnoQuizes.TopLevel = false;
            panelForms.Controls.Add(alumnoQuizes);
            alumnoQuizes.Show();
            
        }

        private void InicioAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}

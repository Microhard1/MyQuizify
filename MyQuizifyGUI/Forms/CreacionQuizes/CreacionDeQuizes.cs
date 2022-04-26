using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyGUI;
using MyQuizifyLib.Persistencia;
using MyQuizifyLib.BussinessLogic.Servicios;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;

namespace MyQuizifyGUI.Forms
{
    public partial class CreacionDeQuizes : Form
    {
        private FormMO formMO;
        private FormVF formVF;
        private FormAbierto formAb; 
        ConexionBD cf = ConexionBD.getInstancia();
        public CreacionDeQuizes()
        {
            formVF = new FormVF();
            formMO = new FormMO();
            formAb = new FormAbierto();
            InitializeComponent();
        }

        private void CreacionDeQuizes_Load(object sender, EventArgs e)
        {
            panelQuizes.Controls.Clear();
            comboBoxTipos.Items.Clear();
            comboBoxCursos.Items.Clear();
            FirebaseResponse r = cf.client.Get(@"Cursos/");
            Dictionary<string, Curso> cursos = new Dictionary<string, Curso>();
            cursos = r.ResultAs<Dictionary<string, Curso>>();
            foreach(var item in cursos)
            {
                comboBoxCursos.Items.Add(item.Key);
            }

            comboBoxTipos.Items.Add("MultiOpcion");
            comboBoxTipos.Items.Add("Respuesta Abierta");
            comboBoxTipos.Items.Add("Verdadero/Falso");

            formVF.TopLevel = false;
            formMO.TopLevel = false;
            formAb.TopLevel = false;
            panelQuizes.Controls.Add(formMO);
            formMO.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = comboBoxTipos.SelectedItem.ToString();
            if(tipo == "MultiOpcion") 
            {
                
                
                panelQuizes.Controls.Clear();
                panelQuizes.Controls.Add(formMO);
                formMO.Show();
            }
            if (tipo == "Verdadero/Falso")
            {
                panelQuizes.Controls.Clear();
                panelQuizes.Controls.Add(formVF);
                formVF.Show();
            }
            if (tipo == "Respuesta Abierta")
            {
                panelQuizes.Controls.Clear();
                panelQuizes.Controls.Add(formAb);
                formAb.Show();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;

namespace MyQuizifyGUI.Forms
{
    public partial class PantallaPrincipalInstructor : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public PantallaPrincipalInstructor()
        {
            InitializeComponent();
        }

        private void PantallaPrincipalInstructor_Load(object sender, EventArgs e)
        {
            dataGridViewCursos.Rows.Clear();

            dataGridViewCursos.Columns.Add("nombre", "Nombre");
            dataGridViewCursos.Columns.Add("id", "Id");

            poblarGrid();
            
        }

        public void poblarGrid()
        {
            List<Curso> lista = services.listarCursos();
            foreach (Curso c in lista)
            {
                dataGridViewCursos.Rows.Add(false, c.nombre, c.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridViewCursos.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridViewCursos.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    Curso c = services.getCursoById(dataGridViewCursos.Rows[i].Cells[2].Value.ToString());
                    c.addInstructor(services.getInstructorById(cf.usuarioConectado.username));
                }
            }

            for(int i = 0; i < dataGridViewCursos.Rows.Count - 1; i++)
            {
                dataGridViewCursos.Rows[i].Cells[0].Value = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}

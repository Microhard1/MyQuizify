﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.BussinessLogic.Entidades;

namespace MyQuizifyGUI.Forms
{
    public partial class CaracteristicasPrincipales : Form
    {
        private Quiz quiz;
        public CaracteristicasPrincipales(Quiz quiz)
        {
            InitializeComponent();
            lblNombreQuiz.Text = quiz.nombreQuiz;
            lblDuracion.Text = quiz.duracion + "";
            lblDificultad.Text = quiz.dificultad;
            lblCurso.Text = quiz.asignatura.nombre;
            lblPeso.Text = quiz.peso + "";
            lblFechaInicio.Text = quiz.fechaDeInicio + "";
            lblFechaFin.Text = quiz.fechaFin + "";
            this.quiz = quiz;
        }

        private void panelQuizes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
           ContestacionDeQuizesMultiOpcion contestacionDeQuizesMultiOpcion = new ContestacionDeQuizesMultiOpcion(quiz);
           contestacionDeQuizesMultiOpcion.ShowDialog();
        }
    }
}
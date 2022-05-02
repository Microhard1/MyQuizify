﻿using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
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
    public partial class CrearBateria : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        Dictionary<string, PreguntaMO> preguntasMO;
        Dictionary<string, PreguntaVF> preguntasVF;
        Dictionary<string, PreguntaA> preguntasA;
        List<PreguntaA> preguntasBateriaA;
        List<PreguntaMO> preguntasBateriaMO;
        List<PreguntaVF> preguntasBateriaVF;
        public CrearBateria()
        {
            preguntasMO = services.obtenerPreguntasMO();
            preguntasVF = services.obtenerPreguntasVF();
            preguntasA = services.obtenerPreguntasA();
            preguntasBateriaMO = new List<PreguntaMO>();
            preguntasBateriaVF = new List<PreguntaVF>();
            preguntasBateriaA = new List<PreguntaA>();

            InitializeComponent();
        }

        private void CrearPregunta_Load(object sender, EventArgs e)
        {
            
            
        }
        void cargarDatosMO(Dictionary<string, PreguntaMO> data)
        {

            dataGridPreguntas.Rows.Clear();
            dataGridPreguntas.Columns.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }
        void cargarDatosA(Dictionary<string, PreguntaA> data)
        {
            dataGridPreguntas.Columns.Clear();
            dataGridPreguntas.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }
        void cargarDatosVF(Dictionary<string, PreguntaVF> data)
        {

            dataGridPreguntas.Rows.Clear();
            dataGridPreguntas.Columns.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "MultiOpcion") cargarDatosMO(preguntasMO);
            if (comboBox1.Text == "Abierta") cargarDatosA(preguntasA);
            if (comboBox1.Text == "Verdadero Falso") cargarDatosVF(preguntasVF);
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
            int counter = 0;
            if (comprobarCampos())
            {
                bool isChecked = false;
                for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                {
                    isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                    if (isChecked)
                    {
                        if (comboBox1.Text == "MultiOpcion")
                        {
                            PreguntaMO p = services.getPreguntaMOById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                            preguntasBateriaMO.Add(p);
                            counter++;
                        }
                        if (comboBox1.Text == "Abierta")
                        {
                            PreguntaA p = services.getPreguntaAById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                            preguntasBateriaA.Add(p);
                            counter++;
                        }
                        if (comboBox1.Text == "Verdadero/Falso")
                        {
                            PreguntaVF p = services.getPreguntaVFById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                            preguntasBateriaVF.Add(p);
                            counter++;
                        }
                    }
                }
                if (counter > 3)
                {
                    if(comboBox1.Text == "MultiOpcion")
                    {
                        BateriaMultiOpcion nuevaBateria = new BateriaMultiOpcion(textBoxNombreBateria.Text, preguntasBateriaMO);
                        preguntasBateriaMO.Clear();
                        MessageBox.Show("Bateria creada correctamente");
                    }
                    if (comboBox1.Text == "Abierta")
                    {
                        BateriaAbierta nuevaBateria = new BateriaAbierta(textBoxNombreBateria.Text, preguntasBateriaA);
                        preguntasBateriaA.Clear();
                        MessageBox.Show("Bateria creada correctamente");
                    }
                    if (comboBox1.Text == "Verdadero/Falso")
                    {
                        BateriaVerdaderoFalso nuevaBateria = new BateriaVerdaderoFalso(textBoxNombreBateria.Text, preguntasBateriaVF);
                        preguntasBateriaVF.Clear();
                        MessageBox.Show("Bateria creada correctamente");
                    }

                }
            }
        }
        private bool comprobarCampos()
        {
            int counter = 0;
            if (comboBox1.Text == "" || textBoxNombreBateria.Text == "")
            {
                MessageBox.Show("Debe completar los campos");
                return false;
            }
            else
            {
                bool isChecked = false;
                for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                {
                    isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                    if (isChecked)
                    {
                        counter++;
                    }
                }
                if(counter < 4) { MessageBox.Show("La bateria debe tener al menos 4 preguntas"); }
                
            }
            return true;
        }

    }
}

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
using System.IO;
using System.Drawing.Imaging;

namespace MyQuizifyGUI.Forms
{
    public partial class CreacionDeQuizes : Form
    {
        private FormMO formMO;
        private FormVF formVF;
        private FormAbierto formAb; 
        ConexionBD cf = ConexionBD.getInstancia();
        int numeroDePregunta = 0;
        Form formularioActual = null;
        List<Pregunta> preguntas = new List<Pregunta>();
        string tipoDeQuiz = "";

        Quiz quizActual;
        public CreacionDeQuizes()
        {
            formVF = new FormVF();
            formMO = new FormMO();
            formAb = new FormAbierto();
            InitializeComponent();
            respuestaAbierta.Width = panelQuizes.Width;
        }

        private void CreacionDeQuizes_Load(object sender, EventArgs e)
        {
            panelQuizes.Controls.Clear();         
            comboBoxCursos.Items.Clear();
            FirebaseResponse r = cf.client.Get(@"Cursos/");
            Dictionary<string, Curso> cursos = new Dictionary<string, Curso>();
            cursos = r.ResultAs<Dictionary<string, Curso>>();
            foreach(var item in cursos)
            {
                comboBoxCursos.Items.Add(item.Key);
            }


            formVF.TopLevel = false;
            formMO.TopLevel = false;
            formAb.TopLevel = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pesoQuiz = Int32.Parse(textBoxPeso.Text);
            string nombreQuiz = textBoxNombreQuiz.Text;
            int duracion;
            int horas = Int32.Parse(textBoxHoras.Text);
            if (pesoQuiz < 5 || pesoQuiz > 65)
            {
                MessageBox.Show("El peso del quiz debe estar entre 5% y 65%");
            }

            //if (tipoDeQuiz == "MultiOpcion")
            //{
            //    quizActual = new QuizMO();
            //}
            //else if (tipoDeQuiz == "Verdadero/Falso")
            //{
            //    quizActual = new QuizVF();
            //}
            //else if (tipoDeQuiz == "Respuesta Abierta")
            //{
            //    quizActual = new QuizPA();
            //}
            

        }

        private void panelQuizes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonAñadirPregunta_Click(object sender, EventArgs e)
        {
            
            if (tipoDeQuiz == "MultiOpcion")
            {
                CrearPreguntaTipoTest();
            }
            else if (tipoDeQuiz == "Verdadero/Falso")
            {
                CrearPreguntaVerdaderoFalso();
            }
            else if (tipoDeQuiz == "Respuesta Abierta")
            {
                CrearPreguntaVerdaderoFalso();
            }
            numeroDePregunta++;
            panelQuizes.Controls.Clear();
        }

        public void CrearPreguntaVerdaderoFalso()
        {
            ControlCollection objetosDelFormulario = (ControlCollection)formularioActual.Controls;
            string enunciado = "";
            bool verdaderoOFalso = false;

            string imagen="";
            double puntuacion=0;
            string explicacion="";

            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton aux = (RadioButton)c;
                    if (aux.Name == "botonFalso")
                    {
                        if (aux.Checked)
                        {
                            verdaderoOFalso = false;
                        }
                        else
                        {
                            verdaderoOFalso = true;
                        }
                    }
                }
                if (c.GetType() == typeof(TextBox))
                {
                    if (c.Name == "textBoxEnunciado")
                    {
                        enunciado = ((TextBox)c).Text;
                    }
                    else if (c.Name == "textBoxPuntuacion")
                    {
                        puntuacion = Double.Parse(((TextBox)c).Text);
                    }
                    else if (c.Name == "textboxExplicacion")
                    {
                        explicacion = ((TextBox)c).Text;
                    }

                }
                if (c.GetType() == typeof(PictureBox))
                {
                    imagen = convertirImagen((PictureBox)c);
                }
            }

            string id = textBoxNombreQuiz.Text + "_" + numeroDePregunta; 

            Pregunta pregunta = new PreguntaVF(enunciado, id,imagen,puntuacion,explicacion);
            Respuesta r = pregunta.crearRespuesta(verdaderoOFalso.ToString());
            r.inicialize(verdaderoOFalso);
            pregunta.añadirRespuesta(r);

            preguntas.Add(pregunta);

            MessageBox.Show("Se ha insertado una pregunta: ");
        }

        public void CrearPreguntaTipoTest()
        {
            List<TextBox> listaRespuestas = getListaRespuestas();
            ControlCollection objetosDelFormulario = (ControlCollection)panelQuizes.Controls;
            List<Respuesta> respuestas = new List<Respuesta>();
            string enunciado = "";

            Respuesta resp;
            
            string imagen = "";
            double puntuacion = 0;
            string explicacion = "";
            Pregunta pregunta;
            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(CheckBox))
                {

                    CheckBox aux = (CheckBox)c;


                    if (aux.Name == "ckeckPregunta1")
                    {
                        foreach (TextBox t in listaRespuestas)
                        {
                            if (t.Name == "textPregunta1")
                            {
                                resp = new RespuestaMO(t.Text);
                                if (aux.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                                respuestas.Add(resp);
                            }
                        }
                    }
                    else if (aux.Name == "ckeckPregunta2")
                    {
                        foreach (TextBox t in listaRespuestas)
                        {
                            if (t.Name == "textPregunta2")
                            {
                                resp = new RespuestaMO(t.Text);
                                if (aux.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                                respuestas.Add(resp);

                            }

                        }
                    }
                    else if (aux.Name == "ckeckPregunta3")
                    {
                        foreach (TextBox t in listaRespuestas)
                        {
                            if (t.Name == "textPregunta3")
                            {
                                resp = new RespuestaMO(t.Text);
                                if (aux.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                                respuestas.Add(resp);

                            }
                        }
                    }
                    else if (aux.Name == "ckeckPregunta4")
                    {
                        foreach (TextBox t in listaRespuestas)
                        {
                            if (t.Name == "textPregunta4")
                            {
                                resp = new RespuestaMO(t.Text);
                                if (aux.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                                respuestas.Add(resp);
                            }
                        }
                    }
                }
                else if (c.GetType() == typeof(TextBox))
                {
                    if (c.Name == "enunciadoTipoTest")
                    {
                        enunciado = ((TextBox)c).Text;
                    }
                    else if (c.Name == "textBoxPuntuacion")
                    {
                        puntuacion = Double.Parse(((TextBox)c).Text);
                    }
                    else if (c.Name == "textboxExplicacion")
                    {
                        explicacion = ((TextBox)c).Text;
                    }

                }
                else if (c.GetType() == typeof(PictureBox))
                {
                    imagen = convertirImagen((PictureBox)c);
                }

            }
            string id = textBoxNombreQuiz.Text + "_" + numeroDePregunta;

            pregunta = new PreguntaVF(enunciado, id, imagen, puntuacion, explicacion);
            preguntas.Add(pregunta);
        }

        public void CrearPreguntaRespuestaAbierta()
        {
            ControlCollection objetosDelFormulario = (ControlCollection)formularioActual.Controls;
            string enunciado = "";

            string imagen = "";
            double puntuacion = 0;
            string explicacion = "";

            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (c.Name == "textboxEnunciado")
                    {
                        enunciado = ((TextBox)c).Text;
                    }
                    else if (c.Name == "textBoxPuntuacion")
                    {
                        puntuacion = Double.Parse(((TextBox)c).Text);
                    }
                    else if (c.Name == "textboxExplicacion")
                    {
                        explicacion = ((TextBox)c).Text;
                    }

                }
                if (c.GetType() == typeof(PictureBox))
                {
                    imagen = convertirImagen((PictureBox)c);
                }
            }

            string id = textBoxNombreQuiz.Text + "_" + numeroDePregunta;

            Pregunta pregunta = new PreguntaVF(enunciado, id, imagen, puntuacion, explicacion);
            Respuesta r = pregunta.crearRespuesta(enunciado);
            pregunta.añadirRespuesta(r);

            preguntas.Add(pregunta);

            MessageBox.Show("Se ha insertado una pregunta: ");
        }
        private List<TextBox> getListaRespuestas()
        {
            List<TextBox> respuestas = new List<TextBox>();
            ControlCollection objetosDelFormulario = (ControlCollection)panelQuizes.Controls;
            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox aux = (TextBox)c;
                    respuestas.Add(aux);
                }
            }

            return respuestas;
        }

        public string convertirImagen(PictureBox picture)
        {
            string imagen = "";
            MemoryStream ms = new MemoryStream();
            picture.Image.Save(ms,ImageFormat.Jpeg);
            byte[] aux = ms.GetBuffer();

            imagen = Convert.ToBase64String(aux);
            
            return imagen;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void respuestaAbierta_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tipoDeQuiz = "Respuesta Abierta";
            multiopcion.Visible = false;
            multiopcion.Dock = DockStyle.None;
            verdaderoFalso.Visible = false;
            verdaderoFalso.Dock = DockStyle.None;
            respuestaAbierta.Visible = false;
            respuestaAbierta.Dock = DockStyle.None;


            panelQuizes.Controls.Clear();
            panelQuizes.Dock = DockStyle.Fill;
            panelQuizes.Controls.Add(formAb);
            formularioActual = formAb;
            formAb.Show();

            Cursor.Current = Cursors.Default;
        }

        private void verdaderoFalso_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tipoDeQuiz = "Verdadero/Falso";
            multiopcion.Visible = false;
            multiopcion.Dock = DockStyle.None;
            verdaderoFalso.Visible = false;
            verdaderoFalso.Dock = DockStyle.None;
            respuestaAbierta.Visible = false;
            respuestaAbierta.Dock = DockStyle.None;

            panelQuizes.Controls.Clear();
            panelQuizes.Dock = DockStyle.Fill;
            panelQuizes.Controls.Add(formVF);
            formularioActual = formVF;
            formVF.Show();
            Cursor.Current = Cursors.Default;
        }

        private void multiopcion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tipoDeQuiz = "MultiOpcion";
            multiopcion.Visible = false;
            multiopcion.Dock = DockStyle.None;
            verdaderoFalso.Visible = false;
            verdaderoFalso.Dock = DockStyle.None;
            respuestaAbierta.Visible = false;
            respuestaAbierta.Dock = DockStyle.None;


            panelQuizes.Controls.Clear();
            panelQuizes.Dock = DockStyle.Fill;
            panelQuizes.Controls.Add(formMO);
            formularioActual = formMO;
            formMO.Show();
            Cursor.Current = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

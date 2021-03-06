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
        MyQuizifyServices servicio = new MyQuizifyServices();

        Quiz quizActual;
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
            Cursor.Current = Cursors.WaitCursor;
            int pesoQuiz = Int32.Parse(textBoxPeso.Text);
            string nombreQuiz = textBoxNombreQuiz.Text;
            
            string dificultad = comboBoxDificultad.Text;
            int horas = Int32.Parse(textBoxHoras.Text) * 60;
            int duracion = horas + Int32.Parse(textBoxMin.Text);
            if (pesoQuiz < 5 || pesoQuiz > 65)
            {
                MessageBox.Show("El peso del quiz debe estar entre 5% y 65%");
            }
            else
            {
                if (tipoDeQuiz == "MultiOpcion")
                {
                    quizActual = new QuizMO(nombreQuiz, servicio.getInstructorById(cf.usuarioConectado.username),
                        duracion, pesoQuiz, dificultad, dateTimePickerInicio.Value, dateTimePickerFin.Value, "En preparacion", servicio.getCursoById(comboBoxCursos.Text));
                    AñadirPreguntas(quizActual);
                }
                else if (tipoDeQuiz == "Verdadero/Falso")
                {
                    quizActual = new QuizVF(nombreQuiz, servicio.getInstructorById(cf.usuarioConectado.username),
                       duracion, pesoQuiz, dificultad, dateTimePickerInicio.Value, dateTimePickerFin.Value, "En preparacion", servicio.getCursoById(comboBoxCursos.Text));
                    AñadirPreguntas(quizActual);
                }
                else if (tipoDeQuiz == "Respuesta Abierta")
                {
                    quizActual = new QuizPA(nombreQuiz, servicio.getInstructorById(cf.usuarioConectado.username),
                       duracion, pesoQuiz, dificultad, dateTimePickerInicio.Value, dateTimePickerFin.Value, "En preparacion", servicio.getCursoById(comboBoxCursos.Text));
                    AñadirPreguntas(quizActual);
                }
                MessageBox.Show("Quiz creado: " + quizActual.ToString());
            }
            Cursor.Current = Cursors.Default;

        }
        private void AñadirPreguntas(Quiz q)
        {
            foreach(Pregunta p in preguntas)
            {
                q.añadirPregunta(p.id,p.enunciado,p.imagen, p.puntuacion, p.explicacion);
            }
        }

        private void panelQuizes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonAñadirPregunta_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (tipoDeQuiz == "MultiOpcion")
            {
                CrearPreguntaTipoTest();
                panelQuizes.Controls.Clear();
                abrirMultiopcion();
            }
            else if (tipoDeQuiz == "Verdadero/Falso")
            {
                CrearPreguntaVerdaderoFalso();
                panelQuizes.Controls.Clear();
                abrirVerdaderoFalso();
            }
            else if (tipoDeQuiz == "Respuesta Abierta")
            {
                CrearPreguntaRespuestaAbierta();
                panelQuizes.Controls.Clear();
                abrirRespuestaAbierta();
            }
            numeroDePregunta++;
            Cursor.Current = Cursors.Default;

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
                
                if (c.GetType() == typeof(TextBox))
                {
                    if (c.Name == "textBoxEnunciado")
                    {
                        enunciado = ((TextBox)c).Text;
                    }

                }
                else if(c is Panel)
                {
                    foreach (Control p in c.Controls)
                    {
                        if (p.GetType() == typeof(TextBox))
                        {
                             if (p.Name == "textBoxPuntuacion")
                            {
                                puntuacion = Double.Parse(((TextBox)p).Text);
                            }
                            else if (p.Name == "textboxExplicacion")
                            {
                                explicacion = ((TextBox)p).Text;
                            }
                        }
                        else if (p.GetType() == typeof(RadioButton))
                        {
                            RadioButton aux = (RadioButton)p;
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
                    }
                }
                else if (c.GetType() == typeof(PictureBox))
                {
                    
                    imagen = convertirImagen((PictureBox)c);
                }
            }

            string id = textBoxNombreQuiz.Text + "_" + numeroDePregunta; 

            Pregunta pregunta = new PreguntaVF(id,enunciado,imagen,puntuacion,explicacion);
           
            //Mirar esto no funciona por el añadir respuesta pide un string y no una respuesta
            Respuesta r = pregunta.crearRespuesta(verdaderoOFalso.ToString());
            r.inicialize(verdaderoOFalso);
            pregunta.añadirRespuesta(verdaderoOFalso.ToString());
            preguntas.Add(pregunta);

            MessageBox.Show("Se ha insertado una pregunta: " + pregunta.ToString()) ;
        }

        public void CrearPreguntaTipoTest()
        {
            List<TextBox> listaRespuestas = getListaRespuestas();
            List<RadioButton> listaChecRadioBtn = getListaRadioBtn();
            ControlCollection objetosDelFormulario = (ControlCollection)formularioActual.Controls;
            List<Respuesta> respuestas = new List<Respuesta>();
            string enunciado = "";

            Respuesta resp;
            
            string imagen = "";
            double puntuacion = 0.0;
            string explicacion = "";
            Pregunta pregunta;
            foreach (Control c in objetosDelFormulario)
            {
                
                        
                 if (c.GetType() == typeof(TextBox))
                {
                    if (c.Name == "enunciadoTipoTest")
                    {
                        enunciado = ((TextBox)c).Text;
                    }

                }
                else if (c is Panel)
                {
                   
                    foreach (Control p in c.Controls)
                    {
                        if (p.GetType() == typeof(TextBox))
                        {
                            if (p.Name == "textBoxPuntuacion")
                            {
                                puntuacion = Double.Parse(((TextBox)p).Text);
                            }
                            else if (p.Name == "textboxExplicacion")
                            {
                                explicacion = ((TextBox)p).Text;
                            }
                        }
                    }
                }
                else if (c.GetType() == typeof(PictureBox))
                {
                    imagen = convertirImagen((PictureBox)c);
                }

            }
            foreach (TextBox t in listaRespuestas)
            {
                if (t.Name == "textBoxPuntuacion")
                {
                puntuacion = Double.Parse(t.Text);
                }
                else if (t.Name == "textboxExplicacion")
                {
                explicacion = t.Text;
                }
                
                else if (t.Name == "textPregunta1")
                {
                    resp = new RespuestaMO(t.Text);
                    foreach (RadioButton check in listaChecRadioBtn)
                    {
                        if (check.Name== "ckeckPregunta1")
                        {
                            if(check.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                        }
                    }
                    respuestas.Add(resp);
                }
                else if (t.Name == "textPregunta2")
                {
                    resp = new RespuestaMO(t.Text);
                    foreach (RadioButton check in listaChecRadioBtn)
                    {
                        if (check.Name == "ckeckPregunta2")
                        {
                            if (check.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                        }
                    }
                    respuestas.Add(resp);
                }
                else if(t.Name == "textPregunta3")
                {
                    resp = new RespuestaMO(t.Text);
                    foreach (RadioButton check in listaChecRadioBtn)
                    {
                        if (check.Name == "ckeckPregunta3")
                        {
                            if (check.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                        }
                    }
                    respuestas.Add(resp);
                }
                else if(t.Name == "textPregunta4")
                {
                    resp = new RespuestaMO(t.Text);
                    foreach (RadioButton check in listaChecRadioBtn)
                    {
                        if (check.Name == "ckeckPregunta4")
                        {
                            if (check.Checked) { resp.inicialize(true); } else { resp.inicialize(false); }
                        }
                    }
                    respuestas.Add(resp);
                }
            }
            string id = textBoxNombreQuiz.Text + "_" + numeroDePregunta;

            pregunta = new PreguntaMO(id,enunciado, imagen, puntuacion, explicacion);
            añadirRespuestas(respuestas,pregunta);
            preguntas.Add(pregunta);

            MessageBox.Show("Se ha insertado una pregunta: " + pregunta.ToString());
        }

        public void CrearPreguntaRespuestaAbierta()
        {
            ControlCollection objetosDelFormulario = (ControlCollection)formularioActual.Controls;
            string enunciado = "";
            string respuesta = "";
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
                    else if (c.Name == "textBoxResp")
                    {
                        respuesta = ((TextBox)c).Text;
                    }
                }
                else if (c is Panel)
                {
                    foreach (Control p in c.Controls)
                    {
                        if (p.GetType() == typeof(TextBox))
                        {
                            if (p.Name == "textBoxPuntuacion")
                            {
                                puntuacion = Double.Parse(((TextBox)p).Text);
                            }
                            else if (p.Name == "textboxExplicacion")
                            {
                                explicacion = ((TextBox)p).Text;
                            }
                        }
                    }
                }
                else if (c.GetType() == typeof(PictureBox))
                {
                    imagen = convertirImagen((PictureBox)c);
                }
            }

            string id = textBoxNombreQuiz.Text + "_" + numeroDePregunta;

            Pregunta pregunta = new PreguntaA(id,enunciado, imagen, puntuacion, explicacion);
            Respuesta r = pregunta.crearRespuesta(respuesta);
            pregunta.añadirRespuesta(respuesta);

            preguntas.Add(pregunta);
            MessageBox.Show("Se ha insertado una respuesta: " + r.ToString());
            MessageBox.Show("Se ha insertado una pregunta: " + pregunta.ToString()) ;
        }
        private void añadirRespuestas(List<Respuesta> respuestas, Pregunta p)
        {
            foreach(Respuesta r in respuestas)
            {
                p.añadirRespuesta(r.enunciado);
            }
        }
        private List<TextBox> getListaRespuestas()
        {
            List<TextBox> respuestas = new List<TextBox>();
            ControlCollection objetosDelFormulario = (ControlCollection)formularioActual.Controls;
            foreach (Control c in objetosDelFormulario)
            {   
                    if (c is Panel)
                        {
                            foreach (Control t in c.Controls)
                            {
                                if (t.GetType() == typeof(TextBox))
                                {
                                    TextBox aux = (TextBox)t;
                                    respuestas.Add(aux);
                                }
                            }
                        }
                    
                    
            }
            return respuestas;
        }
        private List<RadioButton> getListaRadioBtn()
        {
            List<RadioButton> respuestas = new List<RadioButton>();
            ControlCollection objetosDelFormulario = (ControlCollection)formularioActual.Controls;
            foreach (Control c in objetosDelFormulario)
            {
                if (c is Panel)
                {
                    foreach (Control t in c.Controls)
                    {
                        if (t.GetType() == typeof(RadioButton))
                        {
                            RadioButton aux = (RadioButton)t;
                            respuestas.Add(aux);
                        }
                    }
                }


            }
            return respuestas;
        }
        public string convertirImagen(PictureBox picture)
        {
            if (picture.Image == null) return "";
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

        public void abrirRespuestaAbierta()
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
        public void abrirVerdaderoFalso()
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
        public void abrirMultiopcion()
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
        private void respuestaAbierta_Click(object sender, EventArgs e)
        {
            abrirRespuestaAbierta();
        }

        private void verdaderoFalso_Click(object sender, EventArgs e)
        {
            abrirVerdaderoFalso();
        }

        private void multiopcion_Click(object sender, EventArgs e)
        {
            abrirMultiopcion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

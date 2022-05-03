using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms.InicioSesion
{
    public partial class InicioInstructor : Form
    {
        public InicioInstructor()
        {
            InitializeComponent();
        }
        private void abrirFormHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopMost = true;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Width = panelContenedor.Width;
            formularioHijo.Height = panelContenedor.Height;
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new QuizesActivos()) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CursosInstructor());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CreacionDeQuizes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //abrirFormHijo(new CrearPreguntasBaterias());
        }
    }
}

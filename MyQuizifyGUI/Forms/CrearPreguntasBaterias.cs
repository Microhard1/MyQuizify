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
    public partial class CrearPreguntasBaterias : Form
    {
        private CrearBateria cb;
        public CrearPreguntasBaterias()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrearBateria cb = new CrearBateria();
            cb.TopLevel = false;
            cb.Width = panelForms.Width;
            cb.Height = panelForms.Height;
            panelForms.Controls.Add(cb);
            cb.Show();
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

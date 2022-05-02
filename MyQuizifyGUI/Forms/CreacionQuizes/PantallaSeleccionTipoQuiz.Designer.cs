
namespace MyQuizifyGUI.Forms.CreacionQuizes
{
    partial class PantallaSeleccionTipoQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.respuestaAbierta = new System.Windows.Forms.Button();
            this.verdaderoFalso = new System.Windows.Forms.Button();
            this.multiopcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // respuestaAbierta
            // 
            this.respuestaAbierta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.respuestaAbierta.Dock = System.Windows.Forms.DockStyle.Top;
            this.respuestaAbierta.Location = new System.Drawing.Point(0, 0);
            this.respuestaAbierta.Name = "respuestaAbierta";
            this.respuestaAbierta.Size = new System.Drawing.Size(961, 103);
            this.respuestaAbierta.TabIndex = 0;
            this.respuestaAbierta.Text = "Respuesta Abierta";
            this.respuestaAbierta.UseVisualStyleBackColor = false;
            this.respuestaAbierta.Click += new System.EventHandler(this.respuestaAbierta_Click);
            // 
            // verdaderoFalso
            // 
            this.verdaderoFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.verdaderoFalso.Dock = System.Windows.Forms.DockStyle.Top;
            this.verdaderoFalso.Location = new System.Drawing.Point(0, 103);
            this.verdaderoFalso.Name = "verdaderoFalso";
            this.verdaderoFalso.Size = new System.Drawing.Size(961, 103);
            this.verdaderoFalso.TabIndex = 1;
            this.verdaderoFalso.Text = "Verdadero/Falso";
            this.verdaderoFalso.UseVisualStyleBackColor = false;
            this.verdaderoFalso.Click += new System.EventHandler(this.verdaderoFalso_Click);
            // 
            // multiopcion
            // 
            this.multiopcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.multiopcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.multiopcion.Location = new System.Drawing.Point(0, 206);
            this.multiopcion.Name = "multiopcion";
            this.multiopcion.Size = new System.Drawing.Size(961, 103);
            this.multiopcion.TabIndex = 2;
            this.multiopcion.Text = "Multiopción";
            this.multiopcion.UseVisualStyleBackColor = false;
            this.multiopcion.Click += new System.EventHandler(this.multiopcion_Click);
            // 
            // PantallaSeleccionTipoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 313);
            this.Controls.Add(this.multiopcion);
            this.Controls.Add(this.verdaderoFalso);
            this.Controls.Add(this.respuestaAbierta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaSeleccionTipoQuiz";
            this.Text = "PantallaSeleccionTipoQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button respuestaAbierta;
        private System.Windows.Forms.Button verdaderoFalso;
        private System.Windows.Forms.Button multiopcion;
    }
}
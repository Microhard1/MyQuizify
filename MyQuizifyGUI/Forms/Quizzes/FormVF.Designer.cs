
namespace MyQuizifyGUI.Forms
{
    partial class FormVF
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
            this.textBoxEnunciado = new System.Windows.Forms.TextBox();
            this.inputImagen = new System.Windows.Forms.PictureBox();
            this.panelVerdadero = new System.Windows.Forms.Panel();
            this.botonVerdadero = new System.Windows.Forms.RadioButton();
            this.panelFalso = new System.Windows.Forms.Panel();
            this.botonFalso = new System.Windows.Forms.RadioButton();
            this.botonAñadirImagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxExplicacion = new System.Windows.Forms.TextBox();
            this.textBoxPuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).BeginInit();
            this.panelVerdadero.SuspendLayout();
            this.panelFalso.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnunciado
            // 
            this.textBoxEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnunciado.ForeColor = System.Drawing.Color.Black;
            this.textBoxEnunciado.Location = new System.Drawing.Point(42, 32);
            this.textBoxEnunciado.Multiline = true;
            this.textBoxEnunciado.Name = "textBoxEnunciado";
            this.textBoxEnunciado.Size = new System.Drawing.Size(554, 82);
            this.textBoxEnunciado.TabIndex = 1;
            this.textBoxEnunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputImagen
            // 
            this.inputImagen.Location = new System.Drawing.Point(224, 132);
            this.inputImagen.Name = "inputImagen";
            this.inputImagen.Size = new System.Drawing.Size(203, 140);
            this.inputImagen.TabIndex = 5;
            this.inputImagen.TabStop = false;
            this.inputImagen.Click += new System.EventHandler(this.inputImagen_Click);
            // 
            // panelVerdadero
            // 
            this.panelVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelVerdadero.Controls.Add(this.botonVerdadero);
            this.panelVerdadero.Location = new System.Drawing.Point(42, 311);
            this.panelVerdadero.Name = "panelVerdadero";
            this.panelVerdadero.Size = new System.Drawing.Size(263, 90);
            this.panelVerdadero.TabIndex = 6;
            // 
            // botonVerdadero
            // 
            this.botonVerdadero.AutoSize = true;
            this.botonVerdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botonVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerdadero.Location = new System.Drawing.Point(48, 33);
            this.botonVerdadero.Name = "botonVerdadero";
            this.botonVerdadero.Size = new System.Drawing.Size(156, 28);
            this.botonVerdadero.TabIndex = 2;
            this.botonVerdadero.Text = "VERDADERO";
            this.botonVerdadero.UseVisualStyleBackColor = false;
            this.botonVerdadero.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panelFalso
            // 
            this.panelFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFalso.Controls.Add(this.botonFalso);
            this.panelFalso.Location = new System.Drawing.Point(401, 311);
            this.panelFalso.Name = "panelFalso";
            this.panelFalso.Size = new System.Drawing.Size(261, 90);
            this.panelFalso.TabIndex = 7;
            this.panelFalso.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFalso_Paint);
            // 
            // botonFalso
            // 
            this.botonFalso.AutoSize = true;
            this.botonFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botonFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFalso.Location = new System.Drawing.Point(82, 33);
            this.botonFalso.Name = "botonFalso";
            this.botonFalso.Size = new System.Drawing.Size(95, 28);
            this.botonFalso.TabIndex = 2;
            this.botonFalso.Text = "FALSO";
            this.botonFalso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonFalso.UseVisualStyleBackColor = false;
            this.botonFalso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // botonAñadirImagen
            // 
            this.botonAñadirImagen.Location = new System.Drawing.Point(254, 426);
            this.botonAñadirImagen.Name = "botonAñadirImagen";
            this.botonAñadirImagen.Size = new System.Drawing.Size(146, 39);
            this.botonAñadirImagen.TabIndex = 8;
            this.botonAñadirImagen.Text = "Añadir imagen";
            this.botonAñadirImagen.UseVisualStyleBackColor = true;
            this.botonAñadirImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Escriba el enunciado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Explicación (opcional):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textboxExplicacion
            // 
            this.textboxExplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxExplicacion.ForeColor = System.Drawing.Color.Black;
            this.textboxExplicacion.Location = new System.Drawing.Point(26, 167);
            this.textboxExplicacion.Multiline = true;
            this.textboxExplicacion.Name = "textboxExplicacion";
            this.textboxExplicacion.Size = new System.Drawing.Size(131, 286);
            this.textboxExplicacion.TabIndex = 12;
            this.textboxExplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPuntuacion
            // 
            this.textBoxPuntuacion.Location = new System.Drawing.Point(26, 49);
            this.textBoxPuntuacion.Name = "textBoxPuntuacion";
            this.textBoxPuntuacion.Size = new System.Drawing.Size(131, 20);
            this.textBoxPuntuacion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuacion :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPuntuacion);
            this.panel1.Controls.Add(this.textboxExplicacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(690, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 477);
            this.panel1.TabIndex = 14;
            // 
            // FormVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFalso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelVerdadero);
            this.Controls.Add(this.botonAñadirImagen);
            this.Controls.Add(this.inputImagen);
            this.Controls.Add(this.textBoxEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVF";
            this.Text = "FormVF";
            this.Load += new System.EventHandler(this.FormVF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputImagen)).EndInit();
            this.panelVerdadero.ResumeLayout(false);
            this.panelVerdadero.PerformLayout();
            this.panelFalso.ResumeLayout(false);
            this.panelFalso.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnunciado;
        private System.Windows.Forms.PictureBox inputImagen;
        private System.Windows.Forms.Panel panelVerdadero;
        private System.Windows.Forms.RadioButton botonVerdadero;
        private System.Windows.Forms.Panel panelFalso;
        private System.Windows.Forms.RadioButton botonFalso;
        private System.Windows.Forms.Button botonAñadirImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxExplicacion;
        private System.Windows.Forms.TextBox textBoxPuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
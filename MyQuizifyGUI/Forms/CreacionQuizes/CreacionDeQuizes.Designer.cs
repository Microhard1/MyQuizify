﻿
namespace MyQuizifyGUI.Forms
{
    partial class CreacionDeQuizes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonAñadirPregunta = new System.Windows.Forms.Button();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.textBoxNombreQuiz = new System.Windows.Forms.TextBox();
            this.panelQuizes = new System.Windows.Forms.Panel();
            this.multiopcion = new System.Windows.Forms.Button();
            this.verdaderoFalso = new System.Windows.Forms.Button();
            this.respuestaAbierta = new System.Windows.Forms.Button();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1323, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creacion de quizzes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.comboBoxDificultad);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.botonAñadirPregunta);
            this.panel1.Controls.Add(this.textBoxPeso);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePickerFin);
            this.panel1.Controls.Add(this.dateTimePickerInicio);
            this.panel1.Controls.Add(this.textBoxMin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxCursos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxHoras);
            this.panel1.Controls.Add(this.textBoxNombreQuiz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1095, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 650);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // botonAñadirPregunta
            // 
            this.botonAñadirPregunta.Location = new System.Drawing.Point(39, 446);
            this.botonAñadirPregunta.Margin = new System.Windows.Forms.Padding(4);
            this.botonAñadirPregunta.Name = "botonAñadirPregunta";
            this.botonAñadirPregunta.Size = new System.Drawing.Size(152, 55);
            this.botonAñadirPregunta.TabIndex = 18;
            this.botonAñadirPregunta.Text = "Añadir Pregunta";
            this.botonAñadirPregunta.UseVisualStyleBackColor = true;
            this.botonAñadirPregunta.Click += new System.EventHandler(this.botonAñadirPregunta_Click);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(112, 181);
            this.textBoxPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(96, 22);
            this.textBoxPeso.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Peso:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(107)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 562);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Crear Quiz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de fin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de inicio :";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(38, 380);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(169, 22);
            this.dateTimePickerFin.TabIndex = 10;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(38, 324);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(169, 22);
            this.dateTimePickerInicio.TabIndex = 9;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(112, 246);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(96, 22);
            this.textBoxMin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minutos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas :";
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(111, 111);
            this.comboBoxCursos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(96, 24);
            this.comboBoxCursos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = " Curso :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del quiz :";
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(112, 214);
            this.textBoxHoras.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(96, 22);
            this.textBoxHoras.TabIndex = 2;
            // 
            // textBoxNombreQuiz
            // 
            this.textBoxNombreQuiz.Location = new System.Drawing.Point(35, 66);
            this.textBoxNombreQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreQuiz.Name = "textBoxNombreQuiz";
            this.textBoxNombreQuiz.Size = new System.Drawing.Size(172, 22);
            this.textBoxNombreQuiz.TabIndex = 0;
            // 
            // panelQuizes
            // 
            this.panelQuizes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelQuizes.Location = new System.Drawing.Point(0, 100);
            this.panelQuizes.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuizes.Name = "panelQuizes";
            this.panelQuizes.Size = new System.Drawing.Size(1095, 650);
            this.panelQuizes.TabIndex = 3;
            this.panelQuizes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuizes_Paint);
            // 
            // multiopcion
            // 
            this.multiopcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.multiopcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiopcion.Location = new System.Drawing.Point(26, 515);
            this.multiopcion.Name = "multiopcion";
            this.multiopcion.Size = new System.Drawing.Size(1072, 208);
            this.multiopcion.TabIndex = 6;
            this.multiopcion.Text = "Multiopción";
            this.multiopcion.UseVisualStyleBackColor = false;
            this.multiopcion.Click += new System.EventHandler(this.multiopcion_Click);
            // 
            // verdaderoFalso
            // 
            this.verdaderoFalso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.verdaderoFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verdaderoFalso.Location = new System.Drawing.Point(26, 301);
            this.verdaderoFalso.Name = "verdaderoFalso";
            this.verdaderoFalso.Size = new System.Drawing.Size(1072, 216);
            this.verdaderoFalso.TabIndex = 5;
            this.verdaderoFalso.Text = "Verdadero/Falso";
            this.verdaderoFalso.UseVisualStyleBackColor = false;
            this.verdaderoFalso.Click += new System.EventHandler(this.verdaderoFalso_Click);
            // 
            // respuestaAbierta
            // 
            this.respuestaAbierta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.respuestaAbierta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuestaAbierta.Location = new System.Drawing.Point(26, 100);
            this.respuestaAbierta.Name = "respuestaAbierta";
            this.respuestaAbierta.Size = new System.Drawing.Size(1072, 198);
            this.respuestaAbierta.TabIndex = 4;
            this.respuestaAbierta.Text = "Respuesta Abierta";
            this.respuestaAbierta.UseVisualStyleBackColor = false;
            this.respuestaAbierta.Click += new System.EventHandler(this.respuestaAbierta_Click);
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(112, 143);
            this.comboBoxDificultad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(96, 24);
            this.comboBoxDificultad.TabIndex = 20;
            this.comboBoxDificultad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dificultad:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CreacionDeQuizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 750);
            this.Controls.Add(this.multiopcion);
            this.Controls.Add(this.verdaderoFalso);
            this.Controls.Add(this.respuestaAbierta);
            this.Controls.Add(this.panelQuizes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreacionDeQuizes";
            this.Text = "CreacionDeQuizes";
            this.Load += new System.EventHandler(this.CreacionDeQuizes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelQuizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.TextBox textBoxNombreQuiz;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botonAñadirPregunta;
        private System.Windows.Forms.Button multiopcion;
        private System.Windows.Forms.Button verdaderoFalso;
        private System.Windows.Forms.Button respuestaAbierta;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.Label label8;
    }
}
﻿
namespace MyQuizifyGUI
{
    partial class CrearQuiz
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPreguntas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ColumnaSelecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "botonCrear";
            this.button1.Location = new System.Drawing.Point(671, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "dateTimePickerInicio";
            this.dateTimePicker1.Location = new System.Drawing.Point(569, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleName = "dateTimePickerFin";
            this.dateTimePicker2.Location = new System.Drawing.Point(569, 120);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AccessibleName = "fechaInicio";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AccessibleName = "fechaFin";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Fin";
            // 
            // dataGridPreguntas
            // 
            this.dataGridPreguntas.AccessibleName = "dataGridPreguntas";
            this.dataGridPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaSelecciona});
            this.dataGridPreguntas.Location = new System.Drawing.Point(33, 58);
            this.dataGridPreguntas.Name = "dataGridPreguntas";
            this.dataGridPreguntas.Size = new System.Drawing.Size(498, 354);
            this.dataGridPreguntas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AccessibleName = "labelPreguntasQuiz";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preguntas del Quiz";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "textBoxMin";
            this.textBox1.Location = new System.Drawing.Point(702, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "textBoxHora";
            this.textBox2.Location = new System.Drawing.Point(613, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AccessibleName = "labelHora";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horas:";
            // 
            // label5
            // 
            this.label5.AccessibleName = "labelMin";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "min:";
            // 
            // label6
            // 
            this.label6.AccessibleName = "labelDuracion";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Duracion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre del QUIZ";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "textBoxNombreQuiz";
            this.textBox3.Location = new System.Drawing.Point(569, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AccessibleName = "labelDificultad";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dificultad:";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "textBoxDificultad";
            this.textBox4.Location = new System.Drawing.Point(569, 301);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // ColumnaSelecciona
            // 
            this.ColumnaSelecciona.HeaderText = "Selecciona";
            this.ColumnaSelecciona.Name = "ColumnaSelecciona";
            // 
            // CrearQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridPreguntas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "CrearQuiz";
            this.Text = "CrearQuiz";
            this.Load += new System.EventHandler(this.CrearQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPreguntas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnaSelecciona;
    }
}
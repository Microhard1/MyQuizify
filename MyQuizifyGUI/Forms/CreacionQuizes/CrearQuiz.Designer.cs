
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
            this.textBoxMinutos = new System.Windows.Forms.TextBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNombreQuiz = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDificultad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.dateTimePicker2.Location = new System.Drawing.Point(569, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AccessibleName = "fechaInicio";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AccessibleName = "fechaFin";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Fin";
            // 
            // dataGridPreguntas
            // 
            this.dataGridPreguntas.AccessibleName = "dataGridPreguntas";
            this.dataGridPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreguntas.Location = new System.Drawing.Point(33, 67);
            this.dataGridPreguntas.Name = "dataGridPreguntas";
            this.dataGridPreguntas.Size = new System.Drawing.Size(498, 354);
            this.dataGridPreguntas.TabIndex = 5;
            // 
            // textBoxMinutos
            // 
            this.textBoxMinutos.AccessibleName = "textBoxMin";
            this.textBoxMinutos.Location = new System.Drawing.Point(700, 158);
            this.textBoxMinutos.Name = "textBoxMinutos";
            this.textBoxMinutos.Size = new System.Drawing.Size(46, 20);
            this.textBoxMinutos.TabIndex = 7;
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.AccessibleName = "textBoxHora";
            this.textBoxHoras.Location = new System.Drawing.Point(610, 158);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(46, 20);
            this.textBoxHoras.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AccessibleName = "labelHora";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horas:";
            // 
            // label5
            // 
            this.label5.AccessibleName = "labelMin";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "min:";
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
            // textBoxNombreQuiz
            // 
            this.textBoxNombreQuiz.AccessibleName = "textBoxNombreQuiz";
            this.textBoxNombreQuiz.Location = new System.Drawing.Point(569, 248);
            this.textBoxNombreQuiz.Name = "textBoxNombreQuiz";
            this.textBoxNombreQuiz.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreQuiz.TabIndex = 13;
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
            // textBoxDificultad
            // 
            this.textBoxDificultad.AccessibleName = "textBoxDificultad";
            this.textBoxDificultad.Location = new System.Drawing.Point(569, 301);
            this.textBoxDificultad.Name = "textBoxDificultad";
            this.textBoxDificultad.Size = new System.Drawing.Size(100, 20);
            this.textBoxDificultad.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Peso :";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.AccessibleName = "textBoxHora";
            this.textBoxPeso.Location = new System.Drawing.Point(610, 187);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(46, 20);
            this.textBoxPeso.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Baterias MultiOpcion",
            "Baterias Verdadero/Falso",
            "Baterias Abiertas",
            "Preguntas MultiOpcion",
            "Preguntas Abiertas",
            "Preguntas Verdadero/Falso"});
            this.comboBox1.Location = new System.Drawing.Point(410, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Filtrar por : ";
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(685, 300);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(84, 21);
            this.comboBoxCurso.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Curso : ";
            // 
            // CrearQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDificultad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNombreQuiz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.textBoxMinutos);
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
        private System.Windows.Forms.TextBox textBoxMinutos;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNombreQuiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDificultad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label label9;
    }
}
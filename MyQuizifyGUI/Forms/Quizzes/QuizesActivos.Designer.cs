
namespace MyQuizifyGUI
{
    partial class QuizesActivos
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
            this.dataGridQuizes = new System.Windows.Forms.DataGridView();
            this.Selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonPreparado = new System.Windows.Forms.Button();
            this.botonCompleto = new System.Windows.Forms.Button();
            this.botonLanzado = new System.Windows.Forms.Button();
            this.botonCancelado = new System.Windows.Forms.Button();
            this.botonTerminado = new System.Windows.Forms.Button();
            this.botonRPublicados = new System.Windows.Forms.Button();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btbClonarQuiz = new System.Windows.Forms.Button();
            this.btbEstadisticasQuiz = new System.Windows.Forms.Button();
            this.botonCargarQuizes = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuizes
            // 
            this.dataGridQuizes.AccessibleName = "DataGridQuizesActivos";
            this.dataGridQuizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona});
            this.dataGridQuizes.Location = new System.Drawing.Point(48, 170);
            this.dataGridQuizes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridQuizes.Name = "dataGridQuizes";
            this.dataGridQuizes.RowHeadersWidth = 51;
            this.dataGridQuizes.Size = new System.Drawing.Size(1264, 389);
            this.dataGridQuizes.TabIndex = 0;
            this.dataGridQuizes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQuizes_CellContentClick);
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Selecciona";
            this.Selecciona.MinimumWidth = 6;
            this.Selecciona.Name = "Selecciona";
            this.Selecciona.Width = 125;
            // 
            // label1
            // 
            this.label1.AccessibleName = "labelQuizesActivos";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quizes activos";
            // 
            // button1
            // 
            this.button1.AccessibleName = "botonCrearQuiz";
            this.button1.Location = new System.Drawing.Point(48, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonPreparado
            // 
            this.botonPreparado.Location = new System.Drawing.Point(1320, 229);
            this.botonPreparado.Margin = new System.Windows.Forms.Padding(4);
            this.botonPreparado.Name = "botonPreparado";
            this.botonPreparado.Size = new System.Drawing.Size(177, 28);
            this.botonPreparado.TabIndex = 3;
            this.botonPreparado.Text = "En preparacion";
            this.botonPreparado.UseVisualStyleBackColor = true;
            this.botonPreparado.Click += new System.EventHandler(this.botonPreparado_Click);
            // 
            // botonCompleto
            // 
            this.botonCompleto.Location = new System.Drawing.Point(1320, 277);
            this.botonCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.botonCompleto.Name = "botonCompleto";
            this.botonCompleto.Size = new System.Drawing.Size(177, 28);
            this.botonCompleto.TabIndex = 4;
            this.botonCompleto.Text = "Completo";
            this.botonCompleto.UseVisualStyleBackColor = true;
            this.botonCompleto.Click += new System.EventHandler(this.botonCompleto_Click);
            // 
            // botonLanzado
            // 
            this.botonLanzado.Location = new System.Drawing.Point(1320, 326);
            this.botonLanzado.Margin = new System.Windows.Forms.Padding(4);
            this.botonLanzado.Name = "botonLanzado";
            this.botonLanzado.Size = new System.Drawing.Size(177, 28);
            this.botonLanzado.TabIndex = 5;
            this.botonLanzado.Text = "Lanzado";
            this.botonLanzado.UseVisualStyleBackColor = true;
            this.botonLanzado.Click += new System.EventHandler(this.botonLanzado_Click);
            // 
            // botonCancelado
            // 
            this.botonCancelado.Location = new System.Drawing.Point(1320, 380);
            this.botonCancelado.Margin = new System.Windows.Forms.Padding(4);
            this.botonCancelado.Name = "botonCancelado";
            this.botonCancelado.Size = new System.Drawing.Size(177, 28);
            this.botonCancelado.TabIndex = 6;
            this.botonCancelado.Text = "Cancelado";
            this.botonCancelado.UseVisualStyleBackColor = true;
            this.botonCancelado.Click += new System.EventHandler(this.botonCancelado_Click);
            // 
            // botonTerminado
            // 
            this.botonTerminado.Location = new System.Drawing.Point(1320, 437);
            this.botonTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.botonTerminado.Name = "botonTerminado";
            this.botonTerminado.Size = new System.Drawing.Size(177, 28);
            this.botonTerminado.TabIndex = 7;
            this.botonTerminado.Text = "Terminado";
            this.botonTerminado.UseVisualStyleBackColor = true;
            this.botonTerminado.Click += new System.EventHandler(this.botonTerminado_Click);
            // 
            // botonRPublicados
            // 
            this.botonRPublicados.Location = new System.Drawing.Point(1320, 486);
            this.botonRPublicados.Margin = new System.Windows.Forms.Padding(4);
            this.botonRPublicados.Name = "botonRPublicados";
            this.botonRPublicados.Size = new System.Drawing.Size(177, 28);
            this.botonRPublicados.TabIndex = 8;
            this.botonRPublicados.Text = "Resultados publicados";
            this.botonRPublicados.UseVisualStyleBackColor = true;
            this.botonRPublicados.Click += new System.EventHandler(this.botonRPublicados_Click);
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "En preparacion",
            "Lanzado",
            "Cancelado",
            "Terminado",
            "Completo",
            "Resultados publicados"});
            this.comboBoxEstados.Location = new System.Drawing.Point(1008, 101);
            this.comboBoxEstados.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEstados.TabIndex = 9;
            this.comboBoxEstados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1320, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cambiar estado a:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1105, 590);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ver resultados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbClonarQuiz
            // 
            this.btbClonarQuiz.AccessibleName = "botonCrearQuiz";
            this.btbClonarQuiz.Location = new System.Drawing.Point(181, 590);
            this.btbClonarQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.btbClonarQuiz.Name = "btbClonarQuiz";
            this.btbClonarQuiz.Size = new System.Drawing.Size(125, 59);
            this.btbClonarQuiz.TabIndex = 13;
            this.btbClonarQuiz.Text = "Clonar Quizes";
            this.btbClonarQuiz.UseVisualStyleBackColor = true;
            this.btbClonarQuiz.Click += new System.EventHandler(this.btbClonarQuiz_Click);
            // 
            // btbEstadisticasQuiz
            // 
            this.btbEstadisticasQuiz.AccessibleName = "botonEstadisticasQuiz";
            this.btbEstadisticasQuiz.Location = new System.Drawing.Point(313, 590);
            this.btbEstadisticasQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.btbEstadisticasQuiz.Name = "btbEstadisticasQuiz";
            this.btbEstadisticasQuiz.Size = new System.Drawing.Size(125, 59);
            this.btbEstadisticasQuiz.TabIndex = 14;
            this.btbEstadisticasQuiz.Text = "Estadisticas del Quiz";
            this.btbEstadisticasQuiz.UseVisualStyleBackColor = true;
            this.btbEstadisticasQuiz.Click += new System.EventHandler(this.btbEstadisticasQuiz_Click);
            // 
            // botonCargarQuizes
            // 
            this.botonCargarQuizes.AccessibleName = "botonEstadisticasQuiz";
            this.botonCargarQuizes.Location = new System.Drawing.Point(523, 92);
            this.botonCargarQuizes.Margin = new System.Windows.Forms.Padding(4);
            this.botonCargarQuizes.Name = "botonCargarQuizes";
            this.botonCargarQuizes.Size = new System.Drawing.Size(143, 41);
            this.botonCargarQuizes.TabIndex = 15;
            this.botonCargarQuizes.Text = "Cargar Quizes";
            this.botonCargarQuizes.UseVisualStyleBackColor = true;
            this.botonCargarQuizes.Click += new System.EventHandler(this.botonCargarQuizes_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.AccessibleName = "botonEstadisticasQuiz";
            this.botonBorrar.Location = new System.Drawing.Point(871, 590);
            this.botonBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(173, 59);
            this.botonBorrar.TabIndex = 16;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "botonEstadisticasQuiz";
            this.button3.Location = new System.Drawing.Point(457, 590);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 59);
            this.button3.TabIndex = 17;
            this.button3.Text = "Asaignar competencias";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuizesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 680);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonCargarQuizes);
            this.Controls.Add(this.btbEstadisticasQuiz);
            this.Controls.Add(this.btbClonarQuiz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstados);
            this.Controls.Add(this.botonRPublicados);
            this.Controls.Add(this.botonTerminado);
            this.Controls.Add(this.botonCancelado);
            this.Controls.Add(this.botonLanzado);
            this.Controls.Add(this.botonCompleto);
            this.Controls.Add(this.botonPreparado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridQuizes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizesActivos";
            this.Text = "InicioInstructor";
            this.Load += new System.EventHandler(this.InicioInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecciona;
        private System.Windows.Forms.Button botonPreparado;
        private System.Windows.Forms.Button botonCompleto;
        private System.Windows.Forms.Button botonLanzado;
        private System.Windows.Forms.Button botonCancelado;
        private System.Windows.Forms.Button botonTerminado;
        private System.Windows.Forms.Button botonRPublicados;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btbClonarQuiz;
        private System.Windows.Forms.Button btbEstadisticasQuiz;
        private System.Windows.Forms.Button botonCargarQuizes;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button button3;
    }
}
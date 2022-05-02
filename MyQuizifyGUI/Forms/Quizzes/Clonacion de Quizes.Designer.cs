namespace MyQuizifyGUI.Forms.Quizzes
{
    partial class Clonacion_de_Quizes
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridQuizes = new System.Windows.Forms.DataGridView();
            this.Selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btbVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filtrar por:";
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
            this.comboBoxEstados.Location = new System.Drawing.Point(764, 120);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstados.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AccessibleName = "labelQuizesActivos";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quizes de otros instructores";
            // 
            // dataGridQuizes
            // 
            this.dataGridQuizes.AccessibleName = "DataGridQuizesActivos";
            this.dataGridQuizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona});
            this.dataGridQuizes.Location = new System.Drawing.Point(44, 176);
            this.dataGridQuizes.Name = "dataGridQuizes";
            this.dataGridQuizes.RowHeadersWidth = 51;
            this.dataGridQuizes.Size = new System.Drawing.Size(841, 316);
            this.dataGridQuizes.TabIndex = 11;
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Selecciona";
            this.Selecciona.MinimumWidth = 6;
            this.Selecciona.Name = "Selecciona";
            this.Selecciona.Width = 125;
            // 
            // button3
            // 
            this.button3.AccessibleName = "botonCrearQuiz";
            this.button3.Location = new System.Drawing.Point(791, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 48);
            this.button3.TabIndex = 15;
            this.button3.Text = "Clonar Quizes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btbVolver
            // 
            this.btbVolver.AccessibleName = "botonCrearQuiz";
            this.btbVolver.Location = new System.Drawing.Point(12, 504);
            this.btbVolver.Name = "btbVolver";
            this.btbVolver.Size = new System.Drawing.Size(94, 48);
            this.btbVolver.TabIndex = 16;
            this.btbVolver.Text = "Volver";
            this.btbVolver.UseVisualStyleBackColor = true;
            this.btbVolver.Click += new System.EventHandler(this.btbVolver_Click);
            // 
            // Clonacion_de_Quizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 564);
            this.Controls.Add(this.btbVolver);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridQuizes);
            this.Name = "Clonacion_de_Quizes";
            this.Text = "Clonacion_de_Quizes";
            this.Load += new System.EventHandler(this.Clonacion_de_Quizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridQuizes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecciona;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btbVolver;
    }
}
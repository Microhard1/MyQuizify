
namespace MyQuizifyGUI
{
    partial class InicioInstructor
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuizes
            // 
            this.dataGridQuizes.AccessibleName = "DataGridQuizesActivos";
            this.dataGridQuizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona});
            this.dataGridQuizes.Location = new System.Drawing.Point(36, 138);
            this.dataGridQuizes.Name = "dataGridQuizes";
            this.dataGridQuizes.Size = new System.Drawing.Size(841, 316);
            this.dataGridQuizes.TabIndex = 0;
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Selecciona";
            this.Selecciona.Name = "Selecciona";
            // 
            // label1
            // 
            this.label1.AccessibleName = "labelQuizesActivos";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quizes activos";
            // 
            // button1
            // 
            this.button1.AccessibleName = "botonCrearQuiz";
            this.button1.Location = new System.Drawing.Point(36, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonPreparado
            // 
            this.botonPreparado.Location = new System.Drawing.Point(916, 176);
            this.botonPreparado.Name = "botonPreparado";
            this.botonPreparado.Size = new System.Drawing.Size(133, 23);
            this.botonPreparado.TabIndex = 3;
            this.botonPreparado.Text = "En preparacion";
            this.botonPreparado.UseVisualStyleBackColor = true;
            this.botonPreparado.Click += new System.EventHandler(this.botonPreparado_Click);
            // 
            // botonCompleto
            // 
            this.botonCompleto.Location = new System.Drawing.Point(916, 215);
            this.botonCompleto.Name = "botonCompleto";
            this.botonCompleto.Size = new System.Drawing.Size(133, 23);
            this.botonCompleto.TabIndex = 4;
            this.botonCompleto.Text = "Completo";
            this.botonCompleto.UseVisualStyleBackColor = true;
            this.botonCompleto.Click += new System.EventHandler(this.botonCompleto_Click);
            // 
            // botonLanzado
            // 
            this.botonLanzado.Location = new System.Drawing.Point(916, 255);
            this.botonLanzado.Name = "botonLanzado";
            this.botonLanzado.Size = new System.Drawing.Size(133, 23);
            this.botonLanzado.TabIndex = 5;
            this.botonLanzado.Text = "Lanzado";
            this.botonLanzado.UseVisualStyleBackColor = true;
            this.botonLanzado.Click += new System.EventHandler(this.botonLanzado_Click);
            // 
            // botonCancelado
            // 
            this.botonCancelado.Location = new System.Drawing.Point(916, 299);
            this.botonCancelado.Name = "botonCancelado";
            this.botonCancelado.Size = new System.Drawing.Size(133, 23);
            this.botonCancelado.TabIndex = 6;
            this.botonCancelado.Text = "Cancelado";
            this.botonCancelado.UseVisualStyleBackColor = true;
            this.botonCancelado.Click += new System.EventHandler(this.botonCancelado_Click);
            // 
            // botonTerminado
            // 
            this.botonTerminado.Location = new System.Drawing.Point(916, 345);
            this.botonTerminado.Name = "botonTerminado";
            this.botonTerminado.Size = new System.Drawing.Size(133, 23);
            this.botonTerminado.TabIndex = 7;
            this.botonTerminado.Text = "Terminado";
            this.botonTerminado.UseVisualStyleBackColor = true;
            this.botonTerminado.Click += new System.EventHandler(this.botonTerminado_Click);
            // 
            // botonRPublicados
            // 
            this.botonRPublicados.Location = new System.Drawing.Point(916, 385);
            this.botonRPublicados.Name = "botonRPublicados";
            this.botonRPublicados.Size = new System.Drawing.Size(133, 23);
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
            this.comboBoxEstados.Location = new System.Drawing.Point(756, 82);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstados.TabIndex = 9;
            this.comboBoxEstados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(916, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cambiar estado a:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(722, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ver resultados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InicioInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 539);
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
            this.Name = "InicioInstructor";
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
    }
}
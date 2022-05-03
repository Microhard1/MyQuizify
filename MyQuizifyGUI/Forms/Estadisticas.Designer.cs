
namespace MyQuizifyGUI.Forms
{
    partial class Estadisticas
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
            this.lblMinima = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreQuiz = new System.Windows.Forms.Label();
            this.btbVolver = new System.Windows.Forms.Button();
            this.dataGridEstadisticas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Location = new System.Drawing.Point(1133, 161);
            this.lblMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(46, 17);
            this.lblMinima.TabIndex = 31;
            this.lblMinima.Text = "label6";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Location = new System.Drawing.Point(1133, 126);
            this.lblMaxima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(46, 17);
            this.lblMaxima.TabIndex = 30;
            this.lblMaxima.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1037, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nota minima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1037, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nota maxima:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(1133, 93);
            this.lblMedia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(46, 17);
            this.lblMedia.TabIndex = 27;
            this.lblMedia.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1079, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Media:";
            // 
            // lblNombreQuiz
            // 
            this.lblNombreQuiz.AutoSize = true;
            this.lblNombreQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreQuiz.Location = new System.Drawing.Point(89, 34);
            this.lblNombreQuiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreQuiz.Name = "lblNombreQuiz";
            this.lblNombreQuiz.Size = new System.Drawing.Size(287, 39);
            this.lblNombreQuiz.TabIndex = 25;
            this.lblNombreQuiz.Text = "Nombre del Quiz";
            // 
            // btbVolver
            // 
            this.btbVolver.AccessibleName = "botonVolver";
            this.btbVolver.Location = new System.Drawing.Point(86, 507);
            this.btbVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btbVolver.Name = "btbVolver";
            this.btbVolver.Size = new System.Drawing.Size(125, 59);
            this.btbVolver.TabIndex = 24;
            this.btbVolver.Text = "Volver";
            this.btbVolver.UseVisualStyleBackColor = true;
            this.btbVolver.Click += new System.EventHandler(this.btbVolver_Click);
            // 
            // dataGridEstadisticas
            // 
            this.dataGridEstadisticas.AccessibleName = "DataGridEstadisticas";
            this.dataGridEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadisticas.Location = new System.Drawing.Point(82, 93);
            this.dataGridEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridEstadisticas.Name = "dataGridEstadisticas";
            this.dataGridEstadisticas.RowHeadersWidth = 51;
            this.dataGridEstadisticas.Size = new System.Drawing.Size(917, 389);
            this.dataGridEstadisticas.TabIndex = 23;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 600);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreQuiz);
            this.Controls.Add(this.btbVolver);
            this.Controls.Add(this.dataGridEstadisticas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreQuiz;
        private System.Windows.Forms.Button btbVolver;
        private System.Windows.Forms.DataGridView dataGridEstadisticas;
    }
}
﻿
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
            this.dataGridEstadisticas = new System.Windows.Forms.DataGridView();
            this.btbVolver = new System.Windows.Forms.Button();
            this.lblNombreQuiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEstadisticas
            // 
            this.dataGridEstadisticas.AccessibleName = "DataGridEstadisticas";
            this.dataGridEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadisticas.Location = new System.Drawing.Point(9, 66);
            this.dataGridEstadisticas.Name = "dataGridEstadisticas";
            this.dataGridEstadisticas.RowHeadersWidth = 51;
            this.dataGridEstadisticas.Size = new System.Drawing.Size(688, 316);
            this.dataGridEstadisticas.TabIndex = 14;
            // 
            // btbVolver
            // 
            this.btbVolver.AccessibleName = "botonVolver";
            this.btbVolver.Location = new System.Drawing.Point(12, 402);
            this.btbVolver.Name = "btbVolver";
            this.btbVolver.Size = new System.Drawing.Size(94, 48);
            this.btbVolver.TabIndex = 15;
            this.btbVolver.Text = "Volver";
            this.btbVolver.UseVisualStyleBackColor = true;
            this.btbVolver.Click += new System.EventHandler(this.btbVolver_Click);
            // 
            // lblNombreQuiz
            // 
            this.lblNombreQuiz.AutoSize = true;
            this.lblNombreQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreQuiz.Location = new System.Drawing.Point(14, 18);
            this.lblNombreQuiz.Name = "lblNombreQuiz";
            this.lblNombreQuiz.Size = new System.Drawing.Size(231, 31);
            this.lblNombreQuiz.TabIndex = 16;
            this.lblNombreQuiz.Text = "Nombre del Quiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Media:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(797, 66);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(35, 13);
            this.lblMedia.TabIndex = 18;
            this.lblMedia.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nota maxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nota minima:";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Location = new System.Drawing.Point(797, 93);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(35, 13);
            this.lblMaxima.TabIndex = 21;
            this.lblMaxima.Text = "label5";
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Location = new System.Drawing.Point(797, 121);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(35, 13);
            this.lblMinima.TabIndex = 22;
            this.lblMinima.Text = "label6";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 464);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreQuiz);
            this.Controls.Add(this.btbVolver);
            this.Controls.Add(this.dataGridEstadisticas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridEstadisticas;
        private System.Windows.Forms.Button btbVolver;
        private System.Windows.Forms.Label lblNombreQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label lblMinima;
    }
}
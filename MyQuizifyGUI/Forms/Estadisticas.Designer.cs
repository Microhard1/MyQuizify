
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 13;
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
            this.comboBoxEstados.Location = new System.Drawing.Point(390, 40);
            this.comboBoxEstados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(180, 28);
            this.comboBoxEstados.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "DataGridEstadisticas";
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(13, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 486);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Selecciona";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstados);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
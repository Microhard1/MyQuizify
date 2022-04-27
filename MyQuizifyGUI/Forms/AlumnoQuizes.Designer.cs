
namespace MyQuizifyGUI.Forms
{
    partial class AlumnoQuizes
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuizes
            // 
            this.dataGridQuizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuizes.Location = new System.Drawing.Point(38, 63);
            this.dataGridQuizes.Name = "dataGridQuizes";
            this.dataGridQuizes.Size = new System.Drawing.Size(549, 291);
            this.dataGridQuizes.TabIndex = 0;
            this.dataGridQuizes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQuizes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quizes disponibles:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Realizar quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlumnoQuizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 429);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridQuizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnoQuizes";
            this.Text = "AlumnoQuizes";
            this.Load += new System.EventHandler(this.AlumnoQuizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
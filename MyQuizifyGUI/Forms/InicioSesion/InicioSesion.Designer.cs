
namespace MyQuizifyGUI
{
    partial class InicioSesion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCheckPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAceptoTyC = new System.Windows.Forms.CheckBox();
            this.botonInicioSesion = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.buttonAlumno = new System.Windows.Forms.RadioButton();
            this.buttonInstructor = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 671);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(140, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 378);
            this.label6.TabIndex = 0;
            this.label6.Text = "Q\r\nU  \r\n I\r\nZ\r\n I\r\nF\r\nY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(380, 181);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(367, 22);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(380, 277);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(367, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxCheckPassword
            // 
            this.textBoxCheckPassword.Location = new System.Drawing.Point(380, 374);
            this.textBoxCheckPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCheckPassword.Name = "textBoxCheckPassword";
            this.textBoxCheckPassword.Size = new System.Drawing.Size(364, 22);
            this.textBoxCheckPassword.TabIndex = 5;
            this.textBoxCheckPassword.TextChanged += new System.EventHandler(this.textBoxCheckPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // checkBoxAceptoTyC
            // 
            this.checkBoxAceptoTyC.AutoSize = true;
            this.checkBoxAceptoTyC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAceptoTyC.Location = new System.Drawing.Point(380, 443);
            this.checkBoxAceptoTyC.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAceptoTyC.Name = "checkBoxAceptoTyC";
            this.checkBoxAceptoTyC.Size = new System.Drawing.Size(329, 29);
            this.checkBoxAceptoTyC.TabIndex = 10;
            this.checkBoxAceptoTyC.Text = "Acepto los términos y condiciones";
            this.checkBoxAceptoTyC.UseVisualStyleBackColor = true;
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.AccessibleName = "botonInicioSesion";
            this.botonInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(107)))));
            this.botonInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonInicioSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonInicioSesion.Location = new System.Drawing.Point(383, 556);
            this.botonInicioSesion.Margin = new System.Windows.Forms.Padding(4);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.Size = new System.Drawing.Size(365, 55);
            this.botonInicioSesion.TabIndex = 11;
            this.botonInicioSesion.Text = "Iniciar sesión";
            this.botonInicioSesion.UseVisualStyleBackColor = false;
            this.botonInicioSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.botonRegistrar.FlatAppearance.BorderSize = 0;
            this.botonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrar.ForeColor = System.Drawing.Color.Blue;
            this.botonRegistrar.Location = new System.Drawing.Point(383, 619);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(93, 28);
            this.botonRegistrar.TabIndex = 15;
            this.botonRegistrar.Text = "Registrarse";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // buttonAlumno
            // 
            this.buttonAlumno.AutoSize = true;
            this.buttonAlumno.Location = new System.Drawing.Point(383, 503);
            this.buttonAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlumno.Name = "buttonAlumno";
            this.buttonAlumno.Size = new System.Drawing.Size(76, 21);
            this.buttonAlumno.TabIndex = 16;
            this.buttonAlumno.TabStop = true;
            this.buttonAlumno.Text = "Alumno";
            this.buttonAlumno.UseVisualStyleBackColor = true;
            this.buttonAlumno.CheckedChanged += new System.EventHandler(this.buttonAlumno_CheckedChanged);
            // 
            // buttonInstructor
            // 
            this.buttonInstructor.AutoSize = true;
            this.buttonInstructor.Location = new System.Drawing.Point(495, 503);
            this.buttonInstructor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInstructor.Name = "buttonInstructor";
            this.buttonInstructor.Size = new System.Drawing.Size(88, 21);
            this.buttonInstructor.TabIndex = 17;
            this.buttonInstructor.TabStop = true;
            this.buttonInstructor.Text = "Instructor";
            this.buttonInstructor.UseVisualStyleBackColor = true;
            this.buttonInstructor.CheckedChanged += new System.EventHandler(this.buttonInstructor_CheckedChanged);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 671);
            this.Controls.Add(this.buttonInstructor);
            this.Controls.Add(this.buttonAlumno);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.botonInicioSesion);
            this.Controls.Add(this.checkBoxAceptoTyC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCheckPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCheckPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAceptoTyC;
        private System.Windows.Forms.Button botonInicioSesion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.RadioButton buttonAlumno;
        private System.Windows.Forms.RadioButton buttonInstructor;
    }
}
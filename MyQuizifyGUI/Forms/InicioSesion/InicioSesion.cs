﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using MyQuizifyGUI.Forms;

namespace MyQuizifyGUI
{
    public partial class InicioSesion : Form
    {

        MyQuizifyServices services = new MyQuizifyServices();
        ConexionBD cf = ConexionBD.getInstancia();
        private InicioAlumno inicioAlumno;
        private InicioInstructor inicioInstructor;
        private string tipoUsuario;

        public InicioSesion()
        {
            InitializeComponent();
            inicioAlumno = new InicioAlumno();
            inicioInstructor = new InicioInstructor();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string _usuario;
            string _password;
            int num = comprobarCredenciales();
            if (num == -1)
            {
                MessageBox.Show("Existen campos sin rellenar");
            }
            else if (num == 0)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                _usuario = textBoxUsername.Text;
                _password = textBoxPassword.Text;
                if (contraseñaFormatoCorrecto(_password))
                {

                    if (verificarUsuario(_usuario))
                    {
                        if (validarContraseña(_usuario, _password))
                        {
                            cf.usuarioConectado = services.getInstructorById(_usuario);
                            if (buttonAlumno.Checked)
                            {
                                inicioAlumno.Show();
                                this.Hide();
                            }
                            else
                            {
                                inicioInstructor.Show();
                                this.Hide();
                            }
                        }
                        else MessageBox.Show("Contraseña incorrecta");

                    }
                    else MessageBox.Show("El usuario no está registrado");
                }
                else MessageBox.Show("La contraseña debe contener al menos 6 caracteres");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        public int comprobarCredenciales()
        {

            if (textBoxUsername.Text == "" || textBoxPassword.Text == ""
                || textBoxCheckPassword.Text == "" ||
                !buttonAlumno.Checked && !buttonInstructor.Checked)
            {
                return -1;
            }

            if (!textBoxCheckPassword.Text.Equals(textBoxPassword.Text))
            {
                return 0;
            }


            return 1;
        }

        public bool verificarUsuario(string username)
        {


            FirebaseResponse listado = cf.client.Get("/Usuarios/" + tipoUsuario + "/" + username + "/username");
            string nombreUsuario = listado.ResultAs<string>();
            if (nombreUsuario != null) return true;
            return false;
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrarForm = new Registrar();
            registrarForm.ShowDialog();
        }

        public bool validarContraseña(string username, string pass)
        {

            FirebaseResponse response = cf.client.Get("/Usuarios/" + tipoUsuario + "/" + username + "/password");
            string a = response.ResultAs<string>();

            if (Encriptador.GetSHA256(pass).Equals(a)) return true;
            return false;
        }

        public bool contraseñaFormatoCorrecto(string password)
        {

            if (password.Length < 6) return false;
            return true;

        }

        private void buttonAlumno_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = "Alumnos";
        }

        private void buttonInstructor_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = "Instructores";
        }

<<<<<<< HEAD:MyQuizifyGUI/Forms/InicioSesion.cs
        
=======
        private void textBoxCheckPassword_TextChanged(object sender, EventArgs e)
        {

        }
>>>>>>> 308770ceeb6e633b0997d5b997c669033674434b:MyQuizifyGUI/Forms/InicioSesion/InicioSesion.cs
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class PreguntaMO : Pregunta
    {
        public PreguntaMO(string enunciado, string imagen, double puntuacion, string explicacion) :
                base(enunciado, imagen, puntuacion, explicacion)
        {

        }

        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaMO(enunciado);
            return r;
        }
    }
}

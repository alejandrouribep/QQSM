using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQSM
{
    class pregunta
    {
        private string enunciado;
        private string[] opciones;
        private string respuesta;
        private int puntaje;

        public pregunta(string enunciado, string respuesta, string[] opciones, int puntaje)
        {
            this.enunciado = enunciado;
            this.respuesta = respuesta;
            this.opciones = opciones;
            this.puntaje = puntaje;

        }

        public string get_enunciado()
        {
            return enunciado;
        }

        public string[] get_opciones()
        {
            return opciones;
        }

        public int get_puntaje()
        {
            return puntaje;
        }

        public string get_respuesta()
        {
            return respuesta;
        }
        public string Validar_respuesta(string respuesta_usuario)
        {
            string acerto = "falso";
            if (respuesta_usuario == "a")
            {
                if (opciones[0] == respuesta)
                { acerto = "true"; }
            }
            else if (respuesta_usuario == "b")
            {
                if (opciones[1] == respuesta)
                { acerto = "true"; }
            }
            else if (respuesta_usuario == "c")
            {
                if (opciones[2] == respuesta)
                { acerto = "true"; }
            }
            else if (respuesta_usuario == "d")
            {
                if (opciones[3] == respuesta)
                { acerto = "true"; }
            }
            return acerto;

        }



    }
}


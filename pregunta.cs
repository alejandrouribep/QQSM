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
        private string [] opciones;
        private string respuesta;
        private int puntaje;

        public pregunta(string enunciado, string respuesta,string []opciones,int puntaje)
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

       
        



    }
}

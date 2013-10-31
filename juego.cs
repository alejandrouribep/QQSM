using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QQSM
{
    class juego
    {
        private List<pregunta> preguntas = new List<pregunta>(); 

        public void cuestionario()
        {
            cargar_cuestionario();
            mostrar_cuestionario();
        }

        private void cargar_cuestionario()
        {
            string line;
            StreamReader streamReader = new StreamReader("C:\\Users\\Alejandro\\Documents\\Preguntas.txt");
            while ((line = streamReader.ReadLine()) != null)
            { 
                string[] split = line.Split(new Char[] { ';' });
                if (split.Length != 0)
                {
                    pregunta p;
                    string[] opciones = { split[1], split[2], split[3], split[4] };
                    p = new pregunta(split[0], split[4], opciones, 5);
                    preguntas.Add (p);     
                }
            }
            streamReader.Close();
        }
        private void mostrar_cuestionario()
        {
            for (int i = 0; i < preguntas.Count ; i++)
            {
                Console.WriteLine(preguntas[i].get_enunciado());
            }
           
        }
        public void juego()
        {
 
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Analyseur
    {
        public static void Run()
        {
            //Lecture du fichier 
            string file_name = "file.txt";
            string textLine = "";

            if (System.IO.File.Exists(file_name) == true)
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(file_name);

                do
                {
                    textLine = textLine + objReader.ReadLine();
                } while (objReader.Peek() != -1);

                objReader.Close();
            }
            else
            {
                Console.WriteLine("Fichier introuvable!");
            }

            //Lance l'analyse du code
            if(new AnalSyn(new AnalLex(textLine)).Analyse() == true)
            Verificateur.instance.showMessage("Accepté");
        }
    }
}

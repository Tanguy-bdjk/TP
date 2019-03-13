using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {
        private static object imc;

        static void Main(string[] args)
        {
            NameValueCollection imc = new NameValueCollection();
            imc.Add("Moins de 16,5", "Dénutrition");
            imc.Add("16,5 à 18.5", "Maigreur ");
            imc.Add("18,5 à 25", "Corpulence normale");
            imc.Add("25 à 30", "Surpoids");
            imc.Add("30 à 35", "Obésité modérée ");
            imc.Add("35 à 40", "Obésité sévère");
            imc.Add("plus de 40", "Obésitè morbide ou massive");


            double poids = 0;
            double taille = 0;
            Console.WriteLine("votre poids ?");
            double.TryParse(Console.ReadLine(), out poids);
            Console.WriteLine("votre taille ?");
            double.TryParse(Console.ReadLine(), out taille);

            imc = Math.Pow(poids) / Math.Pow(taille, 2);
        
            if


        }
    }
}

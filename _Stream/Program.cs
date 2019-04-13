using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = string.Empty;
            string search = string.Empty;

            text = "La casa del casamiento";
            search = "casa";
            //MatchesExp(text, search);

            //Uso de . significa cualquier caracter despues del punto cabal,campeon,academico
            text = "Saludos al mas campeon";
            search = "ca.";
            //MatchesExp(text, search);

            //Uso de clase de caracteres, se usa [] para contener los caracteres que esten dentro el corchete Nico,Necio,Naco
            text = "Hola Nico";
            search = "N[ie]c";
            //MatchesExp(text, search);

            //Utilizar rango
            text = "Hola Necio";
            search = "N[a-u]c";
            //MatchesExp(text, search);

            //Utilizar complemento para negacion
            text = "Hola Nico";
            search = "N[^ie]c";
            //MatchesExp(text, search);

            //Para conocer si una cadena finaliza en una expresion
            text = "De youtube Nicosiored es mi canal Nic";
            search = "N[ie]c$";
            //MatchesExp(text, search);

            //Elementos opcionales puede o no contener la c
            text = "Hola Nip";
            search = "N[ie]c?p";
            //MatchesExp(text, search);

            //Cuantificador
            //Buscar que existen n de esos elementos
            text = "Holaa Nico 69";
            search = "[0-9]{2}";
            //MatchesExp(text, search);

            //Alternaciones
            text = "Yo se programar c";
            search = "c|java|pyton";
            MatchesExp(text, search);
        }

        public static void MatchesExp(string text, string exp)
        {
            MatchCollection found = Regex.Matches(text, exp);

            foreach (Match item in found)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================================");
            Console.ReadKey();
        }
    }
}

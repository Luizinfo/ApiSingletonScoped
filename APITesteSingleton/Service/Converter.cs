using APITesteSingleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITesteSingleton.Service
{
    public class Converter
    {
        private readonly char[] VOGAIS = new char[5]{'a','e','i','o','u'};
        private Contexto contexto = Contexto.Instance;

        public string LinguaDoI()
        {
            if (contexto.Palavra == null)
                return null;

            StringBuilder texto = new StringBuilder();
            foreach (var letra in contexto.Palavra.ToLower())
            {
                if (VOGAIS.Contains(letra))
                    texto.Append("i");
                else
                    texto.Append(letra);
 
            }

            return texto.ToString();
        }
    }
}

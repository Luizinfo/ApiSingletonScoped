using APITesteSingleton.Interface;
using APITesteSingleton.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace APITesteSingleton.Service
{
    public class ServiceExecutable : IExecutable
    {
        private Converter converter;
        public ServiceExecutable(Converter converter)
        {
            this.converter = converter;
        }

        private Contexto Contexto { get; } = Contexto.Instance;
        public Retorno Processar(string palavra)
        {
            var time = Stopwatch.StartNew();

            ContarPalavra(palavra);
            time.Stop();

            return new Retorno(Contexto.Count, Contexto.Palavra, time.ElapsedMilliseconds.ToString(), converter.LinguaDoI());
        }

        private void ContarPalavra(string palavra)
        {
            if (palavra == null)
                return;

            Contexto.Count = palavra.Length;
            Contexto.Palavra = palavra;
        }
    }
}

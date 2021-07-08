using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APITesteSingleton.Model
{
    public class Contexto
    {
        private static ThreadLocal<Contexto> instances = new ThreadLocal<Contexto>(() => new Contexto());

        private Contexto()
        {
        }

        public static Contexto Instance
        {
            get { return instances.Value; }
        }

        public int Count { get; set; }
        public string Palavra { get; set; }
    }
}

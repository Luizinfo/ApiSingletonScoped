using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITesteSingleton.Model
{
    public class Retorno
    {
        public Retorno(int total, string palavra, string tempo, string traducao)
        {
            Total = total;
            Palavra = palavra;
            Tempo = tempo;
            Traducao = traducao;
        }

        public int Total { get; set; }
        public string Palavra{ get; set; }
        public string Tempo{ get; set; }
        public string Traducao{ get; set; }
    }
}

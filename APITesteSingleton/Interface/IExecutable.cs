using APITesteSingleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITesteSingleton.Interface
{
    public interface IExecutable
    {
        Retorno Processar(string palavra);
    }
}

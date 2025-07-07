using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_dotnet_o8.Services
{
    public interface IRepository<T> where T : class
    {
        List<T> ListarRegistros();
        void Salvar(T registro);
        void Excluir(int id);
        T RetornarRegistro(int id);       
    }
}
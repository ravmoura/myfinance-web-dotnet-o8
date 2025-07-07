using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfinance_web_dotnet_o8.Domain;

namespace myfinance_web_dotnet_o8.Services
{
    public interface ITransacaoService
    {
        List<Transacao> ListarRegistros();
        void Salvar(Transacao registro);
        void Excluir(int id);
        Transacao RetornarRegistro(int id);       
    }
}
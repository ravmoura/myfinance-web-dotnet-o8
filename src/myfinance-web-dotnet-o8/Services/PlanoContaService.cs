using myfinance_web_dotnet_o8.Domain;
using myfinance_web_dotnet_o8.Infraestrutucture;

namespace myfinance_web_dotnet_o8.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private readonly MyFinanceDbContext _banco;        

        public PlanoContaService(MyFinanceDbContext myFinanceDbContext)
        {
            _banco = myFinanceDbContext;            
        }

        public void Excluir(int id)
        {
            var item = RetornarRegistro(id);
            _banco.Attach(item);
            _banco.Remove(item);
            _banco.SaveChanges();
        }

        public List<PlanoConta> ListarRegistros()
        {
            var item = _banco.PlanoConta.ToList();
            return item;
        }

        public PlanoConta RetornarRegistro(int id)
        {
            var item = _banco.PlanoConta.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

        public void Salvar(PlanoConta registro)
        {
            if (registro.Id == null)
            {
                _banco.PlanoConta.Add(registro);
            }
            else
            {
                _banco.PlanoConta.Attach(registro);
                _banco.Entry(registro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            }
            _banco.SaveChanges();
        }
    }
}
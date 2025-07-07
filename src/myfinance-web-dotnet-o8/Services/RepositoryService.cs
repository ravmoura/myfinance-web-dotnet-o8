using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_o8.Infraestrutucture;

namespace myfinance_web_dotnet_o8.Services
{
    public class RepositoryService<T> : IRepository<T> where T : class
    {
        private readonly MyFinanceDbContext _banco;        
        private readonly DbSet<T> _dbSet;

        public RepositoryService(MyFinanceDbContext myFinanceDbContext)
        {
            _banco = myFinanceDbContext;
            _dbSet = _banco.Set<T>();
        }

        public void Excluir(int id)
        {
            var item = RetornarRegistro(id);

            if (item != null)
            {
                _dbSet.Remove(item);
                _banco.SaveChanges();    
            }
        }

        public List<T> ListarRegistros()
        {
            var item = _dbSet.ToList();
            return item;
        }

        public T RetornarRegistro(int id)
        {
            var item = _dbSet.Find(id);
            return item;
        }

        public void Salvar(T registro)
        {
            var entry = _banco.Entry(registro);
            var key = _banco.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties.First();
            var id = entry.Property(key.Name).CurrentValue;

            if (id == null)
            {
                _dbSet.Add(registro);
            }
            else
            {
                _dbSet.Attach(registro);
                entry.State = EntityState.Modified;

            }
            _banco.SaveChanges();
        }    
    }
}
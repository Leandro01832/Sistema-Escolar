using business;
using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolar.Models.Repository
{
    public interface IReposiitoryTurma
    {
        IEnumerable<Turma> GetAll();
        Turma Get(int id);
        void Add(Turma item);
        void Update(Turma item);
        Task<bool> Delete(int id);
    }

    public class TurmaRepository : BaseRepository<Turma>, IReposiitoryTurma
    {
        public TurmaRepository(ApplicationDbContext contexto) : base(contexto)
        {
            Contexto = contexto;
        }

        public ApplicationDbContext Contexto { get; }

        public async void Add(Turma item)
        {
            dbSet.Add(item);
           await  Contexto.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            if(dbSet.FirstOrDefault(t => t.Id == id) != null)
            {
                dbSet.Remove(Get(id));
                await Contexto.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Turma Get(int id)
        {
           return  dbSet.Include(p => p.Escola).First(t => t.Id == id);
        }

        public IEnumerable<Turma> GetAll()
        {
            return  dbSet.ToList();
        }

        public async void Update(Turma item)
        {
            dbSet.Update(item);
            await Contexto.SaveChangesAsync();
        }
    }
}

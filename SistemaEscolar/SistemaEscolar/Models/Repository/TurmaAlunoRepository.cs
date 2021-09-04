using business.Intermediario;
using SistemaEscolar.Data;
using SistemaEscolar.Models.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaEscolar.Models.Repository
{
    public interface IRepositoryTurmaAluno
    {
        Task<TurmaAluno> Get(int id);
        void Add(TurmaAluno item);
        void Update(TurmaAluno item);
        Task<bool> Delete(int id);
    }

    public class TurmaAlunoRepository : BaseRepository<TurmaAluno>, IRepositoryTurmaAluno
    {
        public TurmaAlunoRepository(ApplicationDbContext contexto) : base(contexto)
        {
            Contexto = contexto;
        }

        public ApplicationDbContext Contexto { get; }

        public async void Add(TurmaAluno item)
        {
            await dbSet.AddAsync(item);
            await Contexto.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var turmaAluno = dbSet.Find(id);
            if (turmaAluno != null)
            {
                dbSet.Remove(turmaAluno);
                await Contexto.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<TurmaAluno> Get(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async void Update(TurmaAluno item)
        {
            dbSet.Update(item);
            await Contexto.SaveChangesAsync();
        }
    }
}

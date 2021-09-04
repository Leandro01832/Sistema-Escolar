using business;
using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolar.Models.Repository
{
    public interface IRepositoryAluno
    {
        IEnumerable<Aluno> GetAll();
        Aluno Get(string Email);
        Task<Aluno> Get(int id);
        void Add(Aluno item);
        void Update(Aluno item);
        Task<bool> Delete(int id);
    }

    public class AlunoRepository : BaseRepository<Aluno>, IRepositoryAluno
    {
        public AlunoRepository(ApplicationDbContext contexto) : base(contexto)
        {
            Contexto = contexto;
        }

        public ApplicationDbContext Contexto { get; }

        public async void Add(Aluno item)
        {
            await dbSet.AddAsync(item);
            await Contexto.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            if (dbSet.FirstOrDefault(t => t.Id == id) != null)
            {
                dbSet.Remove(await Get(id));
                await Contexto.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Aluno Get(string email)
        {
            return dbSet.Include(a => a.Turmas).First(a => a.Email == email);
        }

        public async Task<Aluno> Get(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public IEnumerable<Aluno> GetAll()
        {
            return dbSet.ToList();
        }

        public async void Update(Aluno item)
        {
            dbSet.Update(item);
            await Contexto.SaveChangesAsync();
        }
    }
}

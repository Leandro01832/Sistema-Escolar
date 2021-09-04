﻿using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;

namespace SistemaEscolar.Models.Repository
{
    public class BaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
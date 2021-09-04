
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaEscolar.Data;

namespace SistemaEscolar
{
    public class DataService : IDataService
    {
        public async Task InicializaDBAsync(IServiceProvider provider)
        {
            var contexto = provider.GetService<ApplicationDbContext>();

            await contexto.Database.MigrateAsync();
            
            
        }
        
    }
}

using AgroMagCore.IConfiguration;
using AgroMagCore.IRepositories.Field;
using AgroMagCore.Repositories.Field;
using AgroMagDatabase.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagCore
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AgroMagDbContext context;

        private readonly ILogger logger;

        public IFieldRepository Fields { get; private set; }

        public UnitOfWork(AgroMagDbContext context,
            ILoggerFactory loggerFactory)
        {
            this.context = context;
            this.logger = loggerFactory.CreateLogger("logs");

            Fields = new FieldRepository(context, logger);
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}

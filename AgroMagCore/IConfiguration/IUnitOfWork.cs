using AgroMagCore.IRepositories.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagCore.IConfiguration
{
    public interface IUnitOfWork
    {
        IFieldRepository Fields { get; }

        Task CompleteAsync();
    }
}

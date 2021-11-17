using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagCore.IRepositories.Field
{
    public interface IFieldRepository : IGenericRepository<AgroMagDatabase.Models.Field.Field>
    {
        Task<string> GetFirstFieldName(int id);
    }
}

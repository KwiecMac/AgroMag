using AgroMagCore.IRepositories.Field;
using AgroMagDatabase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagCore.Repositories.Field
{
    public class FieldRepository : GenericRepository<AgroMagDatabase.Models.Field.Field>, IFieldRepository
    {
        public FieldRepository(
            AgroMagDbContext context,
            ILogger logger) : base (context, logger)
        {
        }

        public override async Task<bool> Upsert(AgroMagDatabase.Models.Field.Field entity)
        {
            var existingField = await dbSet.Where(p => p.Id == entity.Id)
                                    .FirstOrDefaultAsync();

            if (existingField == null)
                return await Add(entity);

            existingField.Id = entity.Id;
            existingField.Area = entity.Area;
            existingField.FieldAddress = entity.FieldAddress;
            existingField.FieldAddressId = entity.FieldAddressId;
            existingField.FieldOperation = entity.FieldOperation;
            existingField.IsOwn = entity.IsOwn;
            existingField.Name = entity.Name;

            return true;
        }

        public override async Task<bool> Delete(int id)
        {
            var exist = await dbSet.Where(p => p.Id == id)
                            .FirstOrDefaultAsync();

            if (exist != null)
            {
                dbSet.Remove(exist);
                return true;
            }

            return false;
        }

        public Task<string> GetFirstFieldName(int id)
        {
            throw new NotImplementedException();
        }
    }
}

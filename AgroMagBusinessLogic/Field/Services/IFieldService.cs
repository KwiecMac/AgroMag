using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagBusinessLogic.Field.Services
{
    public interface IFieldService
    {
        Task CreateFieldAsync(AgroMagDatabase.Models.Field.Field field);
    }
}

using AgroMagCore.IConfiguration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagBusinessLogic.Field.Services
{
    public class FieldService : IFieldService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger logger;

        public FieldService(IUnitOfWork unitOfWork,
            ILogger logger)
        {
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }

        public async Task CreateFieldAsync(AgroMagDatabase.Models.Field.Field field)
        {
            await unitOfWork.Fields.Add(field);
            await unitOfWork.CompleteAsync();
        }
    }
}

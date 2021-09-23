using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagDatabase.Models.Field
{
    public class FieldOperation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? Date { get; set; }

        public string Contractor { get; set; }

        public int FieldId { get; set; }

        public virtual Field Field { get; set; }
    }
}

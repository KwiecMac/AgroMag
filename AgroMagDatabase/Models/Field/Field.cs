using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagDatabase.Models.Field
{
    public class Field
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Area { get; set; }

        public bool IsOwn { get; set; }

        public int FieldAddressId { get; set; }

        public virtual FieldAddress FieldAddress { get; set; }

        public virtual ICollection<FieldOperation> FieldOperation { get; set; }
    }
}

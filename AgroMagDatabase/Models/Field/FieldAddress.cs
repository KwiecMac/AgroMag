using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagDatabase.Models.Field
{
    public class FieldAddress
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public virtual Field Field { get; set; }
    }
}

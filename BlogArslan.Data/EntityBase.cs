using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            this.Id = Guid.NewGuid();
            this.CreationTime = DateTime.Now;
        }

        [Key] //Bu entity tanımlayacak şeyin bu olacağını belirliyor
        public Guid Id { get; set; }
        public DateTimeOffset CreationTime { get; set; }
    }
}

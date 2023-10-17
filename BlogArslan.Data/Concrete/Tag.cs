using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class Tag : EntityBase
    {
        public Tag(string name)
        {
            Name = name;
        }

        [Required]
        public string Name { get; set; }
        public virtual ICollection<BlogEntryTag>? BlogEntryTags { get; set; }
    }
}

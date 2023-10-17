using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class BlogEntryTag
    {
        public Guid? BlogEntryId { get; set; }
        public virtual BlogEntry? BlogEntry { get; set; }
        public Guid? TagId { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class BlogFile : EntityBase
    {
        public BlogFile(string name)
        {
            Name = name;
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int Counter { get; set; }
        [Required]
        public Guid? BlogEntryId { get; set; }
        public virtual BlogEntry? BlogEntry { get; set; }
        public string Path
        {
            get
            {
                string extension = this.Name.Substring(this.Name.LastIndexOf('.')+1);
                return $"{this.Id}.{extension}";
            }
        }
    }
}

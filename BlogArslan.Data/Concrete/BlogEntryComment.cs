,using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class BlogEntryComment : EntityBase
    {
        public BlogEntryComment(string name, string comment)
        {
            Name = name;
            Comment = comment;
        }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Comment { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(100)]
        public string? HomePage { get; set; }
        public bool AdminPost { get; set; }
        [Required]
        public Guid? BlogEntryId { get; set; }
        public virtual BlogEntry? BlogEntry { get; set; }
    }
}

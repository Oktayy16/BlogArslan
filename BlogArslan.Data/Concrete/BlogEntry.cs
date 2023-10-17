using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class BlogEntry : EntityBase
    {
        public BlogEntry() 
        { 
        }
        public BlogEntry(string header, string permaLink, string shortContent)
        {
            Header = header;
            PermaLink = permaLink;
            ShortContent = shortContent;
        }

        [StringLength(150)]
        [Required]
        public string Header { get; set; }
        [StringLength(150)]
        [Required]
        public string PermaLink { get; set; }
        [StringLength(1500)]
        [Required]
        public string ShortContent { get; set; }
        public string? Content { get; set; }
        public bool Visible { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public int Visits { get; set; }
        public string? AuthorId { get; set; }
        public User? Author { get; set; }
        public virtual ICollection<BlogEntryTag>? Tags { get; set; }

        public virtual ICollection<BlogEntryComment>? BlogEntryComments { get; set; }

        public virtual ICollection<BlogEntryFile>? BlogEntryFiles { get; set; }

        public string Url
        {
            get
            {
                return $"{this.PublishDate.Year}/{this.PublishDate.Day}/{this.PermaLink}";
            }
        }
    }
}

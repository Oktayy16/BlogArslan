using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.Concrete
{
    public class Image : EntityBase
    {
        public Image(string name)
        {
            Name = name;
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Path
        {
            get
            {
                string extension = this.Name.Substring(this.Name.LastIndexOf(".")+1);
                return $"{this.Id}.{extension}";
            }
        }
    }
}

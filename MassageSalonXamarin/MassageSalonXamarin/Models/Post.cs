using System;
using System.Collections.Generic;
using System.Text;


namespace MassageSalonXamarin.Models
{
    public partial class Post
    {
        public Post()
        {
            Workers = new HashSet<Worker>();
        }

        public long Idpost { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Worker> Workers { get; set; }
    }
}

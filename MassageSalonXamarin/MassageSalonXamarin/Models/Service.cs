using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Service
    {
        public Service()
        {
            Events = new HashSet<Event>();
            ReceptionLives = new HashSet<ReceptionLife>();
            ReceptionOnlines = new HashSet<ReceptionOnline>();
        }

        public long Idservice { get; set; }
        public string Name { get; set; } = null!;
        public int Cost { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ReceptionLife> ReceptionLives { get; set; }
        public virtual ICollection<ReceptionOnline> ReceptionOnlines { get; set; }
    }
}

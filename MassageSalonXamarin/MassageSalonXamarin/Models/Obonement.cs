using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Obonement
    {
        public Obonement()
        {
            ReceptionLives = new HashSet<ReceptionLife>();
            ReceptionOnlines = new HashSet<ReceptionOnline>();
        }

        public long Idobonement { get; set; }
        public string Name { get; set; } = null!;
        public int Time { get; set; }
        public int Cost { get; set; }

        public virtual ICollection<ReceptionLife> ReceptionLives { get; set; }
        public virtual ICollection<ReceptionOnline> ReceptionOnlines { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Shedules = new HashSet<Shedule>();
        }

        public long Idshift { get; set; }
        public string NumberShift { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Shedule> Shedules { get; set; }
    }
}

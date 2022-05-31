using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Shedule
    {
        public long Idschedule { get; set; }
        public long Idworkers { get; set; }
        public DateTime Day { get; set; }
        public long Idshift { get; set; }

        public virtual Shift IdshiftNavigation { get; set; } = null!;
        public virtual Worker IdworkersNavigation { get; set; } = null!;
    }
}

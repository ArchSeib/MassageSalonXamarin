using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Event
    {
        public long Idakcii { get; set; }
        public string NameAkcii { get; set; } = null!;
        public string TimeLiveAkcii { get; set; } = null!;
        public long? Idservices { get; set; }
        public string OpisanieAkcii { get; set; } = null!;

        public virtual Service? IdservicesNavigation { get; set; }
    }
}

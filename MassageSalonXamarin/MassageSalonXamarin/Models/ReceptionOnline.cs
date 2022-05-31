using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class ReceptionOnline
    {
        public long Idreception { get; set; }
        public long Idclients { get; set; }
        public long Idworkers { get; set; }
        public long Idservice { get; set; }
        public long Idobonement { get; set; }
        public DateTime DataReception { get; set; }
        public string TimeReception { get; set; } = null!;

        public virtual Client IdclientsNavigation { get; set; } = null!;
        public virtual Obonement IdobonementNavigation { get; set; } = null!;
        public virtual Service IdserviceNavigation { get; set; } = null!;
        public virtual Worker IdworkersNavigation { get; set; } = null!;
    }
}

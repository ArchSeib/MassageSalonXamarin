using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class ReceptionLife
    {
        public long IdreceptionLife { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public int Age { get; set; }
        public string Phone { get; set; } = null!;
        public long Idworkers { get; set; }
        public long Idservice { get; set; }
        public long Idobonement { get; set; }
        public DateTime DataReceptionLife { get; set; }
        public string TimeReception { get; set; } = null!;

        public virtual Obonement IdobonementNavigation { get; set; } = null!;
        public virtual Service IdserviceNavigation { get; set; } = null!;
        public virtual Worker IdworkersNavigation { get; set; } = null!;
    }
}

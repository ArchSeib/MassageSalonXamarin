using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Worker
    {
        public Worker()
        {
            ReceptionLives = new HashSet<ReceptionLife>();
            ReceptionOnlines = new HashSet<ReceptionOnline>();
            Shedules = new HashSet<Shedule>();
        }

        public long Idworkers { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public int Seria { get; set; }
        public int Number { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public long Idpost { get; set; }
        public string? Vk { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public int? Salary { get; set; }

        public virtual Post IdpostNavigation { get; set; } = null!;
        public virtual ICollection<ReceptionLife> ReceptionLives { get; set; }
        public virtual ICollection<ReceptionOnline> ReceptionOnlines { get; set; }
        public virtual ICollection<Shedule> Shedules { get; set; }
    }
}

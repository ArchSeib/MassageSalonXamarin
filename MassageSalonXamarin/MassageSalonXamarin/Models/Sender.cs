using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Sender
    {
        public Sender()
        {
            MessageSalons = new HashSet<MessageSalon>();
        }

        public long Idsender { get; set; }
        public string Sender1 { get; set; } = null!;

        public virtual ICollection<MessageSalon> MessageSalons { get; set; }
    }
}

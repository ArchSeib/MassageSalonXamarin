using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class MessageSalon
    {
        public long IdmessageSalon { get; set; }
        public long Idclient { get; set; }
        public string Message { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Status { get; set; } = null!;
        public long Idsender { get; set; }

        public virtual Client IdclientNavigation { get; set; } = null!;
        public virtual Sender IdsenderNavigation { get; set; } = null!;
    }
}

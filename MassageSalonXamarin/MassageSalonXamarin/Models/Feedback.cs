using System;
using System.Collections.Generic;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Feedback
    {
        public long Idfeedback { get; set; }
        public long Idclients { get; set; }
        public string Text { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual Client IdclientsNavigation { get; set; } = null!;
    }
}

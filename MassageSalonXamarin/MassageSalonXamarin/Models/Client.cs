using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class Client
    {
        public Client()
        {
            Feedbacks = new HashSet<Feedback>();
            MessageSalons = new HashSet<MessageSalon>();
            ReceptionOnlines = new HashSet<ReceptionOnline>();
        }

        public long Idclients { get; set; }
        public string? LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public int Age { get; set; }
        public string Phone { get; set; } = null!;
        public string? Vk { get; set; }
        public string? Email { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int BallBonus { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<MessageSalon> MessageSalons { get; set; }
        public virtual ICollection<ReceptionOnline> ReceptionOnlines { get; set; }
    }
}

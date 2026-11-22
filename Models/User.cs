
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace win_Project_dating_site.Models;

public class User
{
    public int Id { get; set; }


        public string Name { get; set; } = "";

        public string Email { get; set; } = "";

        public string PasswordHash { get; set; } = "";

        public int Age { get; set; }

        public string City { get; set; } = "";

        public string Gender { get; set; } = "";

        public string Description { get; set; } = "";

        public string About { get; set; } = "";

        public string? PhotoUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    public ICollection<UserInterest> UserInterests { get; set; }
        = new List<UserInterest>();

    public ICollection<Message> SentMessages { get; set; }
        = new List<Message>();

    public ICollection<Message> ReceivedMessages { get; set; }
        = new List<Message>();
}

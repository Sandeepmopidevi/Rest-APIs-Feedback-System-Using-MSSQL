using System;
using System.Collections.Generic;

namespace WebAppAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        // Navigation property
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}

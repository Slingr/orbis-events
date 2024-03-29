﻿using System.Collections.Generic;

namespace OrbisEvents.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
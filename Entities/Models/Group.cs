﻿using Entities.Interfaces;

namespace Entities.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Role Role { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}

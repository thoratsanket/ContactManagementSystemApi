﻿using System.ComponentModel.DataAnnotations;

namespace ContactManagement.API.DataAccess.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}

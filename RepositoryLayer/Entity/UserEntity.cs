﻿using System.ComponentModel.DataAnnotations;
namespace RepositoryLayer.Entity
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bloggit.Server.Models
{
    public class User : IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "timestamp with time zone")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "timestamp with time zone")]
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "timestamp with time zone")]
        public DateTime LastLogin { get; set; } = DateTime.UtcNow;

        public bool IsAdmin { get; set; } = false;
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace BeSide.Common.Entities
{
    public class ContactMessage : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
    }
}

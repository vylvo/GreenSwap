using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSwap.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        [Required]
        public string Location { get; set; }

        public string ProfileDescription { get; set; }

        // Navigation properties
        public virtual ICollection<Plant> Plants { get; set; }
        public virtual ICollection<Trade> RequestedTrades { get; set; }
        public virtual ICollection<Trade> ProvidedTrades { get; set; }

        public User()
        {
            Plants = new HashSet<Plant>();
            RequestedTrades = new HashSet<Trade>();
            ProvidedTrades = new HashSet<Trade>();
        }
    }
}
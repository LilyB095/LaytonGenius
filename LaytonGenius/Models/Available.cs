using System;
using System.ComponentModel.DataAnnotations;

namespace LaytonGenius.Models
{
    public class Available
    {
        [Key]
        [Required]
        public int DateID { get; set; }
        public DateTime Date { get; set; }
    }
}

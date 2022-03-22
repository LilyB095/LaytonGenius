﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace LaytonGenius.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        [BindNever]
        public int AppId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "Value cannot exceed 15 people")]
        public int Size { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public bool Completed { get; set; }
    }
}
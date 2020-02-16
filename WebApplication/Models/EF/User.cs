using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication.Models.EF
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(255)]
        public string Lastname { get; set; }
        [Required]
       
        public DateTime Birthdate { get; set; }
        [Required]
        
        public float Height { get; set; }


    }
}
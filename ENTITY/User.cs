using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENTITY
{
    public class User
    {
      
        public int Id { get; set; }
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        

        public DateTime Birthdate { get; set; }
        

        public float Height { get; set; }
    }
}

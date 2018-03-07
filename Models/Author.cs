using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace CrudMvcAspNetCore.Models  
{  
    public class Author  
    {  
        public int Id { get; set; }  
        [Required]  
        public string Name { get; set; }  
    }  
}  
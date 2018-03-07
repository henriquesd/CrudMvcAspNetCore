using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace CrudMvcAspNetCore.Models  
{  
    public class Book  
    {  
       public int Id { get; set; }  
        [Required]
        [Display(Name = "Title")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "Number of Pages")]
        public int NumberOfPages {get;set;}  
        [Required]
        [Display(Name = "Author")]  
        public int AuthorId { get; set; } 
        public Author Author { get; set; }
        [Required]
        [Display(Name = "Publisher")]
        public int PublisherId { get; set; } 
        public Publisher Publisher { get; set; } 
    }  
}  
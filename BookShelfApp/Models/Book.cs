using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfApp.Models
{
    public class Book
    {
        [Required]
        [Display(Name = "Book Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Required]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Date Published")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Book Owner")]
        public string AppUser { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BookStore.Enums;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength (100,MinimumLength =5)]
        [Required (ErrorMessage ="Please Enter the Title of the Book")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter the Author Name")]
        public string Author { get; set; }
     

        public string Description { get; set; }
        public string Category { get; set; }
        [Required (ErrorMessage ="Please Choose the Language of your book")]
        public int LanguageId { get; set; }
        public string Language { get; set; }

        [Display (Name ="Total Pages Of Book")]
        [Required(ErrorMessage = "Please Enter the Total pages")]
        public int? TotalPages { get; set; }



    }
}
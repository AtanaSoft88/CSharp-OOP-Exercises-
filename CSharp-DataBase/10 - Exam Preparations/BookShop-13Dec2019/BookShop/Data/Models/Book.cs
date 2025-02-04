﻿using BookShop.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Data.Models
{
    public class Book
    {
        public Book()
        {
            AuthorsBooks = new HashSet<AuthorBook>();
        }
       
        public int Id { get; set; } //PK

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; } //Required by default
        
        public decimal Price { get; set; } // Not required?
        public int Pages { get; set; } // Not required?
        
        public DateTime PublishedOn { get; set; } // Required by default

        public virtual ICollection<AuthorBook> AuthorsBooks { get; set; }

        //•	Id - integer, Primary Key
        //•	Name - text with length[3, 30]. (required)
        //•	Genre - enumeration of type Genre, with possible values(Biography = 1, Business = 2, Science = 3) (required)
        //•	Price - decimal in range between 0.01 and max value of the decimal
        //•	Pages – integer in range between 50 and 5000
        //•	PublishedOn - date and time(required)
        //•	AuthorsBooks - collection of type AuthorBook

    }
}

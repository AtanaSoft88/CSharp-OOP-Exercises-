﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Footballers.Data.Models
{
    public class Team
    {
        public Team()
        {
            TeamsFootballers = new HashSet<TeamFootballer>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(40)]
        public string Nationality { get; set; }

        [Required]
        public int Trophies { get; set; }

        public virtual ICollection<TeamFootballer> TeamsFootballers { get; set; }

        //•	Id – integer, Primary Key
        //•	Name – text with length[3, 40]. May contain letters(lower and upper case), digits, spaces, a dot sign('.') and a dash('-'). (required)
        //•	Nationality – text with length[2, 40] (required)
        //•	Trophies – integer(required)
        //•	TeamsFootballers – collection of type TeamFootballer

    }
}

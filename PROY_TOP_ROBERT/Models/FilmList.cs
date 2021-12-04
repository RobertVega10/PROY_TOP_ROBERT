using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Table("film_list")]
    public partial class FilmList
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
 
        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Price { get; set; }

        public string Length { get; set; }

        public string Rating { get; set; }

        public string Actors { get; set; }
        public virtual Film Film { get; set; }
    }
}

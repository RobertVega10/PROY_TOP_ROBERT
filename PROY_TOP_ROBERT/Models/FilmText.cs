using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Table("film_text")]
    public partial class FilmText
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }

        [ForeignKey(nameof(FilmId))]
        [InverseProperty("FilmText")]
        public virtual Film Film { get; set; }
        public virtual FilmList FilmList { get; set; }
    }
}

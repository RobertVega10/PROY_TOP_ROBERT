using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Table("film_category")]
    public partial class FilmCategory
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey(nameof(FilmId))]
        [InverseProperty("FilmCategories")]
        public virtual Film Film { get; set; }
    }
}

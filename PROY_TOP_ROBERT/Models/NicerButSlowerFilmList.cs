using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("nicer_but_slower_film_list")]
    public partial class NicerButSlowerFilmList
    {
        [Column("FID")]
        public double? Fid { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("category")]
        [StringLength(255)]
        public string Category { get; set; }
        [Column("price")]
        public double? Price { get; set; }
        [Column("length")]
        public double? Length { get; set; }
        [Column("rating")]
        [StringLength(255)]
        public string Rating { get; set; }
        [Column("actors")]
        [StringLength(255)]
        public string Actors { get; set; }
    }
}

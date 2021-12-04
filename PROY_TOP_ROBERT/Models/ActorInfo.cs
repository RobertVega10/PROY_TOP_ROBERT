using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("actor_info")]
    public partial class ActorInfo
    {
        [Column("actor_id")]
        public double? ActorId { get; set; }
        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Column("film_info")]
        public string FilmInfo { get; set; }
    }
}

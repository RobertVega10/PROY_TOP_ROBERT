using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("country")]
    public partial class Country
    {
        [Column("country_id")]
        public double? CountryId { get; set; }
        [Column("country")]
        [StringLength(255)]
        public string Country1 { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
    }
}

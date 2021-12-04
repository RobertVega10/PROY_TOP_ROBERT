using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("category")]
    public partial class Category
    {
        [Column("category_id")]
        public double? CategoryId { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
    }
}

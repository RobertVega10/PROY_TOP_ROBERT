using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        [Key]
        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("store_id")]
        public double? StoreId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey(nameof(FilmId))]
        [InverseProperty("Inventories")]
        public virtual Film Film { get; set; }
    }
}

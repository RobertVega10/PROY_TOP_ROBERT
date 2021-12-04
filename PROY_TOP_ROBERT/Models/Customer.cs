using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("customer")]
    public partial class Customer
    {
        [Column("customer_id")]
        public double? CustomerId { get; set; }
        [Column("store_id")]
        public double? StoreId { get; set; }
        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("address_id")]
        public double? AddressId { get; set; }
        [Column("active")]
        public double? Active { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
    }
}

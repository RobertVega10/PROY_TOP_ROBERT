using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("address")]
    public partial class Address
    {
        [Column("address_id")]
        public double? AddressId { get; set; }
        [Column("address")]
        [StringLength(255)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Column("district")]
        [StringLength(255)]
        public string District { get; set; }
        [Column("city_id")]
        public double? CityId { get; set; }
        [Column("postal_code")]
        [StringLength(255)]
        public string PostalCode { get; set; }
        [Column("phone")]
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("location")]
        [StringLength(255)]
        public string Location { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
    }
}

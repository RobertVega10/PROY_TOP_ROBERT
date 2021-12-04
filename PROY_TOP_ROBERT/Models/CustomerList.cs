using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("customer_list")]
    public partial class CustomerList
    {
        [Column("ID")]
        public double? Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("address")]
        [StringLength(255)]
        public string Address { get; set; }
        [Column("zip code")]
        [StringLength(255)]
        public string ZipCode { get; set; }
        [Column("phone")]
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("country")]
        [StringLength(255)]
        public string Country { get; set; }
        [Column("notes")]
        [StringLength(255)]
        public string Notes { get; set; }
        [Column("SID")]
        public double? Sid { get; set; }
    }
}

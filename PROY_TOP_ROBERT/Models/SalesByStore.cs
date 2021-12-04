using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("sales_by_store")]
    public partial class SalesByStore
    {
        [Column("store")]
        [StringLength(255)]
        public string Store { get; set; }
        [Column("manager")]
        [StringLength(255)]
        public string Manager { get; set; }
        [Column("total_sales")]
        public double? TotalSales { get; set; }
    }
}

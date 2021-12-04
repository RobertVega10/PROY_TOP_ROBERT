using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("sales_by_film_category")]
    public partial class SalesByFilmCategory
    {
        [Column("category")]
        [StringLength(255)]
        public string Category { get; set; }
        [Column("total_sales")]
        public double? TotalSales { get; set; }
    }
}

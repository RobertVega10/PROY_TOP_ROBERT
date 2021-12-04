using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Keyless]
    [Table("Sheet1")]
    public partial class Sheet1
    {
        [StringLength(255)]
        public string F1 { get; set; }
    }
}

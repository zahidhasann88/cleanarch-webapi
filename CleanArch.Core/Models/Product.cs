using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Models
{
    [Table("product")]
    public partial class Product
    {
        [Key]
        [Column("id")]
        public long ProductId { get; set; }
        [Column("productname")]
        public string? ProductName { get; set; }
    }
}

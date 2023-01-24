using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Core.Models
{
    [Table("useradmin")]
    public partial class UserAdmin
    {
        [Key]
        [Column("userid")]
        public long UserId { get; set; }
        [Column("firstname")]
        public string? FirstName { get; set; }
        [Column("lastname")]
        public string? LastName { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("createdby")]
        public string? CreatedBy { get; set; }
        [Column("createdon")]
        public DateTime? CreatedOn { get; set; }
        [Column("modifiedby")]
        public string? ModifiedBy { get; set; }
        [Column("modifiedon")]
        public DateTime? ModifiedOn { get; set; }
        [Column("isdeleted")]
        public bool? IsDeleted { get; set; }
        [Column("isactive")]
        public bool? IsActive { get; set; }
    }
}

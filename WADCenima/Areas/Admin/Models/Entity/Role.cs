using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADCenima.Areas.Admin.Models.Entity
{
    [Table("Role")]
    public class Role
    {
        public Guid RoleId { get; set; }
        [StringLength(50)]
        public string NameRole { get; set; }
        public int? RoleEnum { get; set; }
        public ICollection<User> user { get; set; }
    }
}

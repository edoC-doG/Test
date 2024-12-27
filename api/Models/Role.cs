using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; } // Khóa chính của vai trò

        [Required]
        public string RoleName { get; set; } = string.Empty; // Tên vai trò (Admin, Manager, etc.)

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>(); // Liên kết với UserRole

        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>(); // Liên kết với RolePermission
    }
}
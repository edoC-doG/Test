using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermissionId { get; set; } // Khóa chính của quyền

        [Required]
        public string PermissionName { get; set; } = string.Empty; // Tên quyền (View, Edit, Delete, etc.)

        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>(); // Liên kết với RolePermission

        public ICollection<ResourcePermission> ResourcePermissions { get; set; } = new List<ResourcePermission>(); // Liên kết với ResourcePermission (nếu có)
    }
}
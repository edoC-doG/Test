using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class RolePermission
    {
        [Key]
        public int RolePermissionId { get; set; } // Khóa chính của RolePermission

        [Required]
        public int RoleId { get; set; } // ID của vai trò
        public Role? Role { get; set; } // Liên kết với Role

        [Required]
        public int PermissionId { get; set; } // ID của quyền
        public Permission? Permission { get; set; } // Liên kết với Permission
    }
}
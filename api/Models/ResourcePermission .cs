using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class ResourcePermission
    {
        [Key]
        public int ResourcePermissionId { get; set; } // Khóa chính của ResourcePermission

        [Required]
        public string ResourceName { get; set; } = string.Empty; // Tên tài nguyên (e.g., "API Endpoint", "File Path")

        [Required]
        public int PermissionId { get; set; } // ID của quyền
        public Permission? Permission { get; set; } // Liên kết với Permission
    }
}
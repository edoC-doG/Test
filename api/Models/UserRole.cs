using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; } // Khóa chính của UserRole

        [Required]
        public int EmployeeId { get; set; } // ID của nhân viên
        public Employee? Employee { get; set; } // Liên kết với Employee

        [Required]
        public int RoleId { get; set; } // ID của vai trò
        public Role? Role { get; set; } // Liên kết với Role
    }
}
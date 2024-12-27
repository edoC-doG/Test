using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyID { get; set; }  // Khóa chính của công ty

        [Required]
        public required string CompanyName { get; set; }

        [Required]
        public required string Address { get; set; }

        [Required]
        public required string Phone { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<ResourcePermission> ResourcePermissions { get; set; } = new List<ResourcePermission>();
        public Company()
        {
            Departments = new List<Department>();  // Khởi tạo danh sách Departments
            Employees = new List<Employee>();      // Khởi tạo danh sách Employees
        }
    }
}
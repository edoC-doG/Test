using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }

        [Required]
        public required string DepartmentName { get; set; }

        [Required]
        public int CompanyID { get; set; }

        public Company? Company { get; set; }

        // Thêm thuộc tính này để mô tả mối quan hệ một-nhiều
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<ResourcePermission> ResourcePermissions { get; set; } = new List<ResourcePermission>();
        public Department()
        {
            Employees = new List<Employee>();  // Khởi tạo danh sách Employees
        }
    }
}
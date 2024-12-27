using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffCode { get; set; }

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; } = string.Empty;


        public int? DepartmentID { get; set; }
        public int? CompanyID { get; set; }

        public Department Department { get; set; }
        public Company Company { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
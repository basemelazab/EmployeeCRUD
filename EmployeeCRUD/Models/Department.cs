﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeCRUD.Models
{
    [Table("Department", Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Department ID")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "*")]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "*")]
        [Column(TypeName = "varchar(5)")]
        [Display(Name = "Department Abbreviation")]
        public string DepartmentAbbr { get; set; }
    }
}

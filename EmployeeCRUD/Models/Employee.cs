using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeCRUD.Models
{
    [Table("Employee", Schema = "dbo")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "*")]
        [Column(TypeName = "varchar(5)")]
        [MaxLength(5)]
        [Display(Name = "Employee Number")]
        public string EmployeeNumber { get; set; }

        [Required(ErrorMessage = "*")]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(150)]
        [Display(Name = "Employee Name")]

        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        [Display(Name = "Hiring Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime HirindDate { get; set; }

        [Required(ErrorMessage = "*")]
        [Column(TypeName = "decimal(12,2)")]
        [Display(Name = "Gross Salary")]
        public decimal GrossSalary { get; set; }

        [Required(ErrorMessage = "*")]
        [Column(TypeName = "decimal(12,2)")]
        [Display(Name = "Net Salary")]

        public decimal NetSalary { get; set; }
        [ForeignKey("Department")]
        [Required(ErrorMessage = "*")]
        public int DepartmentId { get; set; }

        [NotMapped]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }

        public virtual Department Department { get; set; }

    }
}

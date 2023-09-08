using System.ComponentModel.DataAnnotations;

namespace Api_Project.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter Name.")]
        public string epmName { get; set; }
        public string empCode { get; set; }
        public int epmSalary { get; set; }
        public int supervisorId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}

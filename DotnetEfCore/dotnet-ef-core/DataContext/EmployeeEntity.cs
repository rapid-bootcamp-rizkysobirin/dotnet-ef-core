using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core.DataContext
{
    [Table("tbl_employee")]
    public class EmployeeEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("employee_name")]
        public String Name { get; set; }
        [Column("employee_position")]
        public String Position { get; set; }
        [Column("employee_email")]
        public String Email { get; set; }
        [Column("employee_number")]
        public String Number { get; set; }
        [Column("employee_address")]
        public String Address { get; set; }
    }
}


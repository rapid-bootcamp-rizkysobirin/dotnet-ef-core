using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core.DataContext
{
    [Table("tbl_admin")]
    public class AdminEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("admin_name")]
        public String Name { get; set; }
        [Column("admin_role")]
        public int Role { get; set; }
        [Column("admin_email")]
        public String Email { get; set; }
        [Column("IdAudit")]
        public int IdAudit { get; set; }
    }
}
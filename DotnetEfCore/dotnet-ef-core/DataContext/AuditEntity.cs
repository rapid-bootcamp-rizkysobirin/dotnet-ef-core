using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dotnet_ef_core.DataContext
{
    [Table("tbl_audit")]
    public class AuditEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asset_id")]
        public int IdAsset { get; set; }
        [Column("anti_virus")]
        public bool AntiVirus { get; set; }
        [Column("windows_license")]
        public bool WindowsLicense { get; set; }
        [Column("office_license")]
        public bool OfficeLicense { get; set; }
        [Column("condition")]
        public String Condition { get; set; }
        [Column("validation")]
        public String Validation { get;set; }
    }   
}
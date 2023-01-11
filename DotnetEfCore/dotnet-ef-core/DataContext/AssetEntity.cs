using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core.DataContext
{
    [Table("tbl_asset")]
    public class AssetEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asset_name")]
        public String Name { get; set; }
        [Column("asset_specification")]
        public String Specification { get; set; }
        [Column("asset_serial_number")]
        public String SerialNumber { get; set; }
        [Column("asset_purchase_year")]
        public int PurchaseYear { get; set; }
    }
}


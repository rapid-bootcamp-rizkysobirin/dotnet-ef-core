using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core.DataContext
{
    [Table("tbl_request")]
    public class RequestEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asset_id")]
        public int IdAsset { get; set; }
        [Column("pic_id")]
        public String PicId { get; set; }
        [Column("specificationRequest")]
        public String SpecificationReq { get; set; }
        [Column("necessary")]
        public String Necessary { get; set; } 
    }
}


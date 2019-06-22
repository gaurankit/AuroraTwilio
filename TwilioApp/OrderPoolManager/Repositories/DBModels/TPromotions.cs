using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tPromotions", Schema = "dbo")]
    public partial class TPromotions
    {
        [Key]
        [Column("PromotionID")]
        public int PromotionId { get; set; }
        [Required]
        [Column("ExternalPromotionID")]
        [StringLength(25)]
        public string ExternalPromotionId { get; set; }
        [StringLength(75)]
        public string PromotionDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal PromotionValue { get; set; }
        [Column("ExternalPromotionTermsID")]
        [StringLength(25)]
        public string ExternalPromotionTermsId { get; set; }
        [Column("CurrencyTypeID")]
        public byte? CurrencyTypeId { get; set; }
        [Column("CruiseID")]
        public int? CruiseId { get; set; }
        [Column("ProviderID")]
        public int? ProviderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey("CruiseId")]
        [InverseProperty("TPromotions")]
        public TCruise Cruise { get; set; }
        [ForeignKey("CurrencyTypeId")]
        [InverseProperty("TPromotions")]
        public TCurrencyType CurrencyType { get; set; }
        [ForeignKey("ProviderId")]
        [InverseProperty("TPromotions")]
        public TProvider Provider { get; set; }
    }
}

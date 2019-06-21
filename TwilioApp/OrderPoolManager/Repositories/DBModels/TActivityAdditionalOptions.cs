using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tActivityAdditionalOptions", Schema = "dbo")]
    public partial class TActivityAdditionalOptions
    {
        [Column("ActivityAdditionalOptionsID")]
        public int ActivityAdditionalOptionsId { get; set; }
        [Key]
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        public bool IsActivityRefundable { get; set; }
        [Column(TypeName = "money")]
        public decimal? InternalMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? ClientMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? FareQuoteAdjustmentAmount { get; set; }
        [StringLength(30)]
        public string FareQuoteAdjustmentType { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("TActivityAdditionalOptions")]
        public TActivity Activity { get; set; }
    }
}

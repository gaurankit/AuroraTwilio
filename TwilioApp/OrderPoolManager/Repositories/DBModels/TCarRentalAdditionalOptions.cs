using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCarRentalAdditionalOptions", Schema = "dbo")]
    public partial class TCarRentalAdditionalOptions
    {
        [Column("CarRentalAdditionalOptionsID")]
        public int CarRentalAdditionalOptionsId { get; set; }
        [Key]
        [Column("CarRentalID")]
        public int CarRentalId { get; set; }
        public bool IsCarRentalRefundable { get; set; }
        [Column(TypeName = "money")]
        public decimal? InternalMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? ClientMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? FareQuoteAdjustmentAmount { get; set; }
        [StringLength(30)]
        public string FareQuoteAdjustmentType { get; set; }

        [ForeignKey("CarRentalId")]
        [InverseProperty("TCarRentalAdditionalOptions")]
        public TCarRental CarRental { get; set; }
    }
}

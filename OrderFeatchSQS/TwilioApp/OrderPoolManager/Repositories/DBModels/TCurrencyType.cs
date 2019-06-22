using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCurrencyType", Schema = "dbo")]
    public partial class TCurrencyType
    {
        public TCurrencyType()
        {
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderAdjustment = new HashSet<TOrderAdjustment>();
            TOrderCurrency = new HashSet<TOrderCurrency>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TOrderRefundFailure = new HashSet<TOrderRefundFailure>();
            TPromotions = new HashSet<TPromotions>();
        }

        [Key]
        [Column("CurrencyTypeID")]
        public byte CurrencyTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string CurrencyType { get; set; }
        [Required]
        [StringLength(100)]
        public string CurrencyTypeDescription { get; set; }

        [InverseProperty("CurrencyType")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("CurrencyType")]
        public ICollection<TOrderAdjustment> TOrderAdjustment { get; set; }
        [InverseProperty("CurrencyType")]
        public ICollection<TOrderCurrency> TOrderCurrency { get; set; }
        [InverseProperty("CurrencyType")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("CurrencyType")]
        public ICollection<TOrderRefundFailure> TOrderRefundFailure { get; set; }
        [InverseProperty("CurrencyType")]
        public ICollection<TPromotions> TPromotions { get; set; }
    }
}

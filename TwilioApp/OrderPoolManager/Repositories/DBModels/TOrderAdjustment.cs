using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderAdjustment", Schema = "dbo")]
    public partial class TOrderAdjustment
    {
        public TOrderAdjustment()
        {
            TOrderAdjustmentError = new HashSet<TOrderAdjustmentError>();
        }

        [Key]
        [Column("OrderAdjustmentID")]
        public int OrderAdjustmentId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal? AdjustmentAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? AdjustmentAmountForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? AdjustmentProgramCurrency { get; set; }
        public bool IsAdjustmentPaymentCredited { get; set; }
        public bool IsAdjustmentProgramCurrencyCredited { get; set; }
        [Column("AdjustmentImportID")]
        public int? AdjustmentImportId { get; set; }
        [Required]
        [StringLength(50)]
        public string AdjustmentCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AdjustmentCreateDate { get; set; }
        [StringLength(50)]
        public string AdjustmentUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdjustmentUpdateDate { get; set; }
        [Column("CurrencyTypeID")]
        public byte CurrencyTypeId { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TOrderAdjustment")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("CurrencyTypeId")]
        [InverseProperty("TOrderAdjustment")]
        public TCurrencyType CurrencyType { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("TOrderAdjustment")]
        public TOrder Order { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TOrderAdjustment")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("OrderAdjustment")]
        public ICollection<TOrderAdjustmentError> TOrderAdjustmentError { get; set; }
    }
}

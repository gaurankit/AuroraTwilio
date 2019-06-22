using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tActivity", Schema = "dbo")]
    public partial class TActivity
    {
        public TActivity()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("ActivityUID")]
        public Guid ActivityUid { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("ActivityRuleGroupID")]
        public int? ActivityRuleGroupId { get; set; }
        [StringLength(200)]
        public string ActivitySupplierName { get; set; }
        [StringLength(200)]
        public string ActivityName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityStartDate { get; set; }
        [StringLength(100)]
        public string ActivityFirstName { get; set; }
        [StringLength(100)]
        public string ActivityLastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityEndDate { get; set; }
        [StringLength(50)]
        public string ActivityConfirmationCode { get; set; }
        [StringLength(100)]
        public string ActivityClientCatalogCode { get; set; }
        public int? ActivityParticipantCount { get; set; }
        public long? ActivityClientLineNumber { get; set; }
        [Column(TypeName = "money")]
        public decimal? ActivityTotalCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? ActivityTotalCostForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? ActivityCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? ActivityCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? ActivityProgramCurrencyAmountRequired { get; set; }
        public bool ActivityStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool ActivityPassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string ActivityLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string ActivityCurrencyDescription { get; set; }
        [StringLength(3)]
        public string ActivityCountry { get; set; }
        [StringLength(100)]
        public string ActivityMiddleName { get; set; }
        [StringLength(10)]
        public string ActivitySuffix { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TActivity")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TActivity")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TActivity")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("Activity")]
        public TActivityAdditionalOptions TActivityAdditionalOptions { get; set; }
        [InverseProperty("Activity")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("Activity")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("Activity")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("Activity")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("Activity")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

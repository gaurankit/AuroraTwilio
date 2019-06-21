using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tPackage", Schema = "dbo")]
    public partial class TPackage
    {
        public TPackage()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("PackageID")]
        public int PackageId { get; set; }
        [Column("PackageUID")]
        public Guid PackageUid { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("PackageRuleGroupID")]
        public int? PackageRuleGroupId { get; set; }
        [StringLength(200)]
        public string PackageSupplierName { get; set; }
        [StringLength(200)]
        public string PackageName { get; set; }
        [StringLength(100)]
        public string PackageFirstName { get; set; }
        [StringLength(100)]
        public string PackageLastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackageStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PackageEndDate { get; set; }
        [StringLength(50)]
        public string PackageConfirmationCode { get; set; }
        [StringLength(100)]
        public string PackageClientCatalogCode { get; set; }
        public int? PackageParticipantCount { get; set; }
        public long? PackageClientLineNumber { get; set; }
        [Column(TypeName = "money")]
        public decimal? PackageTotalCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? PackageTotalCostForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? PackageCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? PackageCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? PackageCommission { get; set; }
        [Column(TypeName = "money")]
        public decimal? PackageProgramCurrencyAmountRequired { get; set; }
        public bool PackageStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool PackagePassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string PackageLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string PackageCurrencyDescription { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TPackage")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TPackage")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TPackage")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("Package")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("Package")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("Package")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("Package")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("Package")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

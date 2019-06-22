using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tRetailProduct", Schema = "dbo")]
    public partial class TRetailProduct
    {
        public TRetailProduct()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("RetailProductID")]
        public int RetailProductId { get; set; }
        [Column("RetailProductUID")]
        public Guid RetailProductUid { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("RetailProductRuleGroupID")]
        public int? RetailProductRuleGroupId { get; set; }
        [StringLength(200)]
        public string RetailProductSupplierName { get; set; }
        [StringLength(200)]
        public string RetailProductName { get; set; }
        [StringLength(100)]
        public string RetailProductFirstName { get; set; }
        [StringLength(100)]
        public string RetailProductLastName { get; set; }
        public int? RetailProductQuantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RetailProductDateTime { get; set; }
        [StringLength(50)]
        public string RetailProductConfirmationCode { get; set; }
        [StringLength(100)]
        public string RetailProductClientCatalogCode { get; set; }
        public long? RetailProductClientLineNumber { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailProductTotalCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailProductTotalCostForeignCurrnecy { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailProductCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailProductCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailProductCommission { get; set; }
        [Column(TypeName = "money")]
        public decimal? RetailProductProgramCurrencyAmountRequired { get; set; }
        public bool RetailProductStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool RetailProductPassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string RetailProductLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string RetailProductCurrencyDescription { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TRetailProduct")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TRetailProduct")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TRetailProduct")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("RetailProduct")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("RetailProduct")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("RetailProduct")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("RetailProduct")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("RetailProduct")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCarRental", Schema = "dbo")]
    public partial class TCarRental
    {
        public TCarRental()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("CarRentalID")]
        public int CarRentalId { get; set; }
        [Column("CarRentalUID")]
        public Guid CarRentalUid { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("CarRentalRuleGroupID")]
        public int? CarRentalRuleGroupId { get; set; }
        [StringLength(200)]
        public string CarRentalSupplierName { get; set; }
        public long? CarRentalClientLineNumber { get; set; }
        [StringLength(100)]
        public string CarRentalFirstName { get; set; }
        [StringLength(100)]
        public string CarRentalLastName { get; set; }
        [StringLength(3)]
        public string CarRentalPickUpLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CarRentalPickUpDateTime { get; set; }
        [StringLength(3)]
        public string CarRentalDropOffLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CarRentalDropOffDateTime { get; set; }
        [StringLength(50)]
        public string CarRentalConfirmationCode { get; set; }
        [StringLength(100)]
        public string CarRentalClientCatalogCode { get; set; }
        [StringLength(50)]
        public string CarRentalType { get; set; }
        [Column(TypeName = "money")]
        public decimal? CarRentalTotalCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? CarRentalTotalCostForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? CarRentalCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? CarRentalCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? CarRentalCommission { get; set; }
        [Column(TypeName = "money")]
        public decimal? CarRentalProgramCurrencyAmountRequired { get; set; }
        public bool CarRentalStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool CarRentalPassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string CarRentalLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string CarRentalCurrencyDescription { get; set; }
        public bool IsClientProvidedInventory { get; set; }
        [StringLength(50)]
        public string CarRentalCityPickUpLocation { get; set; }
        [StringLength(50)]
        public string CarRentalCityDropOffLocation { get; set; }
        [StringLength(100)]
        public string CarRentalMiddleName { get; set; }
        [StringLength(10)]
        public string CarRentalSuffix { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TCarRental")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TCarRental")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TCarRental")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("CarRental")]
        public TCarRentalAdditionalOptions TCarRentalAdditionalOptions { get; set; }
        [InverseProperty("CarRental")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("CarRental")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("CarRental")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("CarRental")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("CarRental")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

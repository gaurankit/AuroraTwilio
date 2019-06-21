using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCruise", Schema = "dbo")]
    public partial class TCruise
    {
        public TCruise()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TPromotions = new HashSet<TPromotions>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("CruiseID")]
        public int CruiseId { get; set; }
        [Column("CruiseUID")]
        public Guid CruiseUid { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("CruiseShipID")]
        public int? CruiseShipId { get; set; }
        [Column("CruiseRuleGroupID")]
        public int? CruiseRuleGroupId { get; set; }
        [StringLength(100)]
        public string CruiseSupplierName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CruiseStartDate { get; set; }
        [StringLength(100)]
        public string CruiseFirstName { get; set; }
        [StringLength(100)]
        public string CruiseLastName { get; set; }
        [StringLength(2)]
        public string CruiseGender { get; set; }
        [StringLength(20)]
        public string CruiseAge { get; set; }
        [StringLength(20)]
        public string CruiseLoyaltyNumber { get; set; }
        public int? CruiseLength { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CruiseEndDate { get; set; }
        [StringLength(50)]
        public string CruiseConfirmationCode { get; set; }
        [StringLength(100)]
        public string CruiseClientCatalogCode { get; set; }
        public int? CruiseParticipantCount { get; set; }
        public long? CruiseClientLineNumber { get; set; }
        [Column(TypeName = "money")]
        public decimal? CruiseTotalCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? CruiseTotalCostForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? CruiseCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? CruiseCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? CruiseCommission { get; set; }
        [StringLength(20)]
        public string RateOptionCode { get; set; }
        [StringLength(15)]
        public string RateType { get; set; }
        [Column(TypeName = "money")]
        public decimal? NetRateAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? DepositAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? MarkupAmount { get; set; }
        [Column("NCCF", TypeName = "money")]
        public decimal? Nccf { get; set; }
        [Column(TypeName = "money")]
        public decimal? TaxesAndFees { get; set; }
        [Column(TypeName = "money")]
        public decimal? CruiseProgramCurrencyAmountRequired { get; set; }
        public bool CruiseStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool CruisePassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string CruiseLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string CruiseCurrencyDescription { get; set; }
        [Column("CruiseOrderXML", TypeName = "xml")]
        public string CruiseOrderXml { get; set; }
        [Column("PrimaryCruiseDestinationID")]
        public int? PrimaryCruiseDestinationId { get; set; }
        [Column("DeparturePortID")]
        [StringLength(5)]
        public string DeparturePortId { get; set; }
        [StringLength(150)]
        public string DeparturePortName { get; set; }
        public bool? IsRoundTrip { get; set; }
        [Column("ArrivalPortID")]
        [StringLength(5)]
        public string ArrivalPortId { get; set; }
        [StringLength(150)]
        public string ArrivalPortName { get; set; }
        [StringLength(10)]
        public string CabinNumber { get; set; }
        [StringLength(10)]
        public string CabinCategoryCode { get; set; }
        [StringLength(50)]
        public string CabinCategoryName { get; set; }
        [StringLength(2)]
        public string CabinTypeCode { get; set; }
        [Column("GroupBookingID")]
        [StringLength(20)]
        public string GroupBookingId { get; set; }
        [Column(TypeName = "decimal(9, 5)")]
        public decimal? ConversionRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepositDueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinalPaymentDueDate { get; set; }
        [Column("ExternalTripID")]
        [StringLength(25)]
        public string ExternalTripId { get; set; }
        [Column("CruiseProcessingStatusID")]
        public int? CruiseProcessingStatusId { get; set; }
        [Column("CruiseBookingPaymentStateID")]
        public int? CruiseBookingPaymentStateId { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TCruise")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("CruiseBookingPaymentStateId")]
        [InverseProperty("TCruise")]
        public TCruiseBookingPaymentState CruiseBookingPaymentState { get; set; }
        [ForeignKey("CruiseProcessingStatusId")]
        [InverseProperty("TCruise")]
        public TCruiseProcessingStatus CruiseProcessingStatus { get; set; }
        [ForeignKey("CruiseShipId")]
        [InverseProperty("TCruise")]
        public TCruiseShip CruiseShip { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TCruise")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TCruise")]
        public TOrderStatusType OrderStatusType { get; set; }
        [ForeignKey("PrimaryCruiseDestinationId")]
        [InverseProperty("TCruise")]
        public TPrimaryCruiseDestination PrimaryCruiseDestination { get; set; }
        [InverseProperty("Cruise")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("Cruise")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("Cruise")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("Cruise")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("Cruise")]
        public ICollection<TPromotions> TPromotions { get; set; }
        [InverseProperty("Cruise")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

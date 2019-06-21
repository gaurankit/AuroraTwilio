using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tAirTicket", Schema = "dbo")]
    public partial class TAirTicket
    {
        public TAirTicket()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("AirTicketID")]
        public int AirTicketId { get; set; }
        [Column("AirTicketUID")]
        public Guid AirTicketUid { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("ClassOfServiceTypeID")]
        public int ClassOfServiceTypeId { get; set; }
        [Column("AirTicketRuleGroupID")]
        public int? AirTicketRuleGroupId { get; set; }
        [StringLength(200)]
        public string AirlineName { get; set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string AirlineCode { get; set; }
        [StringLength(100)]
        public string AirTicketFirstName { get; set; }
        [StringLength(100)]
        public string AirTicketLastName { get; set; }
        public long? AirTicketClientLineNumber { get; set; }
        [StringLength(3)]
        public string AirTicketOrigin { get; set; }
        [StringLength(3)]
        public string AirTicketDestination { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AirTicketDepartureDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AirTicketReturnDateTime { get; set; }
        [StringLength(50)]
        public string AirTicketConfirmationCode { get; set; }
        [StringLength(100)]
        public string AirTicketClientCatalogCode { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketFareQuote { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketFareQuoteForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketProgramCurrencyAmountRequired { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketTax { get; set; }
        [Column(TypeName = "money")]
        public decimal? AirTicketTaxForeignCurrency { get; set; }
        public bool AirTicketStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool AirTicketPassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string AirTicketLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string AirTicketCurrencyDescription { get; set; }
        [StringLength(20)]
        public string PseudoCityCode { get; set; }
        [Column("IATA")]
        [StringLength(8)]
        public string Iata { get; set; }
        public bool IsClientProvidedInventory { get; set; }
        [StringLength(128)]
        public string AirTicketBrandName { get; set; }
        [StringLength(100)]
        public string AirTicketMiddleName { get; set; }
        [StringLength(10)]
        public string AirTicketSuffix { get; set; }

        [ForeignKey("ClassOfServiceTypeId")]
        [InverseProperty("TAirTicket")]
        public TClassOfServiceType ClassOfServiceType { get; set; }
        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("TAirTicket")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("TAirTicket")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("TAirTicket")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("AirTicket")]
        public TAirTicketAdditionalOptions TAirTicketAdditionalOptions { get; set; }
        [InverseProperty("AirTicket")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("AirTicket")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("AirTicket")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("AirTicket")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("AirTicket")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

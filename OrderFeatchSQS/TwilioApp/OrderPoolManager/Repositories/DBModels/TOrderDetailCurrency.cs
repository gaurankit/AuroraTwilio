using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetailCurrency", Schema = "dbo")]
    public partial class TOrderDetailCurrency
    {
        [Key]
        [Column("OrderDetailCurrencyID")]
        public int OrderDetailCurrencyId { get; set; }
        [Column("OrderDetailCurrencyCategoryUID")]
        public Guid OrderDetailCurrencyCategoryUid { get; set; }
        [Column("ProviderPaymentID")]
        public int? ProviderPaymentId { get; set; }
        [Column("CurrencyTypeID")]
        public byte CurrencyTypeId { get; set; }
        [Column("OrderDetailCurrencyStatusID")]
        public byte OrderDetailCurrencyStatusId { get; set; }
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("AirTicketID")]
        public int AirTicketId { get; set; }
        [Column("CarRentalID")]
        public int CarRentalId { get; set; }
        [Column("CruiseID")]
        public int CruiseId { get; set; }
        [Column("HotelRoomID")]
        public int HotelRoomId { get; set; }
        [Column("RetailProductID")]
        public int RetailProductId { get; set; }
        [Column("PackageID")]
        public int PackageId { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderDetailCurrencyAmount { get; set; }
        [Column(TypeName = "decimal(21, 6)")]
        public decimal OrderDetailCurrencyExchangeRate { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderDetailCurrencyAmountForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal MerchantRecoveryFee { get; set; }
        [Column(TypeName = "money")]
        public decimal MerchantRecoveryFeeForeignCurrency { get; set; }
        public int? BankIdentificationNumber { get; set; }
        [Column("OrderDetailAmountTypeID")]
        public byte OrderDetailAmountTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? ProgramCurrencyCashValue { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TActivity Activity { get; set; }
        [ForeignKey("AirTicketId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TAirTicket AirTicket { get; set; }
        [ForeignKey("CarRentalId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TCarRental CarRental { get; set; }
        [ForeignKey("CruiseId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TCruise Cruise { get; set; }
        [ForeignKey("CurrencyTypeId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TCurrencyType CurrencyType { get; set; }
        [ForeignKey("HotelRoomId")]
        [InverseProperty("TOrderDetailCurrency")]
        public THotelRoom HotelRoom { get; set; }
        [ForeignKey("OrderDetailCurrencyStatusId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TOrderDetailCurrencyStatus OrderDetailCurrencyStatus { get; set; }
        [ForeignKey("PackageId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TPackage Package { get; set; }
        [ForeignKey("RetailProductId")]
        [InverseProperty("TOrderDetailCurrency")]
        public TRetailProduct RetailProduct { get; set; }
    }
}

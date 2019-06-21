using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tFeeDetail", Schema = "dbo")]
    public partial class TFeeDetail
    {
        [Key]
        [Column("FeeDetailID")]
        public int FeeDetailId { get; set; }
        [Column("FeeDetailCategoryUID")]
        public Guid FeeDetailCategoryUid { get; set; }
        [Column("FeeTypeID")]
        public int FeeTypeId { get; set; }
        [Column("CurrencyTypeID")]
        public byte CurrencyTypeId { get; set; }
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
        public decimal FeeDetailAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal FeeDetailAmountForeignCurrency { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("TFeeDetail")]
        public TActivity Activity { get; set; }
        [ForeignKey("AirTicketId")]
        [InverseProperty("TFeeDetail")]
        public TAirTicket AirTicket { get; set; }
        [ForeignKey("CarRentalId")]
        [InverseProperty("TFeeDetail")]
        public TCarRental CarRental { get; set; }
        [ForeignKey("CruiseId")]
        [InverseProperty("TFeeDetail")]
        public TCruise Cruise { get; set; }
        [ForeignKey("CurrencyTypeId")]
        [InverseProperty("TFeeDetail")]
        public TCurrencyType CurrencyType { get; set; }
        [ForeignKey("HotelRoomId")]
        [InverseProperty("TFeeDetail")]
        public THotelRoom HotelRoom { get; set; }
        [ForeignKey("PackageId")]
        [InverseProperty("TFeeDetail")]
        public TPackage Package { get; set; }
        [ForeignKey("RetailProductId")]
        [InverseProperty("TFeeDetail")]
        public TRetailProduct RetailProduct { get; set; }
    }
}

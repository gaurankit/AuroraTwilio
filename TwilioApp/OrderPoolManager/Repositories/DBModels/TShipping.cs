using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tShipping", Schema = "dbo")]
    public partial class TShipping
    {
        [Key]
        [Column("ShippingID")]
        public int ShippingId { get; set; }
        [Column("ShippingStatusTypeID")]
        public int ShippingStatusTypeId { get; set; }
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("AirTicketID")]
        public int AirTicketId { get; set; }
        [Column("CarRentalID")]
        public int CarRentalId { get; set; }
        [Column("HotelRoomID")]
        public int HotelRoomId { get; set; }
        [Column("CruiseID")]
        public int CruiseId { get; set; }
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("PackageID")]
        public int PackageId { get; set; }
        [Column("RetailProductID")]
        public int RetailProductId { get; set; }
        [Column("OrderCategoryID")]
        public byte OrderCategoryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ShippingCreateDate { get; set; }
        [Required]
        [Column("ShippingSKU")]
        [StringLength(100)]
        public string ShippingSku { get; set; }
        [StringLength(50)]
        public string ShippingTrackingCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShippingDate { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("TShipping")]
        public TActivity Activity { get; set; }
        [ForeignKey("AirTicketId")]
        [InverseProperty("TShipping")]
        public TAirTicket AirTicket { get; set; }
        [ForeignKey("CarRentalId")]
        [InverseProperty("TShipping")]
        public TCarRental CarRental { get; set; }
        [ForeignKey("CruiseId")]
        [InverseProperty("TShipping")]
        public TCruise Cruise { get; set; }
        [ForeignKey("HotelRoomId")]
        [InverseProperty("TShipping")]
        public THotelRoom HotelRoom { get; set; }
        [ForeignKey("PackageId")]
        [InverseProperty("TShipping")]
        public TPackage Package { get; set; }
        [ForeignKey("ProviderId")]
        [InverseProperty("TShipping")]
        public TProvider Provider { get; set; }
        [ForeignKey("RetailProductId")]
        [InverseProperty("TShipping")]
        public TRetailProduct RetailProduct { get; set; }
        [ForeignKey("ShippingStatusTypeId")]
        [InverseProperty("TShipping")]
        public TShippingStatusType ShippingStatusType { get; set; }
    }
}

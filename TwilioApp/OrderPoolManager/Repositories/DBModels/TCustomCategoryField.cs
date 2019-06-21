using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCustomCategoryField", Schema = "dbo")]
    public partial class TCustomCategoryField
    {
        [Key]
        [Column("CustomCategoryFieldID")]
        public int CustomCategoryFieldId { get; set; }
        [Column("ActivityID")]
        public int? ActivityId { get; set; }
        [Column("AirTicketID")]
        public int? AirTicketId { get; set; }
        [Column("CarRentalID")]
        public int? CarRentalId { get; set; }
        [Column("CruiseID")]
        public int? CruiseId { get; set; }
        [Column("HotelRoomID")]
        public int? HotelRoomId { get; set; }
        [Column("RetailProductID")]
        public int? RetailProductId { get; set; }
        [Column("PackageID")]
        public int? PackageId { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryFieldName { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryFieldValue { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("TCustomCategoryField")]
        public TActivity Activity { get; set; }
        [ForeignKey("AirTicketId")]
        [InverseProperty("TCustomCategoryField")]
        public TAirTicket AirTicket { get; set; }
        [ForeignKey("CarRentalId")]
        [InverseProperty("TCustomCategoryField")]
        public TCarRental CarRental { get; set; }
        [ForeignKey("CruiseId")]
        [InverseProperty("TCustomCategoryField")]
        public TCruise Cruise { get; set; }
        [ForeignKey("HotelRoomId")]
        [InverseProperty("TCustomCategoryField")]
        public THotelRoom HotelRoom { get; set; }
        [ForeignKey("PackageId")]
        [InverseProperty("TCustomCategoryField")]
        public TPackage Package { get; set; }
        [ForeignKey("RetailProductId")]
        [InverseProperty("TCustomCategoryField")]
        public TRetailProduct RetailProduct { get; set; }
    }
}

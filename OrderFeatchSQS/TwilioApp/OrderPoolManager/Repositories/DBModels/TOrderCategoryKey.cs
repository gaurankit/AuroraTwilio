using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderCategoryKey", Schema = "dbo")]
    public partial class TOrderCategoryKey
    {
        public TOrderCategoryKey()
        {
            TCategoryCancelCriteria = new HashSet<TCategoryCancelCriteria>();
            TCategoryCancelDetail = new HashSet<TCategoryCancelDetail>();
            TOrderCategoryCancel = new HashSet<TOrderCategoryCancel>();
        }

        [Key]
        [Column("OrderCategoryKeyID")]
        public int OrderCategoryKeyId { get; set; }
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [Column("OrderCategoryID")]
        public int? OrderCategoryId { get; set; }
        [Column("AirTicketID")]
        public int? AirTicketId { get; set; }
        [Column("CarRentalID")]
        public int? CarRentalId { get; set; }
        [Column("HotelRoomID")]
        public int? HotelRoomId { get; set; }
        [Column("CruiseID")]
        public int? CruiseId { get; set; }
        [Column("ActivityID")]
        public int? ActivityId { get; set; }
        [Column("PackageID")]
        public int? PackageId { get; set; }
        [Column("RetailProductID")]
        public int? RetailProductId { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("TOrderCategoryKey")]
        public TActivity Activity { get; set; }
        [ForeignKey("AirTicketId")]
        [InverseProperty("TOrderCategoryKey")]
        public TAirTicket AirTicket { get; set; }
        [ForeignKey("CarRentalId")]
        [InverseProperty("TOrderCategoryKey")]
        public TCarRental CarRental { get; set; }
        [ForeignKey("CruiseId")]
        [InverseProperty("TOrderCategoryKey")]
        public TCruise Cruise { get; set; }
        [ForeignKey("HotelRoomId")]
        [InverseProperty("TOrderCategoryKey")]
        public THotelRoom HotelRoom { get; set; }
        [ForeignKey("PackageId")]
        [InverseProperty("TOrderCategoryKey")]
        public TPackage Package { get; set; }
        [ForeignKey("RetailProductId")]
        [InverseProperty("TOrderCategoryKey")]
        public TRetailProduct RetailProduct { get; set; }
        [InverseProperty("OrderCategoryKey")]
        public ICollection<TCategoryCancelCriteria> TCategoryCancelCriteria { get; set; }
        [InverseProperty("OrderCategoryKey")]
        public ICollection<TCategoryCancelDetail> TCategoryCancelDetail { get; set; }
        [InverseProperty("OrderCategoryKey")]
        public ICollection<TOrderCategoryCancel> TOrderCategoryCancel { get; set; }
    }
}

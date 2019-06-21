using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderStatusType", Schema = "dbo")]
    public partial class TOrderStatusType
    {
        public TOrderStatusType()
        {
            TActivity = new HashSet<TActivity>();
            TAirTicket = new HashSet<TAirTicket>();
            TCarRental = new HashSet<TCarRental>();
            TCruise = new HashSet<TCruise>();
            THotelRoom = new HashSet<THotelRoom>();
            TInsurance = new HashSet<TInsurance>();
            TOrderAdjustment = new HashSet<TOrderAdjustment>();
            TOrderStatusTypeCulture = new HashSet<TOrderStatusTypeCulture>();
            TPackage = new HashSet<TPackage>();
            TRetailProduct = new HashSet<TRetailProduct>();
        }

        [Key]
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Required]
        [StringLength(20)]
        public string OrderStatusType { get; set; }

        [InverseProperty("OrderStatusType")]
        public ICollection<TActivity> TActivity { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TAirTicket> TAirTicket { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TCarRental> TCarRental { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TCruise> TCruise { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<THotelRoom> THotelRoom { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TInsurance> TInsurance { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TOrderAdjustment> TOrderAdjustment { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TOrderStatusTypeCulture> TOrderStatusTypeCulture { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TPackage> TPackage { get; set; }
        [InverseProperty("OrderStatusType")]
        public ICollection<TRetailProduct> TRetailProduct { get; set; }
    }
}

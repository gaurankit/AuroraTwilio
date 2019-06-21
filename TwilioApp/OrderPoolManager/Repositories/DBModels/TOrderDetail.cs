using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetail", Schema = "dbo")]
    public partial class TOrderDetail
    {
        public TOrderDetail()
        {
            TActivity = new HashSet<TActivity>();
            TAirTicket = new HashSet<TAirTicket>();
            TCarRental = new HashSet<TCarRental>();
            TCruise = new HashSet<TCruise>();
            THotelRoom = new HashSet<THotelRoom>();
            TInsurance = new HashSet<TInsurance>();
            TOrderDetailConversion = new HashSet<TOrderDetailConversion>();
            TOrderDetailProviderLocator = new HashSet<TOrderDetailProviderLocator>();
            TOrderError = new HashSet<TOrderError>();
            TPackage = new HashSet<TPackage>();
            TRetailProduct = new HashSet<TRetailProduct>();
            TRuleGroupRegisterDetail = new HashSet<TRuleGroupRegisterDetail>();
            TSingleUseCard = new HashSet<TSingleUseCard>();
        }

        [Key]
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("OrderCategoryID")]
        public byte OrderCategoryId { get; set; }
        [StringLength(50)]
        public string OrderDetailClientCode { get; set; }
        [StringLength(20)]
        public string OrderDetailLastUpdatedBy { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderDetail")]
        public TOrder Order { get; set; }
        [InverseProperty("OrderDetail")]
        public TOrderDetailTripProduct TOrderDetailTripProduct { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TActivity> TActivity { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TAirTicket> TAirTicket { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TCarRental> TCarRental { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TCruise> TCruise { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<THotelRoom> THotelRoom { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TInsurance> TInsurance { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TOrderDetailConversion> TOrderDetailConversion { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TOrderDetailProviderLocator> TOrderDetailProviderLocator { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TOrderError> TOrderError { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TPackage> TPackage { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TRetailProduct> TRetailProduct { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TRuleGroupRegisterDetail> TRuleGroupRegisterDetail { get; set; }
        [InverseProperty("OrderDetail")]
        public ICollection<TSingleUseCard> TSingleUseCard { get; set; }
    }
}

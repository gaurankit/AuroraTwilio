using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProvider", Schema = "dbo")]
    public partial class TProvider
    {
        public TProvider()
        {
            TCategoryCancelDetail = new HashSet<TCategoryCancelDetail>();
            TCruiseLine = new HashSet<TCruiseLine>();
            TCruiseShip = new HashSet<TCruiseShip>();
            TInsurance = new HashSet<TInsurance>();
            TPromotions = new HashSet<TPromotions>();
            TProviderCancelPolicy = new HashSet<TProviderCancelPolicy>();
            TProviderCategory = new HashSet<TProviderCategory>();
            TProviderCulture = new HashSet<TProviderCulture>();
            TProviderLocator = new HashSet<TProviderLocator>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("ProviderTypeID")]
        public int ProviderTypeId { get; set; }
        [Column("OrderTypeID")]
        public byte OrderTypeId { get; set; }
        [StringLength(200)]
        public string ProviderName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProviderStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProviderEndDate { get; set; }
        [Column("AccountingSupplierID")]
        [StringLength(10)]
        public string AccountingSupplierId { get; set; }
        [Column("VendorSupplierID")]
        [StringLength(20)]
        public string VendorSupplierId { get; set; }
        [Column("ProviderURL")]
        [StringLength(2000)]
        public string ProviderUrl { get; set; }

        [ForeignKey("OrderTypeId")]
        [InverseProperty("TProvider")]
        public TOrderType OrderType { get; set; }
        [ForeignKey("ProviderTypeId")]
        [InverseProperty("TProvider")]
        public TProviderType ProviderType { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TCategoryCancelDetail> TCategoryCancelDetail { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TCruiseLine> TCruiseLine { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TCruiseShip> TCruiseShip { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TInsurance> TInsurance { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TPromotions> TPromotions { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TProviderCancelPolicy> TProviderCancelPolicy { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TProviderCategory> TProviderCategory { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TProviderCulture> TProviderCulture { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TProviderLocator> TProviderLocator { get; set; }
        [InverseProperty("Provider")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

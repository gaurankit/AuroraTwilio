using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetailProviderLocator", Schema = "dbo")]
    public partial class TOrderDetailProviderLocator
    {
        [Key]
        [Column("OrderDetailProviderLocatorID")]
        public int OrderDetailProviderLocatorId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("ProviderLocatorID")]
        public int ProviderLocatorId { get; set; }
        [Required]
        [StringLength(50)]
        public string DetailLocator { get; set; }

        [ForeignKey("OrderDetailId")]
        [InverseProperty("TOrderDetailProviderLocator")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("ProviderLocatorId")]
        [InverseProperty("TOrderDetailProviderLocator")]
        public TProviderLocator ProviderLocator { get; set; }
    }
}

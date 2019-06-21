using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderProviderLocator", Schema = "dbo")]
    public partial class TOrderProviderLocator
    {
        [Key]
        [Column("OrderProviderLocatorID")]
        public int OrderProviderLocatorId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("ProviderLocatorID")]
        public int ProviderLocatorId { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderLocator { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderProviderLocator")]
        public TOrder Order { get; set; }
        [ForeignKey("ProviderLocatorId")]
        [InverseProperty("TOrderProviderLocator")]
        public TProviderLocator ProviderLocator { get; set; }
    }
}

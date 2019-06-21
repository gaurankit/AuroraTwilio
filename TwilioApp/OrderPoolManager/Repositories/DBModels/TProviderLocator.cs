using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderLocator", Schema = "dbo")]
    public partial class TProviderLocator
    {
        public TProviderLocator()
        {
            TOrderDetailProviderLocator = new HashSet<TOrderDetailProviderLocator>();
            TOrderProviderLocator = new HashSet<TOrderProviderLocator>();
        }

        [Key]
        [Column("ProviderLocatorID")]
        public int ProviderLocatorId { get; set; }
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("ProviderLocatorTypeID")]
        public int ProviderLocatorTypeId { get; set; }
        [Column("ProviderLocatorImportID")]
        public int? ProviderLocatorImportId { get; set; }

        [ForeignKey("ProviderId")]
        [InverseProperty("TProviderLocator")]
        public TProvider Provider { get; set; }
        [ForeignKey("ProviderLocatorTypeId")]
        [InverseProperty("TProviderLocator")]
        public TProviderLocatorType ProviderLocatorType { get; set; }
        [InverseProperty("ProviderLocator")]
        public ICollection<TOrderDetailProviderLocator> TOrderDetailProviderLocator { get; set; }
        [InverseProperty("ProviderLocator")]
        public ICollection<TOrderProviderLocator> TOrderProviderLocator { get; set; }
    }
}

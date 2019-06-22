using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderLocatorType", Schema = "dbo")]
    public partial class TProviderLocatorType
    {
        public TProviderLocatorType()
        {
            TProviderLocator = new HashSet<TProviderLocator>();
        }

        [Key]
        [Column("ProviderLocatorTypeID")]
        public int ProviderLocatorTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProviderLocatorType { get; set; }

        [InverseProperty("ProviderLocatorType")]
        public ICollection<TProviderLocator> TProviderLocator { get; set; }
    }
}

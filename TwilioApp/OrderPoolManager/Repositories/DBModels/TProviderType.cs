using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderType", Schema = "dbo")]
    public partial class TProviderType
    {
        public TProviderType()
        {
            TProvider = new HashSet<TProvider>();
        }

        [Key]
        [Column("ProviderTypeID")]
        public int ProviderTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProviderType { get; set; }

        [InverseProperty("ProviderType")]
        public ICollection<TProvider> TProvider { get; set; }
    }
}

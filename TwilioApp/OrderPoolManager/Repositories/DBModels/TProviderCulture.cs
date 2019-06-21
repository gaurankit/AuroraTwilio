using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderCulture", Schema = "dbo")]
    public partial class TProviderCulture
    {
        [Key]
        [Column("ProviderCultureID")]
        public int ProviderCultureId { get; set; }
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("LCID")]
        public int Lcid { get; set; }
        [StringLength(100)]
        public string ProviderName { get; set; }

        [ForeignKey("ProviderId")]
        [InverseProperty("TProviderCulture")]
        public TProvider Provider { get; set; }
    }
}

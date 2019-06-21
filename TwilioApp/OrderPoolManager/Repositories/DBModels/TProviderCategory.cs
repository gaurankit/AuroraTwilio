using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderCategory", Schema = "dbo")]
    public partial class TProviderCategory
    {
        [Key]
        [Column("ProviderCategoryID")]
        public int ProviderCategoryId { get; set; }
        [Column("ProviderID")]
        public int ProviderId { get; set; }
        [Column("CategoryID")]
        public int CategoryId { get; set; }

        [ForeignKey("ProviderId")]
        [InverseProperty("TProviderCategory")]
        public TProvider Provider { get; set; }
    }
}

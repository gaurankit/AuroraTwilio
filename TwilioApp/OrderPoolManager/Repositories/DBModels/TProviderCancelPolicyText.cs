using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderCancelPolicyText", Schema = "dbo")]
    public partial class TProviderCancelPolicyText
    {
        public TProviderCancelPolicyText()
        {
            TProviderCancelPolicyProviderCancelPolicyText = new HashSet<TProviderCancelPolicyProviderCancelPolicyText>();
            TProviderCancelPolicyTextCulture = new HashSet<TProviderCancelPolicyTextCulture>();
        }

        [Key]
        [Column("ProviderCancelPolicyTextID")]
        public int ProviderCancelPolicyTextId { get; set; }
        [Required]
        [StringLength(4000)]
        public string PolicyText { get; set; }

        [InverseProperty("ProviderCancelPolicyText")]
        public ICollection<TProviderCancelPolicyProviderCancelPolicyText> TProviderCancelPolicyProviderCancelPolicyText { get; set; }
        [InverseProperty("ProviderCancelPolicyText")]
        public ICollection<TProviderCancelPolicyTextCulture> TProviderCancelPolicyTextCulture { get; set; }
    }
}

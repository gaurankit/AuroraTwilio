using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tProviderCancelPolicyTextCulture", Schema = "dbo")]
    public partial class TProviderCancelPolicyTextCulture
    {
        [Column("ProviderCancelPolicyTextCultureID")]
        public int ProviderCancelPolicyTextCultureId { get; set; }
        [Column("ProviderCancelPolicyTextID")]
        public int ProviderCancelPolicyTextId { get; set; }
        [Required]
        [StringLength(4000)]
        public string PolicyTextCulture { get; set; }
        [Column("LCID")]
        public int? Lcid { get; set; }

        [ForeignKey("ProviderCancelPolicyTextId")]
        [InverseProperty("TProviderCancelPolicyTextCulture")]
        public TProviderCancelPolicyText ProviderCancelPolicyText { get; set; }
    }
}

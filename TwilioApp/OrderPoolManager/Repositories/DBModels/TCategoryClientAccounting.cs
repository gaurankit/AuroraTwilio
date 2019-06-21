using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCategoryClientAccounting", Schema = "dbo")]
    public partial class TCategoryClientAccounting
    {
        [Key]
        [Column("CategoryClientAccountingID")]
        public int CategoryClientAccountingId { get; set; }
        [Column("CategoryUID")]
        public Guid CategoryUid { get; set; }
        [Column("OrderCategoryID")]
        public int OrderCategoryId { get; set; }
        [Column(TypeName = "money")]
        public decimal ClientMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? ClientMarkupForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal CostToClient { get; set; }
        [Column(TypeName = "money")]
        public decimal? CostToClientForeignCurrency { get; set; }
    }
}

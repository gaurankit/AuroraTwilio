using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderCurrency", Schema = "dbo")]
    public partial class TOrderCurrency
    {
        [Key]
        [Column("OrderCurrencyID")]
        public int OrderCurrencyId { get; set; }
        [Column("OrderAmountTypeID")]
        public byte OrderAmountTypeId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("CurrencyTypeID")]
        public byte CurrencyTypeId { get; set; }
        [Column("OrderCurrencyRuleGroupID")]
        public int? OrderCurrencyRuleGroupId { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderCurrencyClientCatalogBonusCost { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderCurrencyClientCatalogBonusCostForeignCurrency { get; set; }
        public byte? OrderCurrencyBonusQuantity { get; set; }
        [StringLength(100)]
        public string OrderCurrencyClientCatalogCode { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderCurrencyAmount { get; set; }
        [Column(TypeName = "decimal(21, 6)")]
        public decimal OrderCurrencyExchangeRate { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderCurrencyAmountForeignCurrency { get; set; }

        [ForeignKey("CurrencyTypeId")]
        [InverseProperty("TOrderCurrency")]
        public TCurrencyType CurrencyType { get; set; }
        [ForeignKey("OrderId")]
        [InverseProperty("TOrderCurrency")]
        public TOrder Order { get; set; }
        [ForeignKey("OrderAmountTypeId")]
        [InverseProperty("TOrderCurrency")]
        public TOrderAmountType OrderAmountType { get; set; }
    }
}

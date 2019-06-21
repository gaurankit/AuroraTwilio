using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrder", Schema = "dbo")]
    public partial class TOrder
    {
        public TOrder()
        {
            TOrderAccounting = new HashSet<TOrderAccounting>();
            TOrderAdjustment = new HashSet<TOrderAdjustment>();
            TOrderCurrency = new HashSet<TOrderCurrency>();
            TOrderDetail = new HashSet<TOrderDetail>();
            TOrderNote = new HashSet<TOrderNote>();
            TOrderParticipant = new HashSet<TOrderParticipant>();
            TOrderParticipantTax = new HashSet<TOrderParticipantTax>();
            TOrderProviderLocator = new HashSet<TOrderProviderLocator>();
            TOrderRefundFailure = new HashSet<TOrderRefundFailure>();
        }

        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        public Guid? TransitCode { get; set; }
        [Column("OrderClientID")]
        public int OrderClientId { get; set; }
        [Column("OrderClientProgramGroupID")]
        public int? OrderClientProgramGroupId { get; set; }
        [Column("OrderProgramID")]
        public int? OrderProgramId { get; set; }
        [StringLength(100)]
        public string ClientOrderCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClientOrderDate { get; set; }
        [Column("OrderImportID")]
        public int? OrderImportId { get; set; }
        [StringLength(10)]
        public string OrderInvoiceNumber { get; set; }
        public long? OrderDepositInvoiceNumber { get; set; }
        [StringLength(50)]
        public string OrderCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderCreateDateTime { get; set; }
        [StringLength(50)]
        public string OrderUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderUpdateDateTime { get; set; }
        [Column("LCID")]
        public int Lcid { get; set; }
        [Column(TypeName = "decimal(18, 9)")]
        public decimal OrderProgramCurrencyCostFactor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserOrderCreateDate { get; set; }

        [InverseProperty("Order")]
        public TOrderTripFolder TOrderTripFolder { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderAccounting> TOrderAccounting { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderAdjustment> TOrderAdjustment { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderCurrency> TOrderCurrency { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderDetail> TOrderDetail { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderNote> TOrderNote { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderParticipant> TOrderParticipant { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderParticipantTax> TOrderParticipantTax { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderProviderLocator> TOrderProviderLocator { get; set; }
        [InverseProperty("Order")]
        public ICollection<TOrderRefundFailure> TOrderRefundFailure { get; set; }
    }
}

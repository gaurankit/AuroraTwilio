using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tHotelRoom", Schema = "dbo")]
    public partial class THotelRoom
    {
        public THotelRoom()
        {
            TCustomCategoryField = new HashSet<TCustomCategoryField>();
            TFeeDetail = new HashSet<TFeeDetail>();
            TOrderCategoryKey = new HashSet<TOrderCategoryKey>();
            TOrderDetailCurrency = new HashSet<TOrderDetailCurrency>();
            TShipping = new HashSet<TShipping>();
        }

        [Key]
        [Column("HotelRoomID")]
        public int HotelRoomId { get; set; }
        [Column("HotelRoomUID")]
        public Guid HotelRoomUid { get; set; }
        [Column("HotelPropertyID")]
        public int HotelPropertyId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderStatusTypeID")]
        public int OrderStatusTypeId { get; set; }
        [Column("CreditReasonTypeID")]
        public int CreditReasonTypeId { get; set; }
        [Column("HotelRoomRuleGroupID")]
        public int? HotelRoomRuleGroupId { get; set; }
        [StringLength(200)]
        public string HotelRoomSupplierName { get; set; }
        public long? HotelRoomClientLineNumber { get; set; }
        [StringLength(100)]
        public string HotelRoomFirstName { get; set; }
        [StringLength(100)]
        public string HotelRoomLastName { get; set; }
        [StringLength(3)]
        public string HotelRoomLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HotelRoomCheckInDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HotelRoomCheckOutDateTime { get; set; }
        [StringLength(50)]
        public string HotelRoomConfirmationCode { get; set; }
        [StringLength(100)]
        public string HotelRoomClientCatalogCode { get; set; }
        public byte? HotelRoomOccupantCount { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomTotalCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomTotalCostForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomProgramCurrencyAmountRequired { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomCostOfGoods { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomCostOfGoodsForeignCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomDailyTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomDailyTotalForeignCurrency { get; set; }
        public bool HotelRoomStatusChangeBlockedToSystemOfRecord { get; set; }
        public bool HotelRoomPassThroughToVendor { get; set; }
        [Column("ImportUSD", TypeName = "money")]
        public decimal? ImportUsd { get; set; }
        [Column(TypeName = "money")]
        public decimal? ImportPoints { get; set; }
        [StringLength(20)]
        public string HotelRoomLastUpdatedBy { get; set; }
        [StringLength(3)]
        public string HotelRoomCurrencyDescription { get; set; }
        public bool IsClientProvidedInventory { get; set; }
        [Column(TypeName = "money")]
        public decimal? HotelRoomGrossProfitAmount { get; set; }
        [StringLength(100)]
        public string HotelRoomMiddleName { get; set; }
        [StringLength(10)]
        public string HotelRoomSuffix { get; set; }

        [ForeignKey("CreditReasonTypeId")]
        [InverseProperty("THotelRoom")]
        public TCreditReasonType CreditReasonType { get; set; }
        [ForeignKey("HotelPropertyId")]
        [InverseProperty("THotelRoom")]
        public THotelProperty HotelProperty { get; set; }
        [ForeignKey("OrderDetailId")]
        [InverseProperty("THotelRoom")]
        public TOrderDetail OrderDetail { get; set; }
        [ForeignKey("OrderStatusTypeId")]
        [InverseProperty("THotelRoom")]
        public TOrderStatusType OrderStatusType { get; set; }
        [InverseProperty("HotelRoom")]
        public THotelRoomAdditionalOptions THotelRoomAdditionalOptions { get; set; }
        [InverseProperty("HotelRoom")]
        public ICollection<TCustomCategoryField> TCustomCategoryField { get; set; }
        [InverseProperty("HotelRoom")]
        public ICollection<TFeeDetail> TFeeDetail { get; set; }
        [InverseProperty("HotelRoom")]
        public ICollection<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        [InverseProperty("HotelRoom")]
        public ICollection<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        [InverseProperty("HotelRoom")]
        public ICollection<TShipping> TShipping { get; set; }
    }
}

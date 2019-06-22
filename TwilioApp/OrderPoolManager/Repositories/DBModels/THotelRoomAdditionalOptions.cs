using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tHotelRoomAdditionalOptions", Schema = "dbo")]
    public partial class THotelRoomAdditionalOptions
    {
        [Column("HotelRoomAdditionalOptionsID")]
        public int HotelRoomAdditionalOptionsId { get; set; }
        [Key]
        [Column("HotelRoomID")]
        public int HotelRoomId { get; set; }
        public bool IsHotelRoomRefundable { get; set; }
        [Column(TypeName = "money")]
        public decimal? InternalMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? ClientMarkup { get; set; }
        [Column(TypeName = "money")]
        public decimal? FareQuoteAdjustmentAmount { get; set; }
        [StringLength(30)]
        public string FareQuoteAdjustmentType { get; set; }

        [ForeignKey("HotelRoomId")]
        [InverseProperty("THotelRoomAdditionalOptions")]
        public THotelRoom HotelRoom { get; set; }
    }
}

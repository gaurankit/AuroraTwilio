using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tHotelProperty", Schema = "dbo")]
    public partial class THotelProperty
    {
        public THotelProperty()
        {
            THotelRoom = new HashSet<THotelRoom>();
        }

        [Key]
        [Column("HotelPropertyID")]
        public int HotelPropertyId { get; set; }
        [StringLength(400)]
        public string HotelPropertyVendorName { get; set; }
        [StringLength(20)]
        public string HotelPropertySupplierChainCode { get; set; }
        [StringLength(400)]
        public string HotelPropertyAddress1 { get; set; }
        [StringLength(200)]
        public string HotelPropertyAddress2 { get; set; }
        [StringLength(200)]
        public string HotelPropertyCity { get; set; }
        [StringLength(2)]
        public string HotelPropertyState { get; set; }
        [StringLength(10)]
        public string HotelPropertyPostalCode { get; set; }
        [StringLength(200)]
        public string HotelPropertyCountry { get; set; }
        [StringLength(100)]
        public string HotelPropertyPhone { get; set; }
        [Column("HotelPropertyItineraryID")]
        public int? HotelPropertyItineraryId { get; set; }

        [InverseProperty("HotelProperty")]
        public ICollection<THotelRoom> THotelRoom { get; set; }
    }
}
